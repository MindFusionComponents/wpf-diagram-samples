//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//

using System.Diagnostics;


namespace MindFusion.Diagramming.Wpf.Samples.CS.JavaScript
{
	public class Logger
	{
		public Logger(JavaScriptParser parser)
		{
			parser.EnterFunctionDeclaration += new ParserEventHandler(OnEnterFunctionDeclaration);
			parser.LeaveFunctionDeclaration += new ParserEventHandler(OnLeaveFunctionDeclaration);
			parser.EnterFunctionBody += new ParserEventHandler(OnEnterFunctionBody);
			parser.LeaveFunctionBody += new ParserEventHandler(OnLeaveFunctionBody);
			parser.EnterExpressionStatement += new ParserEventHandler(OnEnterExpressionStatement);
			parser.LeaveExpressionStatement += new ParserEventHandler(OnLeaveExpressionStatement);
			parser.EnterIfStatement += new ParserEventHandler(OnEnterIfStatement);
			parser.LeaveIfStatement += new ParserEventHandler(OnLeaveIfStatement);
			parser.EnterIterationStatement += new ParserEventHandler(OnEnterIterationStatement);
			parser.LeaveIterationStatement += new ParserEventHandler(OnLeaveIterationStatement);
			parser.EnterSwitchStatement += new ParserEventHandler(OnEnterSwitchStatement);
			parser.LeaveSwitchStatement += new ParserEventHandler(OnLeaveSwitchStatement);
			parser.EnterBranch += new ParserEventHandler(OnEnterBranch);
			parser.LeaveBranch += new ParserEventHandler(OnLeaveBranch);
		}

		void OnEnterFunctionDeclaration(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterFunctionDeclaration");
		}
		void OnLeaveFunctionDeclaration(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveFunctionDeclaration");
		}
		void OnEnterFunctionBody(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterFunctionBody");
		}
		void OnLeaveFunctionBody(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveFunctionBody");
		}
		void OnEnterExpressionStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterExpressionStatement");
		}
		void OnLeaveExpressionStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveExpressionStatement");
		}
		void OnEnterIfStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterIfStatement");
		}
		void OnLeaveIfStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveIfStatement");
		}
		void OnEnterIterationStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterIterationStatement");
		}
		void OnLeaveIterationStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveIterationStatement");
		}
		void OnEnterSwitchStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterSwitchStatement");
		}
		void OnLeaveSwitchStatement(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveSwitchStatement");
		}
		void OnEnterBranch(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("EnterBranch");
		}
		void OnLeaveBranch(object sender, ParserEventArgs args)
		{
			Debug.WriteLine("LeaveBranch");
		}
	}
}
