//
// Copyright (c) 2022, MindFusion LLC - Bulgaria.
//


public class ParserEventArgs
{
	public ParserEventArgs(string text)
	{
		this.text = text;
	}

	public string Text
	{
		get { return text; }
	}

	string text;
}

public delegate void ParserEventHandler(object sender, ParserEventArgs args);
