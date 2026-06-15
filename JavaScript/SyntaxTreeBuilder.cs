//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Collections.Generic;
using System.Diagnostics;


namespace MindFusion.Diagramming.Wpf.Samples.CS.JavaScript
{
	public class SyntaxTreeBuilder
	{
		public SyntaxTreeBuilder(JavaScriptParser parser, Diagram diagram)
		{
			parser.EnterFunctionDeclaration += new ParserEventHandler(OnEnterFunctionDeclaration);
			parser.LeaveFunctionDeclaration += new ParserEventHandler(OnLeaveFunctionDeclaration);
			parser.LeaveExpressionStatement += new ParserEventHandler(OnLeaveExpressionStatement);
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
			parentNodes = new Stack<DiagramNode>();
		}

		void OnEnterFunctionDeclaration(object sender, ParserEventArgs args)
		{
			ShapeNode functionNode = diagram.CreateStartTerminatorNode("function " + args.Text);

			if (parentNodes.Count > 0)
				diagram.Factory.CreateDiagramLink(parentNodes.Peek(), functionNode);

			parentNodes.Push(functionNode);
		}

		void OnLeaveFunctionDeclaration(object sender, ParserEventArgs args)
		{
			parentNodes.Pop();
		}

		void OnLeaveExpressionStatement(object sender, ParserEventArgs args)
		{
			ShapeNode functionNode = diagram.CreateProcessNode(args.Text);

			if (parentNodes.Count > 0)
				diagram.Factory.CreateDiagramLink(parentNodes.Peek(), functionNode);
		}

		void OnEnterIfStatement(object sender, ParserEventArgs args)
		{
			ShapeNode ifNode = diagram.CreateDecisionNode("if / else");

			if (parentNodes.Count > 0)
				diagram.Factory.CreateDiagramLink(parentNodes.Peek(), ifNode);

			parentNodes.Push(ifNode);
		}

		void OnLeaveIfStatement(object sender, ParserEventArgs args)
		{
			parentNodes.Pop();
		}

		void OnEnterIterationStatement(object sender, ParserEventArgs args)
		{
			ShapeNode iterationNode = diagram.CreateLoopNode("iteration");

			if (parentNodes.Count > 0)
				diagram.Factory.CreateDiagramLink(parentNodes.Peek(), iterationNode);

			parentNodes.Push(iterationNode);
		}

		void OnLeaveIterationStatement(object sender, ParserEventArgs args)
		{
			parentNodes.Pop();
		}

		void OnEnterSwitchStatement(object sender, ParserEventArgs args)
		{
			ShapeNode switchNode = diagram.CreateDecisionNode("switch");

			if (parentNodes.Count > 0)
				diagram.Factory.CreateDiagramLink(parentNodes.Peek(), switchNode);

			parentNodes.Push(switchNode);
		}

		void OnLeaveSwitchStatement(object sender, ParserEventArgs args)
		{
			parentNodes.Pop();
		}

		void OnEnterBranch(object sender, ParserEventArgs args)
		{
			ShapeNode branchNode = diagram.CreateDecisionNode("branch");

			if (parentNodes.Count > 0)
				diagram.Factory.CreateDiagramLink(parentNodes.Peek(), branchNode);

			parentNodes.Push(branchNode);
		}

		void OnLeaveBranch(object sender, ParserEventArgs args)
		{
			parentNodes.Pop();
		}

		private Diagram diagram;
		private Stack<DiagramNode> parentNodes;
	}
}