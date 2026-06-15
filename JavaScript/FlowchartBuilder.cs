//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;


namespace MindFusion.Diagramming.Wpf.Samples.CS.JavaScript
{
	class FlowchartBuilder
	{
		private class Flowchart
		{
			public Flowchart(Diagram diagram)
			{
				this.diagram = diagram;
				this.sequences = new Stack<List<ShapeNode>>();
			}

			public void EnterFunction(string text)
			{
				ShapeNode functionStartNode = diagram.CreateStartTerminatorNode(text);
				sequences.Push(new List<ShapeNode>(new ShapeNode[] { functionStartNode }));
			}

			public bool LeaveFunction(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> ends = sequences.Pop();
				if (ends.Count == 0)
					throw new InvalidOperationException();

				// Sequences end with 'null' if they are terminated by a return statement
				if (ends[0] == null)
					return sequences.Count == 0;

				ShapeNode functionEndNode = diagram.CreateEndTerminatorNode(text);

				foreach (ShapeNode end in ends)
					diagram.Factory.CreateDiagramLink(end, functionEndNode);

				return sequences.Count == 0;
			}

			public void AddExpression(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				// Sequences end with 'null' if they are terminated by a return statement
				if (top[0] == null)
					return;

				ShapeNode expressionNode = diagram.CreateProcessNode(text);

				diagram.Factory.CreateDiagramLink(top[0], expressionNode);
				top[0] = expressionNode;
			}

			public void AddReturnStatement(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				// Sequences end with 'null' if they are terminated by a return statement
				if (top[0] == null)
					return;

				ShapeNode returnNode = diagram.CreateEndTerminatorNode(text);

				diagram.Factory.CreateDiagramLink(top[0], returnNode);
				top[0] = null;
			}

			public void EnterChoice(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				ShapeNode choiceStartNode = diagram.CreateDecisionNode(text);

				diagram.Factory.CreateDiagramLink(top[0], choiceStartNode);
				top[0] = choiceStartNode;

				sequences.Push(new List<ShapeNode>(new ShapeNode[] { choiceStartNode }));
			}

			public void EnterBranch()
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				top.Insert(0, top[top.Count - 1]);
			}

			public void LeaveBranch()
			{
			}

			public void LeaveChoice(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Pop();
				if (top.Count == 0)
					throw new InvalidOperationException();

				ShapeNode choiceEndNode = diagram.CreateConnectorNode(text);

				for (int i = 0; i < top.Count - 1; i++)
				{
					// Sequences end with 'null' if they are terminated by a return statement
					if (top[i] != null)
						diagram.Factory.CreateDiagramLink(top[i], choiceEndNode);
				}

				// If it's an 'if' choice and there was only one branch, add
				// a direct link from the choice start node to the choice end node
				if (choiceEndNode.Text == "endif")
				{
					if (top.Count == 2)
						diagram.Factory.CreateDiagramLink(top[top.Count - 1], choiceEndNode);
				}

				// It it's a 'switch' choice and there are no branches at all,
				// add a link from the choice start node to the choice end node
				if (choiceEndNode.Text == "endswitch")
				{
					if (top.Count == 1)
						diagram.Factory.CreateDiagramLink(top[top.Count - 1], choiceEndNode);
				}

				// Replace the choice start node with the choice end node
				// in the current sequence
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				top[0] = choiceEndNode;
			}

			public void EnterLoop(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				ShapeNode loopStartNode = diagram.CreateLoopNode(text);

				diagram.Factory.CreateDiagramLink(top[0], loopStartNode);
				top[0] = loopStartNode;

				sequences.Push(new List<ShapeNode>(new ShapeNode[] { loopStartNode }));
			}

			public void LeaveLoop(string text)
			{
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				List<ShapeNode> top = sequences.Pop();
				if (top.Count == 0)
					throw new InvalidOperationException();

				ShapeNode loopEndNode = diagram.CreateEndLoopNode(text);

				diagram.Factory.CreateDiagramLink(top[0], loopEndNode);

				// Replace the choice start node with the choice end node
				// in the current sequence
				if (sequences.Count == 0)
					throw new InvalidOperationException();

				top = sequences.Peek();
				if (top.Count == 0)
					throw new InvalidOperationException();

				diagram.Factory.CreateDiagramLink(loopEndNode, top[0]);

				top[0] = loopEndNode;
			}


			private Diagram diagram;
			private Stack<List<ShapeNode>> sequences;
		}

		public FlowchartBuilder(JavaScriptParser parser, Diagram diagram)
		{
			parser.EnterFunctionDeclaration += new ParserEventHandler(OnEnterFunctionDeclaration);
			parser.LeaveFunctionDeclaration += new ParserEventHandler(OnLeaveFunctionDeclaration);
			parser.LeaveExpressionStatement += new ParserEventHandler(OnLeaveExpressionStatement);
			parser.LeaveReturnStatement += new ParserEventHandler(OnLeaveReturnStatement);
			parser.EnterIfStatement += new ParserEventHandler(OnEnterIfStatement);
			parser.LeaveIfStatement += new ParserEventHandler(OnLeaveIfStatement);
			parser.EnterIterationStatement += new ParserEventHandler(OnEnterIterationStatement);
			parser.LeaveIterationStatement += new ParserEventHandler(OnLeaveIterationStatement);
			parser.EnterSwitchStatement += new ParserEventHandler(OnEnterSwitchStatement);
			parser.LeaveSwitchStatement += new ParserEventHandler(OnLeaveSwitchStatement);
			parser.EnterBranch += new ParserEventHandler(OnEnterBranch);
			parser.LeaveBranch += new ParserEventHandler(OnLeaveBranch);

			diagram.ClearAll();
			this.diagram = diagram;

			current = new Flowchart(diagram);
		}

		void OnEnterFunctionDeclaration(object sender, ParserEventArgs args)
		{
			current.EnterFunction("function " + args.Text);
		}

		void OnLeaveFunctionDeclaration(object sender, ParserEventArgs args)
		{
			if (current.LeaveFunction("endfunction " + args.Text))
				current = new Flowchart(diagram);
		}

		void OnLeaveExpressionStatement(object sender, ParserEventArgs args)
		{
			current.AddExpression(args.Text);
		}

		void OnLeaveReturnStatement(object sender, ParserEventArgs args)
		{
			current.AddReturnStatement(args.Text);
		}

		void OnEnterIfStatement(object sender, ParserEventArgs args)
		{
			current.EnterChoice("if");
		}

		void OnLeaveIfStatement(object sender, ParserEventArgs args)
		{
			current.LeaveChoice("endif");
		}

		void OnEnterIterationStatement(object sender, ParserEventArgs args)
		{
			current.EnterLoop("iteration");
		}

		void OnLeaveIterationStatement(object sender, ParserEventArgs args)
		{
			current.LeaveLoop("enditeration");
		}

		void OnEnterSwitchStatement(object sender, ParserEventArgs args)
		{
			current.EnterChoice("switch");
		}

		void OnLeaveSwitchStatement(object sender, ParserEventArgs args)
		{
			current.LeaveChoice("endswitch");
		}

		void OnEnterBranch(object sender, ParserEventArgs args)
		{
			current.EnterBranch();
		}

		void OnLeaveBranch(object sender, ParserEventArgs args)
		{
			current.LeaveBranch();
		}


		private Diagram diagram;
		private Flowchart current;
	}
}