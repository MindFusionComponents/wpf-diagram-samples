// $ANTLR 3.1.2 JavaScript.g 2009-06-19 16:33:36

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System.Diagnostics;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

public partial class JavaScriptParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"LT", 
		"Identifier", 
		"StringLiteral", 
		"NumericLiteral", 
		"DoubleStringCharacter", 
		"SingleStringCharacter", 
		"EscapeSequence", 
		"CharacterEscapeSequence", 
		"HexEscapeSequence", 
		"UnicodeEscapeSequence", 
		"SingleEscapeCharacter", 
		"NonEscapeCharacter", 
		"EscapeCharacter", 
		"DecimalDigit", 
		"HexDigit", 
		"DecimalLiteral", 
		"HexIntegerLiteral", 
		"ExponentPart", 
		"IdentifierStart", 
		"IdentifierPart", 
		"UnicodeLetter", 
		"UnicodeDigit", 
		"Comment", 
		"LineComment", 
		"WhiteSpace", 
		"'function'", 
		"'('", 
		"','", 
		"')'", 
		"'{'", 
		"'}'", 
		"'var'", 
		"';'", 
		"'='", 
		"'if'", 
		"'else'", 
		"'do'", 
		"'while'", 
		"'for'", 
		"'in'", 
		"'continue'", 
		"'break'", 
		"'return'", 
		"'with'", 
		"':'", 
		"'switch'", 
		"'case'", 
		"'default'", 
		"'throw'", 
		"'try'", 
		"'catch'", 
		"'finally'", 
		"'new'", 
		"'['", 
		"']'", 
		"'.'", 
		"'*='", 
		"'/='", 
		"'%='", 
		"'+='", 
		"'-='", 
		"'<<='", 
		"'>>='", 
		"'>>>='", 
		"'&='", 
		"'^='", 
		"'|='", 
		"'?'", 
		"'||'", 
		"'&&'", 
		"'|'", 
		"'^'", 
		"'&'", 
		"'=='", 
		"'!='", 
		"'==='", 
		"'!=='", 
		"'<'", 
		"'>'", 
		"'<='", 
		"'>='", 
		"'instanceof'", 
		"'<<'", 
		"'>>'", 
		"'>>>'", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'delete'", 
		"'void'", 
		"'typeof'", 
		"'++'", 
		"'--'", 
		"'~'", 
		"'!'", 
		"'this'", 
		"'null'", 
		"'true'", 
		"'false'"
    };

    public const int LT = 4;
    public const int T__29 = 29;
    public const int DecimalDigit = 17;
    public const int EOF = -1;
    public const int Identifier = 5;
    public const int SingleStringCharacter = 9;
    public const int T__93 = 93;
    public const int T__94 = 94;
    public const int T__91 = 91;
    public const int T__92 = 92;
    public const int T__90 = 90;
    public const int Comment = 26;
    public const int SingleEscapeCharacter = 14;
    public const int UnicodeLetter = 24;
    public const int ExponentPart = 21;
    public const int WhiteSpace = 28;
    public const int T__99 = 99;
    public const int T__98 = 98;
    public const int T__97 = 97;
    public const int T__96 = 96;
    public const int T__95 = 95;
    public const int UnicodeDigit = 25;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int NumericLiteral = 7;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int IdentifierStart = 22;
    public const int DoubleStringCharacter = 8;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int T__88 = 88;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int CharacterEscapeSequence = 11;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int EscapeSequence = 10;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int T__77 = 77;
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int HexEscapeSequence = 12;
    public const int LineComment = 27;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int HexDigit = 18;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int T__103 = 103;
    public const int T__104 = 104;
    public const int EscapeCharacter = 16;
    public const int T__50 = 50;
    public const int IdentifierPart = 23;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int UnicodeEscapeSequence = 13;
    public const int T__102 = 102;
    public const int T__101 = 101;
    public const int T__100 = 100;
    public const int DecimalLiteral = 19;
    public const int StringLiteral = 6;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int HexIntegerLiteral = 20;
    public const int NonEscapeCharacter = 15;

    // delegates
    // delegators



        public JavaScriptParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public JavaScriptParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[380+1];
             
             
        }
        

    override public string[] TokenNames {
		get { return JavaScriptParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "JavaScript.g"; }
    }


    public ParserEventHandler EnterFunctionDeclaration;
    public ParserEventHandler LeaveFunctionDeclaration;
    public ParserEventHandler EnterFunctionBody;
    public ParserEventHandler LeaveFunctionBody;
    public ParserEventHandler EnterExpressionStatement;
    public ParserEventHandler LeaveExpressionStatement;
    public ParserEventHandler EnterReturnStatement;
    public ParserEventHandler LeaveReturnStatement;
    public ParserEventHandler EnterIfStatement;
    public ParserEventHandler LeaveIfStatement;
    public ParserEventHandler EnterIterationStatement;
    public ParserEventHandler LeaveIterationStatement;
    public ParserEventHandler EnterSwitchStatement;
    public ParserEventHandler LeaveSwitchStatement;
    public ParserEventHandler EnterBranch;
    public ParserEventHandler LeaveBranch;

    void RaiseEnterFunctionDeclaration(string id)
    {
    	if (EnterFunctionDeclaration != null)
    		EnterFunctionDeclaration(this, new ParserEventArgs(id));
    }
    void RaiseLeaveFunctionDeclaration()
    {
    	if (LeaveFunctionDeclaration != null)
    		LeaveFunctionDeclaration(this, new ParserEventArgs(""));
    }
    void RaiseEnterFunctionBody()
    {
    	if (EnterFunctionBody != null)
    		EnterFunctionBody(this, new ParserEventArgs(""));
    }
    void RaiseLeaveFunctionBody()
    {
    	if (LeaveFunctionBody != null)
    		LeaveFunctionBody(this, new ParserEventArgs(""));
    }
    void RaiseEnterExpressionStatement()
    {
    	if (EnterExpressionStatement != null)
    		EnterExpressionStatement(this, new ParserEventArgs(""));
    }
    void RaiseLeaveExpressionStatement(string text)
    {
    	if (LeaveExpressionStatement != null)
    		LeaveExpressionStatement(this, new ParserEventArgs(text));
    }
    void RaiseEnterReturnStatement()
    {
    	if (EnterReturnStatement != null)
    		EnterReturnStatement(this, new ParserEventArgs(""));
    }
    void RaiseLeaveReturnStatement(string text)
    {
    	if (LeaveReturnStatement != null)
    		LeaveReturnStatement(this, new ParserEventArgs(text));
    }
    void RaiseEnterIfStatement()
    {
    	if (EnterIfStatement != null)
    		EnterIfStatement(this, new ParserEventArgs(""));
    }
    void RaiseLeaveIfStatement()
    {
    	if (LeaveIfStatement != null)
    		LeaveIfStatement(this, new ParserEventArgs(""));
    }
    void RaiseEnterIterationStatement()
    {
    	if (EnterIterationStatement != null)
    		EnterIterationStatement(this, new ParserEventArgs(""));
    }
    void RaiseLeaveIterationStatement()
    {
    	if (LeaveIterationStatement != null)
    		LeaveIterationStatement(this, new ParserEventArgs(""));
    }
    void RaiseEnterSwitchStatement()
    {
    	if (EnterSwitchStatement != null)
    		EnterSwitchStatement(this, new ParserEventArgs(""));
    }
    void RaiseLeaveSwitchStatement()
    {
    	if (LeaveSwitchStatement != null)
    		LeaveSwitchStatement(this, new ParserEventArgs(""));
    }
    void RaiseEnterBranch()
    {
    	if (EnterBranch != null)
    		EnterBranch(this, new ParserEventArgs(""));
    }
    void RaiseLeaveBranch()
    {
    	if (LeaveBranch != null)
    		LeaveBranch(this, new ParserEventArgs(""));
    }



    // $ANTLR start "program"
    // JavaScript.g:119:1: program : ( LT )* sourceElements ( LT )* EOF ;
    public void program() // throws RecognitionException [1]
    {   
        int program_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:120:2: ( ( LT )* sourceElements ( LT )* EOF )
            // JavaScript.g:120:4: ( LT )* sourceElements ( LT )* EOF
            {
            	// JavaScript.g:120:4: ( LT )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == LT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_program49); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_sourceElements_in_program52);
            	sourceElements();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:120:23: ( LT )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == LT) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_program54); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	Match(input,EOF,FOLLOW_EOF_in_program57); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, program_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "program"


    // $ANTLR start "sourceElements"
    // JavaScript.g:123:1: sourceElements : sourceElement ( ( LT )* sourceElement )* ;
    public void sourceElements() // throws RecognitionException [1]
    {   
        int sourceElements_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:124:2: ( sourceElement ( ( LT )* sourceElement )* )
            // JavaScript.g:124:4: sourceElement ( ( LT )* sourceElement )*
            {
            	PushFollow(FOLLOW_sourceElement_in_sourceElements69);
            	sourceElement();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:124:18: ( ( LT )* sourceElement )*
            	do 
            	{
            	    int alt4 = 2;
            	    alt4 = dfa4.Predict(input);
            	    switch (alt4) 
            		{
            			case 1 :
            			    // JavaScript.g:124:19: ( LT )* sourceElement
            			    {
            			    	// JavaScript.g:124:19: ( LT )*
            			    	do 
            			    	{
            			    	    int alt3 = 2;
            			    	    int LA3_0 = input.LA(1);

            			    	    if ( (LA3_0 == LT) )
            			    	    {
            			    	        alt3 = 1;
            			    	    }


            			    	    switch (alt3) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_sourceElements72); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop3;
            			    	    }
            			    	} while (true);

            			    	loop3:
            			    		;	// Stops C# compiler whining that label 'loop3' has no statements

            			    	PushFollow(FOLLOW_sourceElement_in_sourceElements75);
            			    	sourceElement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, sourceElements_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "sourceElements"


    // $ANTLR start "sourceElement"
    // JavaScript.g:127:1: sourceElement : ( functionDeclaration | statement );
    public void sourceElement() // throws RecognitionException [1]
    {   
        int sourceElement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:128:2: ( functionDeclaration | statement )
            int alt5 = 2;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // JavaScript.g:128:4: functionDeclaration
                    {
                    	PushFollow(FOLLOW_functionDeclaration_in_sourceElement89);
                    	functionDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:129:4: statement
                    {
                    	PushFollow(FOLLOW_statement_in_sourceElement94);
                    	statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, sourceElement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "sourceElement"


    // $ANTLR start "functionDeclaration"
    // JavaScript.g:133:1: functionDeclaration : 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* functionBody ;
    public void functionDeclaration() // throws RecognitionException [1]
    {   
        int functionDeclaration_StartIndex = input.Index();
        IToken Identifier1 = null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:134:2: ( 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* functionBody )
            // JavaScript.g:134:4: 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* functionBody
            {
            	Match(input,29,FOLLOW_29_in_functionDeclaration107); if (state.failed) return ;
            	// JavaScript.g:134:15: ( LT )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == LT) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionDeclaration109); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	Identifier1=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration112); if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   RaiseEnterFunctionDeclaration(Identifier1.Text); 
            	}
            	// JavaScript.g:134:83: ( LT )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == LT) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionDeclaration116); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration119);
            	formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:134:107: ( LT )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == LT) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionDeclaration121); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	PushFollow(FOLLOW_functionBody_in_functionDeclaration124);
            	functionBody();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   RaiseLeaveFunctionDeclaration(); 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, functionDeclaration_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "functionDeclaration"


    // $ANTLR start "functionExpression"
    // JavaScript.g:137:1: functionExpression : 'function' ( LT )* ( Identifier )? ( LT )* formalParameterList ( LT )* functionBody ;
    public void functionExpression() // throws RecognitionException [1]
    {   
        int functionExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:138:2: ( 'function' ( LT )* ( Identifier )? ( LT )* formalParameterList ( LT )* functionBody )
            // JavaScript.g:138:4: 'function' ( LT )* ( Identifier )? ( LT )* formalParameterList ( LT )* functionBody
            {
            	Match(input,29,FOLLOW_29_in_functionExpression138); if (state.failed) return ;
            	// JavaScript.g:138:15: ( LT )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == LT) )
            	    {
            	        int LA9_2 = input.LA(2);

            	        if ( (synpred9_JavaScript()) )
            	        {
            	            alt9 = 1;
            	        }


            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionExpression140); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	// JavaScript.g:138:19: ( Identifier )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == Identifier) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: Identifier
            	        {
            	        	Match(input,Identifier,FOLLOW_Identifier_in_functionExpression143); if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:138:31: ( LT )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == LT) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionExpression146); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	PushFollow(FOLLOW_formalParameterList_in_functionExpression149);
            	formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:138:55: ( LT )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == LT) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionExpression151); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	PushFollow(FOLLOW_functionBody_in_functionExpression154);
            	functionBody();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, functionExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "functionExpression"


    // $ANTLR start "formalParameterList"
    // JavaScript.g:141:1: formalParameterList : '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')' ;
    public void formalParameterList() // throws RecognitionException [1]
    {   
        int formalParameterList_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:142:2: ( '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')' )
            // JavaScript.g:142:4: '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')'
            {
            	Match(input,30,FOLLOW_30_in_formalParameterList166); if (state.failed) return ;
            	// JavaScript.g:142:8: ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )?
            	int alt17 = 2;
            	alt17 = dfa17.Predict(input);
            	switch (alt17) 
            	{
            	    case 1 :
            	        // JavaScript.g:142:9: ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )*
            	        {
            	        	// JavaScript.g:142:9: ( LT )*
            	        	do 
            	        	{
            	        	    int alt13 = 2;
            	        	    int LA13_0 = input.LA(1);

            	        	    if ( (LA13_0 == LT) )
            	        	    {
            	        	        alt13 = 1;
            	        	    }


            	        	    switch (alt13) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_formalParameterList169); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop13;
            	        	    }
            	        	} while (true);

            	        	loop13:
            	        		;	// Stops C# compiler whining that label 'loop13' has no statements

            	        	Match(input,Identifier,FOLLOW_Identifier_in_formalParameterList172); if (state.failed) return ;
            	        	// JavaScript.g:142:24: ( ( LT )* ',' ( LT )* Identifier )*
            	        	do 
            	        	{
            	        	    int alt16 = 2;
            	        	    alt16 = dfa16.Predict(input);
            	        	    switch (alt16) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:142:25: ( LT )* ',' ( LT )* Identifier
            	        			    {
            	        			    	// JavaScript.g:142:25: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt14 = 2;
            	        			    	    int LA14_0 = input.LA(1);

            	        			    	    if ( (LA14_0 == LT) )
            	        			    	    {
            	        			    	        alt14 = 1;
            	        			    	    }


            	        			    	    switch (alt14) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:0:0: LT
            	        			    			    {
            	        			    			    	Match(input,LT,FOLLOW_LT_in_formalParameterList175); if (state.failed) return ;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop14;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop14:
            	        			    		;	// Stops C# compiler whining that label 'loop14' has no statements

            	        			    	Match(input,31,FOLLOW_31_in_formalParameterList178); if (state.failed) return ;
            	        			    	// JavaScript.g:142:33: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt15 = 2;
            	        			    	    int LA15_0 = input.LA(1);

            	        			    	    if ( (LA15_0 == LT) )
            	        			    	    {
            	        			    	        alt15 = 1;
            	        			    	    }


            	        			    	    switch (alt15) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:0:0: LT
            	        			    			    {
            	        			    			    	Match(input,LT,FOLLOW_LT_in_formalParameterList180); if (state.failed) return ;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop15;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop15:
            	        			    		;	// Stops C# compiler whining that label 'loop15' has no statements

            	        			    	Match(input,Identifier,FOLLOW_Identifier_in_formalParameterList183); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop16;
            	        	    }
            	        	} while (true);

            	        	loop16:
            	        		;	// Stops C# compiler whining that label 'loop16' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:142:52: ( LT )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == LT) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_formalParameterList189); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements

            	Match(input,32,FOLLOW_32_in_formalParameterList192); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, formalParameterList_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "formalParameterList"


    // $ANTLR start "functionBody"
    // JavaScript.g:145:1: functionBody : '{' ( LT )* sourceElements ( LT )* '}' ;
    public void functionBody() // throws RecognitionException [1]
    {   
        int functionBody_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:146:2: ( '{' ( LT )* sourceElements ( LT )* '}' )
            // JavaScript.g:146:4: '{' ( LT )* sourceElements ( LT )* '}'
            {
            	Match(input,33,FOLLOW_33_in_functionBody203); if (state.failed) return ;
            	// JavaScript.g:146:8: ( LT )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == LT) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionBody205); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   RaiseEnterFunctionBody(); 
            	}
            	PushFollow(FOLLOW_sourceElements_in_functionBody210);
            	sourceElements();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   RaiseLeaveFunctionBody(); 
            	}
            	// JavaScript.g:146:87: ( LT )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == LT) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_functionBody214); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements

            	Match(input,34,FOLLOW_34_in_functionBody217); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, functionBody_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "functionBody"


    // $ANTLR start "statement"
    // JavaScript.g:150:1: statement : ( statementBlock | variableStatement | emptyStatement | s= expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | w= returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement );
    public void statement() // throws RecognitionException [1]
    {   
        int statement_StartIndex = input.Index();
        JavaScriptParser.expressionStatement_return s = default(JavaScriptParser.expressionStatement_return);

        JavaScriptParser.returnStatement_return w = default(JavaScriptParser.returnStatement_return);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:151:2: ( statementBlock | variableStatement | emptyStatement | s= expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | w= returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement )
            int alt21 = 14;
            alt21 = dfa21.Predict(input);
            switch (alt21) 
            {
                case 1 :
                    // JavaScript.g:151:4: statementBlock
                    {
                    	PushFollow(FOLLOW_statementBlock_in_statement229);
                    	statementBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:152:4: variableStatement
                    {
                    	PushFollow(FOLLOW_variableStatement_in_statement234);
                    	variableStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // JavaScript.g:153:4: emptyStatement
                    {
                    	PushFollow(FOLLOW_emptyStatement_in_statement239);
                    	emptyStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 4 :
                    // JavaScript.g:154:4: s= expressionStatement
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseEnterExpressionStatement(); 
                    	}
                    	PushFollow(FOLLOW_expressionStatement_in_statement248);
                    	s = expressionStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseLeaveExpressionStatement(((s != null) ? input.ToString((IToken)(s.Start),(IToken)(s.Stop)) : null)); 
                    	}

                    }
                    break;
                case 5 :
                    // JavaScript.g:155:4: ifStatement
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseEnterIfStatement(); 
                    	}
                    	PushFollow(FOLLOW_ifStatement_in_statement257);
                    	ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseLeaveIfStatement(); 
                    	}

                    }
                    break;
                case 6 :
                    // JavaScript.g:156:4: iterationStatement
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseEnterIterationStatement(); 
                    	}
                    	PushFollow(FOLLOW_iterationStatement_in_statement266);
                    	iterationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseLeaveIterationStatement(); 
                    	}

                    }
                    break;
                case 7 :
                    // JavaScript.g:157:4: continueStatement
                    {
                    	PushFollow(FOLLOW_continueStatement_in_statement273);
                    	continueStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 8 :
                    // JavaScript.g:158:4: breakStatement
                    {
                    	PushFollow(FOLLOW_breakStatement_in_statement278);
                    	breakStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 9 :
                    // JavaScript.g:159:4: w= returnStatement
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseEnterReturnStatement(); 
                    	}
                    	PushFollow(FOLLOW_returnStatement_in_statement287);
                    	w = returnStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseLeaveReturnStatement(((w != null) ? input.ToString((IToken)(w.Start),(IToken)(w.Stop)) : null)); 
                    	}

                    }
                    break;
                case 10 :
                    // JavaScript.g:160:4: withStatement
                    {
                    	PushFollow(FOLLOW_withStatement_in_statement294);
                    	withStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 11 :
                    // JavaScript.g:161:4: labelledStatement
                    {
                    	PushFollow(FOLLOW_labelledStatement_in_statement299);
                    	labelledStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 12 :
                    // JavaScript.g:162:4: switchStatement
                    {
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseEnterSwitchStatement(); 
                    	}
                    	PushFollow(FOLLOW_switchStatement_in_statement306);
                    	switchStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	   RaiseLeaveSwitchStatement(); 
                    	}

                    }
                    break;
                case 13 :
                    // JavaScript.g:163:4: throwStatement
                    {
                    	PushFollow(FOLLOW_throwStatement_in_statement313);
                    	throwStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 14 :
                    // JavaScript.g:164:4: tryStatement
                    {
                    	PushFollow(FOLLOW_tryStatement_in_statement318);
                    	tryStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, statement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "statement"


    // $ANTLR start "statementBlock"
    // JavaScript.g:167:1: statementBlock : '{' ( LT )* ( statementList )? ( LT )* '}' ;
    public void statementBlock() // throws RecognitionException [1]
    {   
        int statementBlock_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:168:2: ( '{' ( LT )* ( statementList )? ( LT )* '}' )
            // JavaScript.g:168:4: '{' ( LT )* ( statementList )? ( LT )* '}'
            {
            	Match(input,33,FOLLOW_33_in_statementBlock330); if (state.failed) return ;
            	// JavaScript.g:168:8: ( LT )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == LT) )
            	    {
            	        int LA22_2 = input.LA(2);

            	        if ( (synpred34_JavaScript()) )
            	        {
            	            alt22 = 1;
            	        }


            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_statementBlock332); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements

            	// JavaScript.g:168:12: ( statementList )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( ((LA23_0 >= Identifier && LA23_0 <= NumericLiteral) || (LA23_0 >= 29 && LA23_0 <= 30) || LA23_0 == 33 || (LA23_0 >= 35 && LA23_0 <= 36) || LA23_0 == 38 || (LA23_0 >= 40 && LA23_0 <= 42) || (LA23_0 >= 44 && LA23_0 <= 47) || LA23_0 == 49 || (LA23_0 >= 52 && LA23_0 <= 53) || (LA23_0 >= 56 && LA23_0 <= 57) || (LA23_0 >= 89 && LA23_0 <= 90) || (LA23_0 >= 94 && LA23_0 <= 104)) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: statementList
            	        {
            	        	PushFollow(FOLLOW_statementList_in_statementBlock335);
            	        	statementList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:168:27: ( LT )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == LT) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_statementBlock338); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements

            	Match(input,34,FOLLOW_34_in_statementBlock341); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, statementBlock_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "statementBlock"


    // $ANTLR start "statementList"
    // JavaScript.g:171:1: statementList : statement ( ( LT )* statement )* ;
    public void statementList() // throws RecognitionException [1]
    {   
        int statementList_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:172:2: ( statement ( ( LT )* statement )* )
            // JavaScript.g:172:4: statement ( ( LT )* statement )*
            {
            	PushFollow(FOLLOW_statement_in_statementList353);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:172:14: ( ( LT )* statement )*
            	do 
            	{
            	    int alt26 = 2;
            	    alt26 = dfa26.Predict(input);
            	    switch (alt26) 
            		{
            			case 1 :
            			    // JavaScript.g:172:15: ( LT )* statement
            			    {
            			    	// JavaScript.g:172:15: ( LT )*
            			    	do 
            			    	{
            			    	    int alt25 = 2;
            			    	    int LA25_0 = input.LA(1);

            			    	    if ( (LA25_0 == LT) )
            			    	    {
            			    	        alt25 = 1;
            			    	    }


            			    	    switch (alt25) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_statementList356); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop25;
            			    	    }
            			    	} while (true);

            			    	loop25:
            			    		;	// Stops C# compiler whining that label 'loop25' has no statements

            			    	PushFollow(FOLLOW_statement_in_statementList359);
            			    	statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, statementList_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "statementList"


    // $ANTLR start "variableStatement"
    // JavaScript.g:175:1: variableStatement : 'var' ( LT )* variableDeclarationList ( LT | ';' ) ;
    public void variableStatement() // throws RecognitionException [1]
    {   
        int variableStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:176:2: ( 'var' ( LT )* variableDeclarationList ( LT | ';' ) )
            // JavaScript.g:176:4: 'var' ( LT )* variableDeclarationList ( LT | ';' )
            {
            	Match(input,35,FOLLOW_35_in_variableStatement373); if (state.failed) return ;
            	// JavaScript.g:176:10: ( LT )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == LT) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_variableStatement375); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	PushFollow(FOLLOW_variableDeclarationList_in_variableStatement378);
            	variableDeclarationList();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, variableStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableStatement"


    // $ANTLR start "variableDeclarationList"
    // JavaScript.g:179:1: variableDeclarationList : variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )* ;
    public void variableDeclarationList() // throws RecognitionException [1]
    {   
        int variableDeclarationList_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:180:2: ( variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )* )
            // JavaScript.g:180:4: variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )*
            {
            	PushFollow(FOLLOW_variableDeclaration_in_variableDeclarationList398);
            	variableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:180:24: ( ( LT )* ',' ( LT )* variableDeclaration )*
            	do 
            	{
            	    int alt30 = 2;
            	    alt30 = dfa30.Predict(input);
            	    switch (alt30) 
            		{
            			case 1 :
            			    // JavaScript.g:180:25: ( LT )* ',' ( LT )* variableDeclaration
            			    {
            			    	// JavaScript.g:180:25: ( LT )*
            			    	do 
            			    	{
            			    	    int alt28 = 2;
            			    	    int LA28_0 = input.LA(1);

            			    	    if ( (LA28_0 == LT) )
            			    	    {
            			    	        alt28 = 1;
            			    	    }


            			    	    switch (alt28) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_variableDeclarationList401); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop28;
            			    	    }
            			    	} while (true);

            			    	loop28:
            			    		;	// Stops C# compiler whining that label 'loop28' has no statements

            			    	Match(input,31,FOLLOW_31_in_variableDeclarationList404); if (state.failed) return ;
            			    	// JavaScript.g:180:33: ( LT )*
            			    	do 
            			    	{
            			    	    int alt29 = 2;
            			    	    int LA29_0 = input.LA(1);

            			    	    if ( (LA29_0 == LT) )
            			    	    {
            			    	        alt29 = 1;
            			    	    }


            			    	    switch (alt29) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_variableDeclarationList406); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop29;
            			    	    }
            			    	} while (true);

            			    	loop29:
            			    		;	// Stops C# compiler whining that label 'loop29' has no statements

            			    	PushFollow(FOLLOW_variableDeclaration_in_variableDeclarationList409);
            			    	variableDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, variableDeclarationList_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableDeclarationList"


    // $ANTLR start "variableDeclarationListNoIn"
    // JavaScript.g:183:1: variableDeclarationListNoIn : variableDeclarationNoIn ( ( LT )* ',' ( LT )* variableDeclarationNoIn )* ;
    public void variableDeclarationListNoIn() // throws RecognitionException [1]
    {   
        int variableDeclarationListNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:184:2: ( variableDeclarationNoIn ( ( LT )* ',' ( LT )* variableDeclarationNoIn )* )
            // JavaScript.g:184:4: variableDeclarationNoIn ( ( LT )* ',' ( LT )* variableDeclarationNoIn )*
            {
            	PushFollow(FOLLOW_variableDeclarationNoIn_in_variableDeclarationListNoIn423);
            	variableDeclarationNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:184:28: ( ( LT )* ',' ( LT )* variableDeclarationNoIn )*
            	do 
            	{
            	    int alt33 = 2;
            	    alt33 = dfa33.Predict(input);
            	    switch (alt33) 
            		{
            			case 1 :
            			    // JavaScript.g:184:29: ( LT )* ',' ( LT )* variableDeclarationNoIn
            			    {
            			    	// JavaScript.g:184:29: ( LT )*
            			    	do 
            			    	{
            			    	    int alt31 = 2;
            			    	    int LA31_0 = input.LA(1);

            			    	    if ( (LA31_0 == LT) )
            			    	    {
            			    	        alt31 = 1;
            			    	    }


            			    	    switch (alt31) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_variableDeclarationListNoIn426); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop31;
            			    	    }
            			    	} while (true);

            			    	loop31:
            			    		;	// Stops C# compiler whining that label 'loop31' has no statements

            			    	Match(input,31,FOLLOW_31_in_variableDeclarationListNoIn429); if (state.failed) return ;
            			    	// JavaScript.g:184:37: ( LT )*
            			    	do 
            			    	{
            			    	    int alt32 = 2;
            			    	    int LA32_0 = input.LA(1);

            			    	    if ( (LA32_0 == LT) )
            			    	    {
            			    	        alt32 = 1;
            			    	    }


            			    	    switch (alt32) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_variableDeclarationListNoIn431); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop32;
            			    	    }
            			    	} while (true);

            			    	loop32:
            			    		;	// Stops C# compiler whining that label 'loop32' has no statements

            			    	PushFollow(FOLLOW_variableDeclarationNoIn_in_variableDeclarationListNoIn434);
            			    	variableDeclarationNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop33;
            	    }
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, variableDeclarationListNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableDeclarationListNoIn"


    // $ANTLR start "variableDeclaration"
    // JavaScript.g:187:1: variableDeclaration : Identifier ( LT )* ( initialiser )? ;
    public void variableDeclaration() // throws RecognitionException [1]
    {   
        int variableDeclaration_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:188:2: ( Identifier ( LT )* ( initialiser )? )
            // JavaScript.g:188:4: Identifier ( LT )* ( initialiser )?
            {
            	Match(input,Identifier,FOLLOW_Identifier_in_variableDeclaration448); if (state.failed) return ;
            	// JavaScript.g:188:15: ( LT )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == LT) )
            	    {
            	        int LA34_2 = input.LA(2);

            	        if ( (synpred47_JavaScript()) )
            	        {
            	            alt34 = 1;
            	        }


            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_variableDeclaration450); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements

            	// JavaScript.g:188:19: ( initialiser )?
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == 37) )
            	{
            	    alt35 = 1;
            	}
            	switch (alt35) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: initialiser
            	        {
            	        	PushFollow(FOLLOW_initialiser_in_variableDeclaration453);
            	        	initialiser();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, variableDeclaration_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableDeclaration"


    // $ANTLR start "variableDeclarationNoIn"
    // JavaScript.g:191:1: variableDeclarationNoIn : Identifier ( LT )* ( initialiserNoIn )? ;
    public void variableDeclarationNoIn() // throws RecognitionException [1]
    {   
        int variableDeclarationNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:192:2: ( Identifier ( LT )* ( initialiserNoIn )? )
            // JavaScript.g:192:4: Identifier ( LT )* ( initialiserNoIn )?
            {
            	Match(input,Identifier,FOLLOW_Identifier_in_variableDeclarationNoIn466); if (state.failed) return ;
            	// JavaScript.g:192:15: ( LT )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == LT) )
            	    {
            	        int LA36_2 = input.LA(2);

            	        if ( (synpred49_JavaScript()) )
            	        {
            	            alt36 = 1;
            	        }


            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_variableDeclarationNoIn468); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements

            	// JavaScript.g:192:19: ( initialiserNoIn )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 37) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: initialiserNoIn
            	        {
            	        	PushFollow(FOLLOW_initialiserNoIn_in_variableDeclarationNoIn471);
            	        	initialiserNoIn();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, variableDeclarationNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableDeclarationNoIn"


    // $ANTLR start "initialiser"
    // JavaScript.g:195:1: initialiser : '=' ( LT )* assignmentExpression ;
    public void initialiser() // throws RecognitionException [1]
    {   
        int initialiser_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:196:2: ( '=' ( LT )* assignmentExpression )
            // JavaScript.g:196:4: '=' ( LT )* assignmentExpression
            {
            	Match(input,37,FOLLOW_37_in_initialiser484); if (state.failed) return ;
            	// JavaScript.g:196:8: ( LT )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == LT) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_initialiser486); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements

            	PushFollow(FOLLOW_assignmentExpression_in_initialiser489);
            	assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, initialiser_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "initialiser"


    // $ANTLR start "initialiserNoIn"
    // JavaScript.g:199:1: initialiserNoIn : '=' ( LT )* assignmentExpressionNoIn ;
    public void initialiserNoIn() // throws RecognitionException [1]
    {   
        int initialiserNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:200:2: ( '=' ( LT )* assignmentExpressionNoIn )
            // JavaScript.g:200:4: '=' ( LT )* assignmentExpressionNoIn
            {
            	Match(input,37,FOLLOW_37_in_initialiserNoIn501); if (state.failed) return ;
            	// JavaScript.g:200:8: ( LT )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == LT) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_initialiserNoIn503); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	PushFollow(FOLLOW_assignmentExpressionNoIn_in_initialiserNoIn506);
            	assignmentExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, initialiserNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "initialiserNoIn"


    // $ANTLR start "emptyStatement"
    // JavaScript.g:203:1: emptyStatement : ';' ;
    public void emptyStatement() // throws RecognitionException [1]
    {   
        int emptyStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:204:2: ( ';' )
            // JavaScript.g:204:4: ';'
            {
            	Match(input,36,FOLLOW_36_in_emptyStatement518); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, emptyStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "emptyStatement"

    public class expressionStatement_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "expressionStatement"
    // JavaScript.g:207:1: expressionStatement : expression ( LT | ';' ) ;
    public JavaScriptParser.expressionStatement_return expressionStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.expressionStatement_return retval = new JavaScriptParser.expressionStatement_return();
        retval.Start = input.LT(1);
        int expressionStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // JavaScript.g:208:2: ( expression ( LT | ';' ) )
            // JavaScript.g:208:4: expression ( LT | ';' )
            {
            	PushFollow(FOLLOW_expression_in_expressionStatement530);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, expressionStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expressionStatement"


    // $ANTLR start "ifStatement"
    // JavaScript.g:211:1: ifStatement : 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( LT )* 'else' ( LT )* statement )? ;
    public void ifStatement() // throws RecognitionException [1]
    {   
        int ifStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:212:2: ( 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( LT )* 'else' ( LT )* statement )? )
            // JavaScript.g:212:4: 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( LT )* 'else' ( LT )* statement )?
            {
            	Match(input,38,FOLLOW_38_in_ifStatement550); if (state.failed) return ;
            	// JavaScript.g:212:9: ( LT )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == LT) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_ifStatement552); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	Match(input,30,FOLLOW_30_in_ifStatement555); if (state.failed) return ;
            	// JavaScript.g:212:17: ( LT )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == LT) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_ifStatement557); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	PushFollow(FOLLOW_expression_in_ifStatement560);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:212:32: ( LT )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == LT) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_ifStatement562); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	Match(input,32,FOLLOW_32_in_ifStatement565); if (state.failed) return ;
            	// JavaScript.g:212:40: ( LT )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == LT) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_ifStatement567); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   RaiseEnterBranch(); 
            	}
            	PushFollow(FOLLOW_statement_in_ifStatement572);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	if ( (state.backtracking==0) )
            	{
            	   RaiseLeaveBranch(); 
            	}
            	// JavaScript.g:212:102: ( ( LT )* 'else' ( LT )* statement )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == LT) )
            	{
            	    int LA46_1 = input.LA(2);

            	    if ( (synpred60_JavaScript()) )
            	    {
            	        alt46 = 1;
            	    }
            	}
            	else if ( (LA46_0 == 39) )
            	{
            	    int LA46_2 = input.LA(2);

            	    if ( (synpred60_JavaScript()) )
            	    {
            	        alt46 = 1;
            	    }
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // JavaScript.g:212:103: ( LT )* 'else' ( LT )* statement
            	        {
            	        	// JavaScript.g:212:103: ( LT )*
            	        	do 
            	        	{
            	        	    int alt44 = 2;
            	        	    int LA44_0 = input.LA(1);

            	        	    if ( (LA44_0 == LT) )
            	        	    {
            	        	        alt44 = 1;
            	        	    }


            	        	    switch (alt44) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_ifStatement577); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop44;
            	        	    }
            	        	} while (true);

            	        	loop44:
            	        		;	// Stops C# compiler whining that label 'loop44' has no statements

            	        	Match(input,39,FOLLOW_39_in_ifStatement580); if (state.failed) return ;
            	        	// JavaScript.g:212:114: ( LT )*
            	        	do 
            	        	{
            	        	    int alt45 = 2;
            	        	    int LA45_0 = input.LA(1);

            	        	    if ( (LA45_0 == LT) )
            	        	    {
            	        	        alt45 = 1;
            	        	    }


            	        	    switch (alt45) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_ifStatement582); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop45;
            	        	    }
            	        	} while (true);

            	        	loop45:
            	        		;	// Stops C# compiler whining that label 'loop45' has no statements

            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   RaiseEnterBranch(); 
            	        	}
            	        	PushFollow(FOLLOW_statement_in_ifStatement587);
            	        	statement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   RaiseLeaveBranch(); 
            	        	}

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, ifStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "ifStatement"


    // $ANTLR start "iterationStatement"
    // JavaScript.g:215:1: iterationStatement : ( doWhileStatement | whileStatement | forStatement | forInStatement );
    public void iterationStatement() // throws RecognitionException [1]
    {   
        int iterationStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:216:2: ( doWhileStatement | whileStatement | forStatement | forInStatement )
            int alt47 = 4;
            switch ( input.LA(1) ) 
            {
            case 40:
            	{
                alt47 = 1;
                }
                break;
            case 41:
            	{
                alt47 = 2;
                }
                break;
            case 42:
            	{
                int LA47_3 = input.LA(2);

                if ( (synpred63_JavaScript()) )
                {
                    alt47 = 3;
                }
                else if ( (true) )
                {
                    alt47 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    NoViableAltException nvae_d47s3 =
                        new NoViableAltException("", 47, 3, input);

                    throw nvae_d47s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d47s0 =
            	        new NoViableAltException("", 47, 0, input);

            	    throw nvae_d47s0;
            }

            switch (alt47) 
            {
                case 1 :
                    // JavaScript.g:216:4: doWhileStatement
                    {
                    	PushFollow(FOLLOW_doWhileStatement_in_iterationStatement603);
                    	doWhileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:217:4: whileStatement
                    {
                    	PushFollow(FOLLOW_whileStatement_in_iterationStatement608);
                    	whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // JavaScript.g:218:4: forStatement
                    {
                    	PushFollow(FOLLOW_forStatement_in_iterationStatement613);
                    	forStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 4 :
                    // JavaScript.g:219:4: forInStatement
                    {
                    	PushFollow(FOLLOW_forInStatement_in_iterationStatement618);
                    	forInStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, iterationStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "iterationStatement"


    // $ANTLR start "doWhileStatement"
    // JavaScript.g:222:1: doWhileStatement : 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' expression ')' ( LT | ';' ) ;
    public void doWhileStatement() // throws RecognitionException [1]
    {   
        int doWhileStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:223:2: ( 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' expression ')' ( LT | ';' ) )
            // JavaScript.g:223:4: 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' expression ')' ( LT | ';' )
            {
            	Match(input,40,FOLLOW_40_in_doWhileStatement630); if (state.failed) return ;
            	// JavaScript.g:223:9: ( LT )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == LT) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_doWhileStatement632); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	PushFollow(FOLLOW_statement_in_doWhileStatement635);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:223:23: ( LT )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( (LA49_0 == LT) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_doWhileStatement637); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	Match(input,41,FOLLOW_41_in_doWhileStatement640); if (state.failed) return ;
            	// JavaScript.g:223:35: ( LT )*
            	do 
            	{
            	    int alt50 = 2;
            	    int LA50_0 = input.LA(1);

            	    if ( (LA50_0 == LT) )
            	    {
            	        alt50 = 1;
            	    }


            	    switch (alt50) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_doWhileStatement642); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop50;
            	    }
            	} while (true);

            	loop50:
            		;	// Stops C# compiler whining that label 'loop50' has no statements

            	Match(input,30,FOLLOW_30_in_doWhileStatement645); if (state.failed) return ;
            	PushFollow(FOLLOW_expression_in_doWhileStatement647);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	Match(input,32,FOLLOW_32_in_doWhileStatement649); if (state.failed) return ;
            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, doWhileStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "doWhileStatement"


    // $ANTLR start "whileStatement"
    // JavaScript.g:226:1: whileStatement : 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ;
    public void whileStatement() // throws RecognitionException [1]
    {   
        int whileStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:227:2: ( 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement )
            // JavaScript.g:227:4: 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement
            {
            	Match(input,41,FOLLOW_41_in_whileStatement669); if (state.failed) return ;
            	// JavaScript.g:227:12: ( LT )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == LT) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_whileStatement671); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements

            	Match(input,30,FOLLOW_30_in_whileStatement674); if (state.failed) return ;
            	// JavaScript.g:227:20: ( LT )*
            	do 
            	{
            	    int alt52 = 2;
            	    int LA52_0 = input.LA(1);

            	    if ( (LA52_0 == LT) )
            	    {
            	        alt52 = 1;
            	    }


            	    switch (alt52) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_whileStatement676); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop52;
            	    }
            	} while (true);

            	loop52:
            		;	// Stops C# compiler whining that label 'loop52' has no statements

            	PushFollow(FOLLOW_expression_in_whileStatement679);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:227:35: ( LT )*
            	do 
            	{
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( (LA53_0 == LT) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_whileStatement681); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements

            	Match(input,32,FOLLOW_32_in_whileStatement684); if (state.failed) return ;
            	// JavaScript.g:227:43: ( LT )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( (LA54_0 == LT) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_whileStatement686); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements

            	PushFollow(FOLLOW_statement_in_whileStatement689);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, whileStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "whileStatement"


    // $ANTLR start "forStatement"
    // JavaScript.g:230:1: forStatement : 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ')' ( LT )* statement ;
    public void forStatement() // throws RecognitionException [1]
    {   
        int forStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:231:2: ( 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ')' ( LT )* statement )
            // JavaScript.g:231:4: 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ';' ( ( LT )* expression )? ( LT )* ')' ( LT )* statement
            {
            	Match(input,42,FOLLOW_42_in_forStatement701); if (state.failed) return ;
            	// JavaScript.g:231:10: ( LT )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == LT) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forStatement703); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements

            	Match(input,30,FOLLOW_30_in_forStatement706); if (state.failed) return ;
            	// JavaScript.g:231:18: ( ( LT )* forStatementInitialiserPart )?
            	int alt57 = 2;
            	alt57 = dfa57.Predict(input);
            	switch (alt57) 
            	{
            	    case 1 :
            	        // JavaScript.g:231:19: ( LT )* forStatementInitialiserPart
            	        {
            	        	// JavaScript.g:231:19: ( LT )*
            	        	do 
            	        	{
            	        	    int alt56 = 2;
            	        	    int LA56_0 = input.LA(1);

            	        	    if ( (LA56_0 == LT) )
            	        	    {
            	        	        alt56 = 1;
            	        	    }


            	        	    switch (alt56) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_forStatement709); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop56;
            	        	    }
            	        	} while (true);

            	        	loop56:
            	        		;	// Stops C# compiler whining that label 'loop56' has no statements

            	        	PushFollow(FOLLOW_forStatementInitialiserPart_in_forStatement712);
            	        	forStatementInitialiserPart();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:231:53: ( LT )*
            	do 
            	{
            	    int alt58 = 2;
            	    int LA58_0 = input.LA(1);

            	    if ( (LA58_0 == LT) )
            	    {
            	        alt58 = 1;
            	    }


            	    switch (alt58) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forStatement716); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop58;
            	    }
            	} while (true);

            	loop58:
            		;	// Stops C# compiler whining that label 'loop58' has no statements

            	Match(input,36,FOLLOW_36_in_forStatement719); if (state.failed) return ;
            	// JavaScript.g:231:61: ( ( LT )* expression )?
            	int alt60 = 2;
            	alt60 = dfa60.Predict(input);
            	switch (alt60) 
            	{
            	    case 1 :
            	        // JavaScript.g:231:62: ( LT )* expression
            	        {
            	        	// JavaScript.g:231:62: ( LT )*
            	        	do 
            	        	{
            	        	    int alt59 = 2;
            	        	    int LA59_0 = input.LA(1);

            	        	    if ( (LA59_0 == LT) )
            	        	    {
            	        	        alt59 = 1;
            	        	    }


            	        	    switch (alt59) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_forStatement722); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop59;
            	        	    }
            	        	} while (true);

            	        	loop59:
            	        		;	// Stops C# compiler whining that label 'loop59' has no statements

            	        	PushFollow(FOLLOW_expression_in_forStatement725);
            	        	expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:231:79: ( LT )*
            	do 
            	{
            	    int alt61 = 2;
            	    int LA61_0 = input.LA(1);

            	    if ( (LA61_0 == LT) )
            	    {
            	        alt61 = 1;
            	    }


            	    switch (alt61) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forStatement729); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop61;
            	    }
            	} while (true);

            	loop61:
            		;	// Stops C# compiler whining that label 'loop61' has no statements

            	Match(input,36,FOLLOW_36_in_forStatement732); if (state.failed) return ;
            	// JavaScript.g:231:87: ( ( LT )* expression )?
            	int alt63 = 2;
            	alt63 = dfa63.Predict(input);
            	switch (alt63) 
            	{
            	    case 1 :
            	        // JavaScript.g:231:88: ( LT )* expression
            	        {
            	        	// JavaScript.g:231:88: ( LT )*
            	        	do 
            	        	{
            	        	    int alt62 = 2;
            	        	    int LA62_0 = input.LA(1);

            	        	    if ( (LA62_0 == LT) )
            	        	    {
            	        	        alt62 = 1;
            	        	    }


            	        	    switch (alt62) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_forStatement735); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop62;
            	        	    }
            	        	} while (true);

            	        	loop62:
            	        		;	// Stops C# compiler whining that label 'loop62' has no statements

            	        	PushFollow(FOLLOW_expression_in_forStatement738);
            	        	expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:231:105: ( LT )*
            	do 
            	{
            	    int alt64 = 2;
            	    int LA64_0 = input.LA(1);

            	    if ( (LA64_0 == LT) )
            	    {
            	        alt64 = 1;
            	    }


            	    switch (alt64) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forStatement742); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop64;
            	    }
            	} while (true);

            	loop64:
            		;	// Stops C# compiler whining that label 'loop64' has no statements

            	Match(input,32,FOLLOW_32_in_forStatement745); if (state.failed) return ;
            	// JavaScript.g:231:113: ( LT )*
            	do 
            	{
            	    int alt65 = 2;
            	    int LA65_0 = input.LA(1);

            	    if ( (LA65_0 == LT) )
            	    {
            	        alt65 = 1;
            	    }


            	    switch (alt65) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forStatement747); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop65;
            	    }
            	} while (true);

            	loop65:
            		;	// Stops C# compiler whining that label 'loop65' has no statements

            	PushFollow(FOLLOW_statement_in_forStatement750);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, forStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "forStatement"


    // $ANTLR start "forStatementInitialiserPart"
    // JavaScript.g:234:1: forStatementInitialiserPart : ( expressionNoIn | 'var' ( LT )* variableDeclarationListNoIn );
    public void forStatementInitialiserPart() // throws RecognitionException [1]
    {   
        int forStatementInitialiserPart_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:235:2: ( expressionNoIn | 'var' ( LT )* variableDeclarationListNoIn )
            int alt67 = 2;
            int LA67_0 = input.LA(1);

            if ( ((LA67_0 >= Identifier && LA67_0 <= NumericLiteral) || (LA67_0 >= 29 && LA67_0 <= 30) || LA67_0 == 33 || (LA67_0 >= 56 && LA67_0 <= 57) || (LA67_0 >= 89 && LA67_0 <= 90) || (LA67_0 >= 94 && LA67_0 <= 104)) )
            {
                alt67 = 1;
            }
            else if ( (LA67_0 == 35) )
            {
                alt67 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d67s0 =
                    new NoViableAltException("", 67, 0, input);

                throw nvae_d67s0;
            }
            switch (alt67) 
            {
                case 1 :
                    // JavaScript.g:235:4: expressionNoIn
                    {
                    	PushFollow(FOLLOW_expressionNoIn_in_forStatementInitialiserPart762);
                    	expressionNoIn();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:236:4: 'var' ( LT )* variableDeclarationListNoIn
                    {
                    	Match(input,35,FOLLOW_35_in_forStatementInitialiserPart767); if (state.failed) return ;
                    	// JavaScript.g:236:10: ( LT )*
                    	do 
                    	{
                    	    int alt66 = 2;
                    	    int LA66_0 = input.LA(1);

                    	    if ( (LA66_0 == LT) )
                    	    {
                    	        alt66 = 1;
                    	    }


                    	    switch (alt66) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_forStatementInitialiserPart769); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop66;
                    	    }
                    	} while (true);

                    	loop66:
                    		;	// Stops C# compiler whining that label 'loop66' has no statements

                    	PushFollow(FOLLOW_variableDeclarationListNoIn_in_forStatementInitialiserPart772);
                    	variableDeclarationListNoIn();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, forStatementInitialiserPart_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "forStatementInitialiserPart"


    // $ANTLR start "forInStatement"
    // JavaScript.g:239:1: forInStatement : 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement ;
    public void forInStatement() // throws RecognitionException [1]
    {   
        int forInStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:240:2: ( 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement )
            // JavaScript.g:240:4: 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement
            {
            	Match(input,42,FOLLOW_42_in_forInStatement784); if (state.failed) return ;
            	// JavaScript.g:240:10: ( LT )*
            	do 
            	{
            	    int alt68 = 2;
            	    int LA68_0 = input.LA(1);

            	    if ( (LA68_0 == LT) )
            	    {
            	        alt68 = 1;
            	    }


            	    switch (alt68) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forInStatement786); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop68;
            	    }
            	} while (true);

            	loop68:
            		;	// Stops C# compiler whining that label 'loop68' has no statements

            	Match(input,30,FOLLOW_30_in_forInStatement789); if (state.failed) return ;
            	// JavaScript.g:240:18: ( LT )*
            	do 
            	{
            	    int alt69 = 2;
            	    int LA69_0 = input.LA(1);

            	    if ( (LA69_0 == LT) )
            	    {
            	        alt69 = 1;
            	    }


            	    switch (alt69) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forInStatement791); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop69;
            	    }
            	} while (true);

            	loop69:
            		;	// Stops C# compiler whining that label 'loop69' has no statements

            	PushFollow(FOLLOW_forInStatementInitialiserPart_in_forInStatement794);
            	forInStatementInitialiserPart();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:240:52: ( LT )*
            	do 
            	{
            	    int alt70 = 2;
            	    int LA70_0 = input.LA(1);

            	    if ( (LA70_0 == LT) )
            	    {
            	        alt70 = 1;
            	    }


            	    switch (alt70) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forInStatement796); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop70;
            	    }
            	} while (true);

            	loop70:
            		;	// Stops C# compiler whining that label 'loop70' has no statements

            	Match(input,43,FOLLOW_43_in_forInStatement799); if (state.failed) return ;
            	// JavaScript.g:240:61: ( LT )*
            	do 
            	{
            	    int alt71 = 2;
            	    int LA71_0 = input.LA(1);

            	    if ( (LA71_0 == LT) )
            	    {
            	        alt71 = 1;
            	    }


            	    switch (alt71) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forInStatement801); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop71;
            	    }
            	} while (true);

            	loop71:
            		;	// Stops C# compiler whining that label 'loop71' has no statements

            	PushFollow(FOLLOW_expression_in_forInStatement804);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:240:76: ( LT )*
            	do 
            	{
            	    int alt72 = 2;
            	    int LA72_0 = input.LA(1);

            	    if ( (LA72_0 == LT) )
            	    {
            	        alt72 = 1;
            	    }


            	    switch (alt72) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forInStatement806); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop72;
            	    }
            	} while (true);

            	loop72:
            		;	// Stops C# compiler whining that label 'loop72' has no statements

            	Match(input,32,FOLLOW_32_in_forInStatement809); if (state.failed) return ;
            	// JavaScript.g:240:84: ( LT )*
            	do 
            	{
            	    int alt73 = 2;
            	    int LA73_0 = input.LA(1);

            	    if ( (LA73_0 == LT) )
            	    {
            	        alt73 = 1;
            	    }


            	    switch (alt73) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_forInStatement811); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop73;
            	    }
            	} while (true);

            	loop73:
            		;	// Stops C# compiler whining that label 'loop73' has no statements

            	PushFollow(FOLLOW_statement_in_forInStatement814);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, forInStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "forInStatement"


    // $ANTLR start "forInStatementInitialiserPart"
    // JavaScript.g:243:1: forInStatementInitialiserPart : ( leftHandSideExpression | 'var' ( LT )* variableDeclarationNoIn );
    public void forInStatementInitialiserPart() // throws RecognitionException [1]
    {   
        int forInStatementInitialiserPart_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:244:2: ( leftHandSideExpression | 'var' ( LT )* variableDeclarationNoIn )
            int alt75 = 2;
            int LA75_0 = input.LA(1);

            if ( ((LA75_0 >= Identifier && LA75_0 <= NumericLiteral) || (LA75_0 >= 29 && LA75_0 <= 30) || LA75_0 == 33 || (LA75_0 >= 56 && LA75_0 <= 57) || (LA75_0 >= 101 && LA75_0 <= 104)) )
            {
                alt75 = 1;
            }
            else if ( (LA75_0 == 35) )
            {
                alt75 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d75s0 =
                    new NoViableAltException("", 75, 0, input);

                throw nvae_d75s0;
            }
            switch (alt75) 
            {
                case 1 :
                    // JavaScript.g:244:4: leftHandSideExpression
                    {
                    	PushFollow(FOLLOW_leftHandSideExpression_in_forInStatementInitialiserPart826);
                    	leftHandSideExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:245:4: 'var' ( LT )* variableDeclarationNoIn
                    {
                    	Match(input,35,FOLLOW_35_in_forInStatementInitialiserPart831); if (state.failed) return ;
                    	// JavaScript.g:245:10: ( LT )*
                    	do 
                    	{
                    	    int alt74 = 2;
                    	    int LA74_0 = input.LA(1);

                    	    if ( (LA74_0 == LT) )
                    	    {
                    	        alt74 = 1;
                    	    }


                    	    switch (alt74) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_forInStatementInitialiserPart833); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop74;
                    	    }
                    	} while (true);

                    	loop74:
                    		;	// Stops C# compiler whining that label 'loop74' has no statements

                    	PushFollow(FOLLOW_variableDeclarationNoIn_in_forInStatementInitialiserPart836);
                    	variableDeclarationNoIn();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, forInStatementInitialiserPart_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "forInStatementInitialiserPart"


    // $ANTLR start "continueStatement"
    // JavaScript.g:248:1: continueStatement : 'continue' ( Identifier )? ( LT | ';' ) ;
    public void continueStatement() // throws RecognitionException [1]
    {   
        int continueStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:249:2: ( 'continue' ( Identifier )? ( LT | ';' ) )
            // JavaScript.g:249:4: 'continue' ( Identifier )? ( LT | ';' )
            {
            	Match(input,44,FOLLOW_44_in_continueStatement847); if (state.failed) return ;
            	// JavaScript.g:249:15: ( Identifier )?
            	int alt76 = 2;
            	int LA76_0 = input.LA(1);

            	if ( (LA76_0 == Identifier) )
            	{
            	    alt76 = 1;
            	}
            	switch (alt76) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: Identifier
            	        {
            	        	Match(input,Identifier,FOLLOW_Identifier_in_continueStatement849); if (state.failed) return ;

            	        }
            	        break;

            	}

            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, continueStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "continueStatement"


    // $ANTLR start "breakStatement"
    // JavaScript.g:252:1: breakStatement : 'break' ( Identifier )? ( LT | ';' ) ;
    public void breakStatement() // throws RecognitionException [1]
    {   
        int breakStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:253:2: ( 'break' ( Identifier )? ( LT | ';' ) )
            // JavaScript.g:253:4: 'break' ( Identifier )? ( LT | ';' )
            {
            	Match(input,45,FOLLOW_45_in_breakStatement869); if (state.failed) return ;
            	// JavaScript.g:253:12: ( Identifier )?
            	int alt77 = 2;
            	int LA77_0 = input.LA(1);

            	if ( (LA77_0 == Identifier) )
            	{
            	    alt77 = 1;
            	}
            	switch (alt77) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: Identifier
            	        {
            	        	Match(input,Identifier,FOLLOW_Identifier_in_breakStatement871); if (state.failed) return ;

            	        }
            	        break;

            	}

            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 29, breakStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "breakStatement"

    public class returnStatement_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "returnStatement"
    // JavaScript.g:256:1: returnStatement : 'return' ( expression )? ( LT | ';' ) ;
    public JavaScriptParser.returnStatement_return returnStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.returnStatement_return retval = new JavaScriptParser.returnStatement_return();
        retval.Start = input.LT(1);
        int returnStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // JavaScript.g:257:2: ( 'return' ( expression )? ( LT | ';' ) )
            // JavaScript.g:257:4: 'return' ( expression )? ( LT | ';' )
            {
            	Match(input,46,FOLLOW_46_in_returnStatement891); if (state.failed) return retval;
            	// JavaScript.g:257:13: ( expression )?
            	int alt78 = 2;
            	int LA78_0 = input.LA(1);

            	if ( ((LA78_0 >= Identifier && LA78_0 <= NumericLiteral) || (LA78_0 >= 29 && LA78_0 <= 30) || LA78_0 == 33 || (LA78_0 >= 56 && LA78_0 <= 57) || (LA78_0 >= 89 && LA78_0 <= 90) || (LA78_0 >= 94 && LA78_0 <= 104)) )
            	{
            	    alt78 = 1;
            	}
            	switch (alt78) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_returnStatement893);
            	        	expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;

            	        }
            	        break;

            	}

            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 30, returnStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "returnStatement"


    // $ANTLR start "withStatement"
    // JavaScript.g:260:1: withStatement : 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ;
    public void withStatement() // throws RecognitionException [1]
    {   
        int withStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:261:2: ( 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement )
            // JavaScript.g:261:4: 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement
            {
            	Match(input,47,FOLLOW_47_in_withStatement914); if (state.failed) return ;
            	// JavaScript.g:261:11: ( LT )*
            	do 
            	{
            	    int alt79 = 2;
            	    int LA79_0 = input.LA(1);

            	    if ( (LA79_0 == LT) )
            	    {
            	        alt79 = 1;
            	    }


            	    switch (alt79) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_withStatement916); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop79;
            	    }
            	} while (true);

            	loop79:
            		;	// Stops C# compiler whining that label 'loop79' has no statements

            	Match(input,30,FOLLOW_30_in_withStatement919); if (state.failed) return ;
            	// JavaScript.g:261:19: ( LT )*
            	do 
            	{
            	    int alt80 = 2;
            	    int LA80_0 = input.LA(1);

            	    if ( (LA80_0 == LT) )
            	    {
            	        alt80 = 1;
            	    }


            	    switch (alt80) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_withStatement921); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop80;
            	    }
            	} while (true);

            	loop80:
            		;	// Stops C# compiler whining that label 'loop80' has no statements

            	PushFollow(FOLLOW_expression_in_withStatement924);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:261:34: ( LT )*
            	do 
            	{
            	    int alt81 = 2;
            	    int LA81_0 = input.LA(1);

            	    if ( (LA81_0 == LT) )
            	    {
            	        alt81 = 1;
            	    }


            	    switch (alt81) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_withStatement926); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop81;
            	    }
            	} while (true);

            	loop81:
            		;	// Stops C# compiler whining that label 'loop81' has no statements

            	Match(input,32,FOLLOW_32_in_withStatement929); if (state.failed) return ;
            	// JavaScript.g:261:42: ( LT )*
            	do 
            	{
            	    int alt82 = 2;
            	    int LA82_0 = input.LA(1);

            	    if ( (LA82_0 == LT) )
            	    {
            	        alt82 = 1;
            	    }


            	    switch (alt82) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_withStatement931); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop82;
            	    }
            	} while (true);

            	loop82:
            		;	// Stops C# compiler whining that label 'loop82' has no statements

            	PushFollow(FOLLOW_statement_in_withStatement934);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 31, withStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "withStatement"


    // $ANTLR start "labelledStatement"
    // JavaScript.g:264:1: labelledStatement : Identifier ( LT )* ':' ( LT )* statement ;
    public void labelledStatement() // throws RecognitionException [1]
    {   
        int labelledStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:265:2: ( Identifier ( LT )* ':' ( LT )* statement )
            // JavaScript.g:265:4: Identifier ( LT )* ':' ( LT )* statement
            {
            	Match(input,Identifier,FOLLOW_Identifier_in_labelledStatement945); if (state.failed) return ;
            	// JavaScript.g:265:15: ( LT )*
            	do 
            	{
            	    int alt83 = 2;
            	    int LA83_0 = input.LA(1);

            	    if ( (LA83_0 == LT) )
            	    {
            	        alt83 = 1;
            	    }


            	    switch (alt83) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_labelledStatement947); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop83;
            	    }
            	} while (true);

            	loop83:
            		;	// Stops C# compiler whining that label 'loop83' has no statements

            	Match(input,48,FOLLOW_48_in_labelledStatement950); if (state.failed) return ;
            	// JavaScript.g:265:23: ( LT )*
            	do 
            	{
            	    int alt84 = 2;
            	    int LA84_0 = input.LA(1);

            	    if ( (LA84_0 == LT) )
            	    {
            	        alt84 = 1;
            	    }


            	    switch (alt84) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_labelledStatement952); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop84;
            	    }
            	} while (true);

            	loop84:
            		;	// Stops C# compiler whining that label 'loop84' has no statements

            	PushFollow(FOLLOW_statement_in_labelledStatement955);
            	statement();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 32, labelledStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "labelledStatement"


    // $ANTLR start "switchStatement"
    // JavaScript.g:268:1: switchStatement : 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock ;
    public void switchStatement() // throws RecognitionException [1]
    {   
        int switchStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:269:2: ( 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock )
            // JavaScript.g:269:4: 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock
            {
            	Match(input,49,FOLLOW_49_in_switchStatement967); if (state.failed) return ;
            	// JavaScript.g:269:13: ( LT )*
            	do 
            	{
            	    int alt85 = 2;
            	    int LA85_0 = input.LA(1);

            	    if ( (LA85_0 == LT) )
            	    {
            	        alt85 = 1;
            	    }


            	    switch (alt85) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_switchStatement969); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop85;
            	    }
            	} while (true);

            	loop85:
            		;	// Stops C# compiler whining that label 'loop85' has no statements

            	Match(input,30,FOLLOW_30_in_switchStatement972); if (state.failed) return ;
            	// JavaScript.g:269:21: ( LT )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( (LA86_0 == LT) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_switchStatement974); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements

            	PushFollow(FOLLOW_expression_in_switchStatement977);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:269:36: ( LT )*
            	do 
            	{
            	    int alt87 = 2;
            	    int LA87_0 = input.LA(1);

            	    if ( (LA87_0 == LT) )
            	    {
            	        alt87 = 1;
            	    }


            	    switch (alt87) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_switchStatement979); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop87;
            	    }
            	} while (true);

            	loop87:
            		;	// Stops C# compiler whining that label 'loop87' has no statements

            	Match(input,32,FOLLOW_32_in_switchStatement982); if (state.failed) return ;
            	// JavaScript.g:269:44: ( LT )*
            	do 
            	{
            	    int alt88 = 2;
            	    int LA88_0 = input.LA(1);

            	    if ( (LA88_0 == LT) )
            	    {
            	        alt88 = 1;
            	    }


            	    switch (alt88) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_switchStatement984); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop88;
            	    }
            	} while (true);

            	loop88:
            		;	// Stops C# compiler whining that label 'loop88' has no statements

            	PushFollow(FOLLOW_caseBlock_in_switchStatement987);
            	caseBlock();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 33, switchStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "switchStatement"


    // $ANTLR start "caseBlock"
    // JavaScript.g:272:1: caseBlock : '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}' ;
    public void caseBlock() // throws RecognitionException [1]
    {   
        int caseBlock_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:273:2: ( '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}' )
            // JavaScript.g:273:4: '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}'
            {
            	Match(input,33,FOLLOW_33_in_caseBlock999); if (state.failed) return ;
            	// JavaScript.g:273:8: ( ( LT )* caseClause )*
            	do 
            	{
            	    int alt90 = 2;
            	    alt90 = dfa90.Predict(input);
            	    switch (alt90) 
            		{
            			case 1 :
            			    // JavaScript.g:273:9: ( LT )* caseClause
            			    {
            			    	// JavaScript.g:273:9: ( LT )*
            			    	do 
            			    	{
            			    	    int alt89 = 2;
            			    	    int LA89_0 = input.LA(1);

            			    	    if ( (LA89_0 == LT) )
            			    	    {
            			    	        alt89 = 1;
            			    	    }


            			    	    switch (alt89) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_caseBlock1002); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop89;
            			    	    }
            			    	} while (true);

            			    	loop89:
            			    		;	// Stops C# compiler whining that label 'loop89' has no statements

            			    	PushFollow(FOLLOW_caseClause_in_caseBlock1005);
            			    	caseClause();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop90;
            	    }
            	} while (true);

            	loop90:
            		;	// Stops C# compiler whining that label 'loop90' has no statements

            	// JavaScript.g:273:26: ( ( LT )* defaultClause ( ( LT )* caseClause )* )?
            	int alt94 = 2;
            	alt94 = dfa94.Predict(input);
            	switch (alt94) 
            	{
            	    case 1 :
            	        // JavaScript.g:273:27: ( LT )* defaultClause ( ( LT )* caseClause )*
            	        {
            	        	// JavaScript.g:273:27: ( LT )*
            	        	do 
            	        	{
            	        	    int alt91 = 2;
            	        	    int LA91_0 = input.LA(1);

            	        	    if ( (LA91_0 == LT) )
            	        	    {
            	        	        alt91 = 1;
            	        	    }


            	        	    switch (alt91) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_caseBlock1010); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop91;
            	        	    }
            	        	} while (true);

            	        	loop91:
            	        		;	// Stops C# compiler whining that label 'loop91' has no statements

            	        	PushFollow(FOLLOW_defaultClause_in_caseBlock1013);
            	        	defaultClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	// JavaScript.g:273:45: ( ( LT )* caseClause )*
            	        	do 
            	        	{
            	        	    int alt93 = 2;
            	        	    alt93 = dfa93.Predict(input);
            	        	    switch (alt93) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:273:46: ( LT )* caseClause
            	        			    {
            	        			    	// JavaScript.g:273:46: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt92 = 2;
            	        			    	    int LA92_0 = input.LA(1);

            	        			    	    if ( (LA92_0 == LT) )
            	        			    	    {
            	        			    	        alt92 = 1;
            	        			    	    }


            	        			    	    switch (alt92) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:0:0: LT
            	        			    			    {
            	        			    			    	Match(input,LT,FOLLOW_LT_in_caseBlock1016); if (state.failed) return ;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop92;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop92:
            	        			    		;	// Stops C# compiler whining that label 'loop92' has no statements

            	        			    	PushFollow(FOLLOW_caseClause_in_caseBlock1019);
            	        			    	caseClause();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop93;
            	        	    }
            	        	} while (true);

            	        	loop93:
            	        		;	// Stops C# compiler whining that label 'loop93' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:273:65: ( LT )*
            	do 
            	{
            	    int alt95 = 2;
            	    int LA95_0 = input.LA(1);

            	    if ( (LA95_0 == LT) )
            	    {
            	        alt95 = 1;
            	    }


            	    switch (alt95) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_caseBlock1025); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop95;
            	    }
            	} while (true);

            	loop95:
            		;	// Stops C# compiler whining that label 'loop95' has no statements

            	Match(input,34,FOLLOW_34_in_caseBlock1028); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 34, caseBlock_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "caseBlock"


    // $ANTLR start "caseClause"
    // JavaScript.g:276:1: caseClause : 'case' ( LT )* expression ( LT )* ':' ( LT )* ( statementList )? ;
    public void caseClause() // throws RecognitionException [1]
    {   
        int caseClause_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:277:2: ( 'case' ( LT )* expression ( LT )* ':' ( LT )* ( statementList )? )
            // JavaScript.g:277:4: 'case' ( LT )* expression ( LT )* ':' ( LT )* ( statementList )?
            {
            	Match(input,50,FOLLOW_50_in_caseClause1039); if (state.failed) return ;
            	// JavaScript.g:277:11: ( LT )*
            	do 
            	{
            	    int alt96 = 2;
            	    int LA96_0 = input.LA(1);

            	    if ( (LA96_0 == LT) )
            	    {
            	        alt96 = 1;
            	    }


            	    switch (alt96) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_caseClause1041); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop96;
            	    }
            	} while (true);

            	loop96:
            		;	// Stops C# compiler whining that label 'loop96' has no statements

            	PushFollow(FOLLOW_expression_in_caseClause1044);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:277:26: ( LT )*
            	do 
            	{
            	    int alt97 = 2;
            	    int LA97_0 = input.LA(1);

            	    if ( (LA97_0 == LT) )
            	    {
            	        alt97 = 1;
            	    }


            	    switch (alt97) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_caseClause1046); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop97;
            	    }
            	} while (true);

            	loop97:
            		;	// Stops C# compiler whining that label 'loop97' has no statements

            	Match(input,48,FOLLOW_48_in_caseClause1049); if (state.failed) return ;
            	// JavaScript.g:277:34: ( LT )*
            	do 
            	{
            	    int alt98 = 2;
            	    int LA98_0 = input.LA(1);

            	    if ( (LA98_0 == LT) )
            	    {
            	        int LA98_2 = input.LA(2);

            	        if ( (synpred118_JavaScript()) )
            	        {
            	            alt98 = 1;
            	        }


            	    }


            	    switch (alt98) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_caseClause1051); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop98;
            	    }
            	} while (true);

            	loop98:
            		;	// Stops C# compiler whining that label 'loop98' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   RaiseEnterBranch(); 
            	}
            	// JavaScript.g:277:62: ( statementList )?
            	int alt99 = 2;
            	int LA99_0 = input.LA(1);

            	if ( ((LA99_0 >= Identifier && LA99_0 <= NumericLiteral) || (LA99_0 >= 29 && LA99_0 <= 30) || LA99_0 == 33 || (LA99_0 >= 35 && LA99_0 <= 36) || LA99_0 == 38 || (LA99_0 >= 40 && LA99_0 <= 42) || (LA99_0 >= 44 && LA99_0 <= 47) || LA99_0 == 49 || (LA99_0 >= 52 && LA99_0 <= 53) || (LA99_0 >= 56 && LA99_0 <= 57) || (LA99_0 >= 89 && LA99_0 <= 90) || (LA99_0 >= 94 && LA99_0 <= 104)) )
            	{
            	    alt99 = 1;
            	}
            	switch (alt99) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: statementList
            	        {
            	        	PushFollow(FOLLOW_statementList_in_caseClause1056);
            	        	statementList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   RaiseLeaveBranch(); 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 35, caseClause_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "caseClause"


    // $ANTLR start "defaultClause"
    // JavaScript.g:280:1: defaultClause : 'default' ( LT )* ':' ( LT )* ( statementList )? ;
    public void defaultClause() // throws RecognitionException [1]
    {   
        int defaultClause_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:281:2: ( 'default' ( LT )* ':' ( LT )* ( statementList )? )
            // JavaScript.g:281:4: 'default' ( LT )* ':' ( LT )* ( statementList )?
            {
            	Match(input,51,FOLLOW_51_in_defaultClause1071); if (state.failed) return ;
            	// JavaScript.g:281:14: ( LT )*
            	do 
            	{
            	    int alt100 = 2;
            	    int LA100_0 = input.LA(1);

            	    if ( (LA100_0 == LT) )
            	    {
            	        alt100 = 1;
            	    }


            	    switch (alt100) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_defaultClause1073); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop100;
            	    }
            	} while (true);

            	loop100:
            		;	// Stops C# compiler whining that label 'loop100' has no statements

            	Match(input,48,FOLLOW_48_in_defaultClause1076); if (state.failed) return ;
            	// JavaScript.g:281:22: ( LT )*
            	do 
            	{
            	    int alt101 = 2;
            	    int LA101_0 = input.LA(1);

            	    if ( (LA101_0 == LT) )
            	    {
            	        int LA101_2 = input.LA(2);

            	        if ( (synpred121_JavaScript()) )
            	        {
            	            alt101 = 1;
            	        }


            	    }


            	    switch (alt101) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_defaultClause1078); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop101;
            	    }
            	} while (true);

            	loop101:
            		;	// Stops C# compiler whining that label 'loop101' has no statements

            	if ( (state.backtracking==0) )
            	{
            	   RaiseEnterBranch(); 
            	}
            	// JavaScript.g:281:50: ( statementList )?
            	int alt102 = 2;
            	int LA102_0 = input.LA(1);

            	if ( ((LA102_0 >= Identifier && LA102_0 <= NumericLiteral) || (LA102_0 >= 29 && LA102_0 <= 30) || LA102_0 == 33 || (LA102_0 >= 35 && LA102_0 <= 36) || LA102_0 == 38 || (LA102_0 >= 40 && LA102_0 <= 42) || (LA102_0 >= 44 && LA102_0 <= 47) || LA102_0 == 49 || (LA102_0 >= 52 && LA102_0 <= 53) || (LA102_0 >= 56 && LA102_0 <= 57) || (LA102_0 >= 89 && LA102_0 <= 90) || (LA102_0 >= 94 && LA102_0 <= 104)) )
            	{
            	    alt102 = 1;
            	}
            	switch (alt102) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: statementList
            	        {
            	        	PushFollow(FOLLOW_statementList_in_defaultClause1083);
            	        	statementList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	   RaiseLeaveBranch(); 
            	}

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 36, defaultClause_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "defaultClause"


    // $ANTLR start "throwStatement"
    // JavaScript.g:284:1: throwStatement : 'throw' expression ( LT | ';' ) ;
    public void throwStatement() // throws RecognitionException [1]
    {   
        int throwStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:285:2: ( 'throw' expression ( LT | ';' ) )
            // JavaScript.g:285:4: 'throw' expression ( LT | ';' )
            {
            	Match(input,52,FOLLOW_52_in_throwStatement1098); if (state.failed) return ;
            	PushFollow(FOLLOW_expression_in_throwStatement1100);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	if ( input.LA(1) == LT || input.LA(1) == 36 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 37, throwStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "throwStatement"


    // $ANTLR start "tryStatement"
    // JavaScript.g:288:1: tryStatement : 'try' ( LT )* statementBlock ( LT )* ( finallyClause | catchClause ( ( LT )* finallyClause )? ) ;
    public void tryStatement() // throws RecognitionException [1]
    {   
        int tryStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:289:2: ( 'try' ( LT )* statementBlock ( LT )* ( finallyClause | catchClause ( ( LT )* finallyClause )? ) )
            // JavaScript.g:289:4: 'try' ( LT )* statementBlock ( LT )* ( finallyClause | catchClause ( ( LT )* finallyClause )? )
            {
            	Match(input,53,FOLLOW_53_in_tryStatement1119); if (state.failed) return ;
            	// JavaScript.g:289:10: ( LT )*
            	do 
            	{
            	    int alt103 = 2;
            	    int LA103_0 = input.LA(1);

            	    if ( (LA103_0 == LT) )
            	    {
            	        alt103 = 1;
            	    }


            	    switch (alt103) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_tryStatement1121); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop103;
            	    }
            	} while (true);

            	loop103:
            		;	// Stops C# compiler whining that label 'loop103' has no statements

            	PushFollow(FOLLOW_statementBlock_in_tryStatement1124);
            	statementBlock();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:289:29: ( LT )*
            	do 
            	{
            	    int alt104 = 2;
            	    int LA104_0 = input.LA(1);

            	    if ( (LA104_0 == LT) )
            	    {
            	        alt104 = 1;
            	    }


            	    switch (alt104) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_tryStatement1126); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop104;
            	    }
            	} while (true);

            	loop104:
            		;	// Stops C# compiler whining that label 'loop104' has no statements

            	// JavaScript.g:289:33: ( finallyClause | catchClause ( ( LT )* finallyClause )? )
            	int alt107 = 2;
            	int LA107_0 = input.LA(1);

            	if ( (LA107_0 == 55) )
            	{
            	    alt107 = 1;
            	}
            	else if ( (LA107_0 == 54) )
            	{
            	    alt107 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d107s0 =
            	        new NoViableAltException("", 107, 0, input);

            	    throw nvae_d107s0;
            	}
            	switch (alt107) 
            	{
            	    case 1 :
            	        // JavaScript.g:289:34: finallyClause
            	        {
            	        	PushFollow(FOLLOW_finallyClause_in_tryStatement1130);
            	        	finallyClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:289:50: catchClause ( ( LT )* finallyClause )?
            	        {
            	        	PushFollow(FOLLOW_catchClause_in_tryStatement1134);
            	        	catchClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	// JavaScript.g:289:62: ( ( LT )* finallyClause )?
            	        	int alt106 = 2;
            	        	alt106 = dfa106.Predict(input);
            	        	switch (alt106) 
            	        	{
            	        	    case 1 :
            	        	        // JavaScript.g:289:63: ( LT )* finallyClause
            	        	        {
            	        	        	// JavaScript.g:289:63: ( LT )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt105 = 2;
            	        	        	    int LA105_0 = input.LA(1);

            	        	        	    if ( (LA105_0 == LT) )
            	        	        	    {
            	        	        	        alt105 = 1;
            	        	        	    }


            	        	        	    switch (alt105) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // JavaScript.g:0:0: LT
            	        	        			    {
            	        	        			    	Match(input,LT,FOLLOW_LT_in_tryStatement1137); if (state.failed) return ;

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop105;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop105:
            	        	        		;	// Stops C# compiler whining that label 'loop105' has no statements

            	        	        	PushFollow(FOLLOW_finallyClause_in_tryStatement1140);
            	        	        	finallyClause();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return ;

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 38, tryStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "tryStatement"


    // $ANTLR start "catchClause"
    // JavaScript.g:292:1: catchClause : 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock ;
    public void catchClause() // throws RecognitionException [1]
    {   
        int catchClause_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:293:2: ( 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock )
            // JavaScript.g:293:4: 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock
            {
            	Match(input,54,FOLLOW_54_in_catchClause1161); if (state.failed) return ;
            	// JavaScript.g:293:12: ( LT )*
            	do 
            	{
            	    int alt108 = 2;
            	    int LA108_0 = input.LA(1);

            	    if ( (LA108_0 == LT) )
            	    {
            	        alt108 = 1;
            	    }


            	    switch (alt108) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_catchClause1163); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop108;
            	    }
            	} while (true);

            	loop108:
            		;	// Stops C# compiler whining that label 'loop108' has no statements

            	Match(input,30,FOLLOW_30_in_catchClause1166); if (state.failed) return ;
            	// JavaScript.g:293:20: ( LT )*
            	do 
            	{
            	    int alt109 = 2;
            	    int LA109_0 = input.LA(1);

            	    if ( (LA109_0 == LT) )
            	    {
            	        alt109 = 1;
            	    }


            	    switch (alt109) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_catchClause1168); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop109;
            	    }
            	} while (true);

            	loop109:
            		;	// Stops C# compiler whining that label 'loop109' has no statements

            	Match(input,Identifier,FOLLOW_Identifier_in_catchClause1171); if (state.failed) return ;
            	// JavaScript.g:293:35: ( LT )*
            	do 
            	{
            	    int alt110 = 2;
            	    int LA110_0 = input.LA(1);

            	    if ( (LA110_0 == LT) )
            	    {
            	        alt110 = 1;
            	    }


            	    switch (alt110) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_catchClause1173); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop110;
            	    }
            	} while (true);

            	loop110:
            		;	// Stops C# compiler whining that label 'loop110' has no statements

            	Match(input,32,FOLLOW_32_in_catchClause1176); if (state.failed) return ;
            	// JavaScript.g:293:43: ( LT )*
            	do 
            	{
            	    int alt111 = 2;
            	    int LA111_0 = input.LA(1);

            	    if ( (LA111_0 == LT) )
            	    {
            	        alt111 = 1;
            	    }


            	    switch (alt111) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_catchClause1178); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop111;
            	    }
            	} while (true);

            	loop111:
            		;	// Stops C# compiler whining that label 'loop111' has no statements

            	PushFollow(FOLLOW_statementBlock_in_catchClause1181);
            	statementBlock();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 39, catchClause_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "catchClause"


    // $ANTLR start "finallyClause"
    // JavaScript.g:296:1: finallyClause : 'finally' ( LT )* statementBlock ;
    public void finallyClause() // throws RecognitionException [1]
    {   
        int finallyClause_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:297:2: ( 'finally' ( LT )* statementBlock )
            // JavaScript.g:297:4: 'finally' ( LT )* statementBlock
            {
            	Match(input,55,FOLLOW_55_in_finallyClause1193); if (state.failed) return ;
            	// JavaScript.g:297:14: ( LT )*
            	do 
            	{
            	    int alt112 = 2;
            	    int LA112_0 = input.LA(1);

            	    if ( (LA112_0 == LT) )
            	    {
            	        alt112 = 1;
            	    }


            	    switch (alt112) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_finallyClause1195); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop112;
            	    }
            	} while (true);

            	loop112:
            		;	// Stops C# compiler whining that label 'loop112' has no statements

            	PushFollow(FOLLOW_statementBlock_in_finallyClause1198);
            	statementBlock();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 40, finallyClause_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "finallyClause"


    // $ANTLR start "expression"
    // JavaScript.g:301:1: expression : assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* ;
    public void expression() // throws RecognitionException [1]
    {   
        int expression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:302:2: ( assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )
            // JavaScript.g:302:4: assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )*
            {
            	PushFollow(FOLLOW_assignmentExpression_in_expression1210);
            	assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:302:25: ( ( LT )* ',' ( LT )* assignmentExpression )*
            	do 
            	{
            	    int alt115 = 2;
            	    alt115 = dfa115.Predict(input);
            	    switch (alt115) 
            		{
            			case 1 :
            			    // JavaScript.g:302:26: ( LT )* ',' ( LT )* assignmentExpression
            			    {
            			    	// JavaScript.g:302:26: ( LT )*
            			    	do 
            			    	{
            			    	    int alt113 = 2;
            			    	    int LA113_0 = input.LA(1);

            			    	    if ( (LA113_0 == LT) )
            			    	    {
            			    	        alt113 = 1;
            			    	    }


            			    	    switch (alt113) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_expression1213); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop113;
            			    	    }
            			    	} while (true);

            			    	loop113:
            			    		;	// Stops C# compiler whining that label 'loop113' has no statements

            			    	Match(input,31,FOLLOW_31_in_expression1216); if (state.failed) return ;
            			    	// JavaScript.g:302:34: ( LT )*
            			    	do 
            			    	{
            			    	    int alt114 = 2;
            			    	    int LA114_0 = input.LA(1);

            			    	    if ( (LA114_0 == LT) )
            			    	    {
            			    	        alt114 = 1;
            			    	    }


            			    	    switch (alt114) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_expression1218); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop114;
            			    	    }
            			    	} while (true);

            			    	loop114:
            			    		;	// Stops C# compiler whining that label 'loop114' has no statements

            			    	PushFollow(FOLLOW_assignmentExpression_in_expression1221);
            			    	assignmentExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop115;
            	    }
            	} while (true);

            	loop115:
            		;	// Stops C# compiler whining that label 'loop115' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 41, expression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "expression"


    // $ANTLR start "expressionNoIn"
    // JavaScript.g:305:1: expressionNoIn : assignmentExpressionNoIn ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )* ;
    public void expressionNoIn() // throws RecognitionException [1]
    {   
        int expressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:306:2: ( assignmentExpressionNoIn ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )* )
            // JavaScript.g:306:4: assignmentExpressionNoIn ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )*
            {
            	PushFollow(FOLLOW_assignmentExpressionNoIn_in_expressionNoIn1235);
            	assignmentExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:306:29: ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )*
            	do 
            	{
            	    int alt118 = 2;
            	    alt118 = dfa118.Predict(input);
            	    switch (alt118) 
            		{
            			case 1 :
            			    // JavaScript.g:306:30: ( LT )* ',' ( LT )* assignmentExpressionNoIn
            			    {
            			    	// JavaScript.g:306:30: ( LT )*
            			    	do 
            			    	{
            			    	    int alt116 = 2;
            			    	    int LA116_0 = input.LA(1);

            			    	    if ( (LA116_0 == LT) )
            			    	    {
            			    	        alt116 = 1;
            			    	    }


            			    	    switch (alt116) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_expressionNoIn1238); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop116;
            			    	    }
            			    	} while (true);

            			    	loop116:
            			    		;	// Stops C# compiler whining that label 'loop116' has no statements

            			    	Match(input,31,FOLLOW_31_in_expressionNoIn1241); if (state.failed) return ;
            			    	// JavaScript.g:306:38: ( LT )*
            			    	do 
            			    	{
            			    	    int alt117 = 2;
            			    	    int LA117_0 = input.LA(1);

            			    	    if ( (LA117_0 == LT) )
            			    	    {
            			    	        alt117 = 1;
            			    	    }


            			    	    switch (alt117) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_expressionNoIn1243); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop117;
            			    	    }
            			    	} while (true);

            			    	loop117:
            			    		;	// Stops C# compiler whining that label 'loop117' has no statements

            			    	PushFollow(FOLLOW_assignmentExpressionNoIn_in_expressionNoIn1246);
            			    	assignmentExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop118;
            	    }
            	} while (true);

            	loop118:
            		;	// Stops C# compiler whining that label 'loop118' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 42, expressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "expressionNoIn"


    // $ANTLR start "assignmentExpression"
    // JavaScript.g:309:1: assignmentExpression : ( conditionalExpression | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression );
    public void assignmentExpression() // throws RecognitionException [1]
    {   
        int assignmentExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:310:2: ( conditionalExpression | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression )
            int alt121 = 2;
            alt121 = dfa121.Predict(input);
            switch (alt121) 
            {
                case 1 :
                    // JavaScript.g:310:4: conditionalExpression
                    {
                    	PushFollow(FOLLOW_conditionalExpression_in_assignmentExpression1260);
                    	conditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:311:4: leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression
                    {
                    	PushFollow(FOLLOW_leftHandSideExpression_in_assignmentExpression1265);
                    	leftHandSideExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// JavaScript.g:311:27: ( LT )*
                    	do 
                    	{
                    	    int alt119 = 2;
                    	    int LA119_0 = input.LA(1);

                    	    if ( (LA119_0 == LT) )
                    	    {
                    	        alt119 = 1;
                    	    }


                    	    switch (alt119) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_assignmentExpression1267); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop119;
                    	    }
                    	} while (true);

                    	loop119:
                    		;	// Stops C# compiler whining that label 'loop119' has no statements

                    	PushFollow(FOLLOW_assignmentOperator_in_assignmentExpression1270);
                    	assignmentOperator();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// JavaScript.g:311:50: ( LT )*
                    	do 
                    	{
                    	    int alt120 = 2;
                    	    int LA120_0 = input.LA(1);

                    	    if ( (LA120_0 == LT) )
                    	    {
                    	        alt120 = 1;
                    	    }


                    	    switch (alt120) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_assignmentExpression1272); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop120;
                    	    }
                    	} while (true);

                    	loop120:
                    		;	// Stops C# compiler whining that label 'loop120' has no statements

                    	PushFollow(FOLLOW_assignmentExpression_in_assignmentExpression1275);
                    	assignmentExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 43, assignmentExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "assignmentExpression"


    // $ANTLR start "assignmentExpressionNoIn"
    // JavaScript.g:314:1: assignmentExpressionNoIn : ( conditionalExpressionNoIn | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn );
    public void assignmentExpressionNoIn() // throws RecognitionException [1]
    {   
        int assignmentExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:315:2: ( conditionalExpressionNoIn | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn )
            int alt124 = 2;
            alt124 = dfa124.Predict(input);
            switch (alt124) 
            {
                case 1 :
                    // JavaScript.g:315:4: conditionalExpressionNoIn
                    {
                    	PushFollow(FOLLOW_conditionalExpressionNoIn_in_assignmentExpressionNoIn1287);
                    	conditionalExpressionNoIn();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:316:4: leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn
                    {
                    	PushFollow(FOLLOW_leftHandSideExpression_in_assignmentExpressionNoIn1292);
                    	leftHandSideExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// JavaScript.g:316:27: ( LT )*
                    	do 
                    	{
                    	    int alt122 = 2;
                    	    int LA122_0 = input.LA(1);

                    	    if ( (LA122_0 == LT) )
                    	    {
                    	        alt122 = 1;
                    	    }


                    	    switch (alt122) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_assignmentExpressionNoIn1294); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop122;
                    	    }
                    	} while (true);

                    	loop122:
                    		;	// Stops C# compiler whining that label 'loop122' has no statements

                    	PushFollow(FOLLOW_assignmentOperator_in_assignmentExpressionNoIn1297);
                    	assignmentOperator();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// JavaScript.g:316:50: ( LT )*
                    	do 
                    	{
                    	    int alt123 = 2;
                    	    int LA123_0 = input.LA(1);

                    	    if ( (LA123_0 == LT) )
                    	    {
                    	        alt123 = 1;
                    	    }


                    	    switch (alt123) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_assignmentExpressionNoIn1299); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop123;
                    	    }
                    	} while (true);

                    	loop123:
                    		;	// Stops C# compiler whining that label 'loop123' has no statements

                    	PushFollow(FOLLOW_assignmentExpressionNoIn_in_assignmentExpressionNoIn1302);
                    	assignmentExpressionNoIn();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 44, assignmentExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "assignmentExpressionNoIn"


    // $ANTLR start "leftHandSideExpression"
    // JavaScript.g:319:1: leftHandSideExpression : ( callExpression | newExpression );
    public void leftHandSideExpression() // throws RecognitionException [1]
    {   
        int leftHandSideExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:320:2: ( callExpression | newExpression )
            int alt125 = 2;
            alt125 = dfa125.Predict(input);
            switch (alt125) 
            {
                case 1 :
                    // JavaScript.g:320:4: callExpression
                    {
                    	PushFollow(FOLLOW_callExpression_in_leftHandSideExpression1314);
                    	callExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:321:4: newExpression
                    {
                    	PushFollow(FOLLOW_newExpression_in_leftHandSideExpression1319);
                    	newExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 45, leftHandSideExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "leftHandSideExpression"


    // $ANTLR start "newExpression"
    // JavaScript.g:324:1: newExpression : ( memberExpression | 'new' ( LT )* newExpression );
    public void newExpression() // throws RecognitionException [1]
    {   
        int newExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 46) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:325:2: ( memberExpression | 'new' ( LT )* newExpression )
            int alt127 = 2;
            alt127 = dfa127.Predict(input);
            switch (alt127) 
            {
                case 1 :
                    // JavaScript.g:325:4: memberExpression
                    {
                    	PushFollow(FOLLOW_memberExpression_in_newExpression1331);
                    	memberExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:326:4: 'new' ( LT )* newExpression
                    {
                    	Match(input,56,FOLLOW_56_in_newExpression1336); if (state.failed) return ;
                    	// JavaScript.g:326:10: ( LT )*
                    	do 
                    	{
                    	    int alt126 = 2;
                    	    int LA126_0 = input.LA(1);

                    	    if ( (LA126_0 == LT) )
                    	    {
                    	        alt126 = 1;
                    	    }


                    	    switch (alt126) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_newExpression1338); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop126;
                    	    }
                    	} while (true);

                    	loop126:
                    		;	// Stops C# compiler whining that label 'loop126' has no statements

                    	PushFollow(FOLLOW_newExpression_in_newExpression1341);
                    	newExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 46, newExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "newExpression"


    // $ANTLR start "memberExpression"
    // JavaScript.g:329:1: memberExpression : ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments ) ( ( LT )* memberExpressionSuffix )* ;
    public void memberExpression() // throws RecognitionException [1]
    {   
        int memberExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 47) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:330:2: ( ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments ) ( ( LT )* memberExpressionSuffix )* )
            // JavaScript.g:330:4: ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments ) ( ( LT )* memberExpressionSuffix )*
            {
            	// JavaScript.g:330:4: ( primaryExpression | functionExpression | 'new' ( LT )* memberExpression ( LT )* arguments )
            	int alt130 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case Identifier:
            	case StringLiteral:
            	case NumericLiteral:
            	case 30:
            	case 33:
            	case 57:
            	case 101:
            	case 102:
            	case 103:
            	case 104:
            		{
            	    alt130 = 1;
            	    }
            	    break;
            	case 29:
            		{
            	    alt130 = 2;
            	    }
            	    break;
            	case 56:
            		{
            	    alt130 = 3;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		    NoViableAltException nvae_d130s0 =
            		        new NoViableAltException("", 130, 0, input);

            		    throw nvae_d130s0;
            	}

            	switch (alt130) 
            	{
            	    case 1 :
            	        // JavaScript.g:330:5: primaryExpression
            	        {
            	        	PushFollow(FOLLOW_primaryExpression_in_memberExpression1354);
            	        	primaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:330:25: functionExpression
            	        {
            	        	PushFollow(FOLLOW_functionExpression_in_memberExpression1358);
            	        	functionExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;
            	    case 3 :
            	        // JavaScript.g:330:46: 'new' ( LT )* memberExpression ( LT )* arguments
            	        {
            	        	Match(input,56,FOLLOW_56_in_memberExpression1362); if (state.failed) return ;
            	        	// JavaScript.g:330:52: ( LT )*
            	        	do 
            	        	{
            	        	    int alt128 = 2;
            	        	    int LA128_0 = input.LA(1);

            	        	    if ( (LA128_0 == LT) )
            	        	    {
            	        	        alt128 = 1;
            	        	    }


            	        	    switch (alt128) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_memberExpression1364); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop128;
            	        	    }
            	        	} while (true);

            	        	loop128:
            	        		;	// Stops C# compiler whining that label 'loop128' has no statements

            	        	PushFollow(FOLLOW_memberExpression_in_memberExpression1367);
            	        	memberExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	// JavaScript.g:330:73: ( LT )*
            	        	do 
            	        	{
            	        	    int alt129 = 2;
            	        	    int LA129_0 = input.LA(1);

            	        	    if ( (LA129_0 == LT) )
            	        	    {
            	        	        alt129 = 1;
            	        	    }


            	        	    switch (alt129) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_memberExpression1369); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop129;
            	        	    }
            	        	} while (true);

            	        	loop129:
            	        		;	// Stops C# compiler whining that label 'loop129' has no statements

            	        	PushFollow(FOLLOW_arguments_in_memberExpression1372);
            	        	arguments();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:330:88: ( ( LT )* memberExpressionSuffix )*
            	do 
            	{
            	    int alt132 = 2;
            	    alt132 = dfa132.Predict(input);
            	    switch (alt132) 
            		{
            			case 1 :
            			    // JavaScript.g:330:89: ( LT )* memberExpressionSuffix
            			    {
            			    	// JavaScript.g:330:89: ( LT )*
            			    	do 
            			    	{
            			    	    int alt131 = 2;
            			    	    int LA131_0 = input.LA(1);

            			    	    if ( (LA131_0 == LT) )
            			    	    {
            			    	        alt131 = 1;
            			    	    }


            			    	    switch (alt131) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_memberExpression1376); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop131;
            			    	    }
            			    	} while (true);

            			    	loop131:
            			    		;	// Stops C# compiler whining that label 'loop131' has no statements

            			    	PushFollow(FOLLOW_memberExpressionSuffix_in_memberExpression1379);
            			    	memberExpressionSuffix();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop132;
            	    }
            	} while (true);

            	loop132:
            		;	// Stops C# compiler whining that label 'loop132' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 47, memberExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "memberExpression"


    // $ANTLR start "memberExpressionSuffix"
    // JavaScript.g:333:1: memberExpressionSuffix : ( indexSuffix | propertyReferenceSuffix );
    public void memberExpressionSuffix() // throws RecognitionException [1]
    {   
        int memberExpressionSuffix_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 48) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:334:2: ( indexSuffix | propertyReferenceSuffix )
            int alt133 = 2;
            int LA133_0 = input.LA(1);

            if ( (LA133_0 == 57) )
            {
                alt133 = 1;
            }
            else if ( (LA133_0 == 59) )
            {
                alt133 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d133s0 =
                    new NoViableAltException("", 133, 0, input);

                throw nvae_d133s0;
            }
            switch (alt133) 
            {
                case 1 :
                    // JavaScript.g:334:4: indexSuffix
                    {
                    	PushFollow(FOLLOW_indexSuffix_in_memberExpressionSuffix1393);
                    	indexSuffix();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:335:4: propertyReferenceSuffix
                    {
                    	PushFollow(FOLLOW_propertyReferenceSuffix_in_memberExpressionSuffix1398);
                    	propertyReferenceSuffix();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 48, memberExpressionSuffix_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "memberExpressionSuffix"


    // $ANTLR start "callExpression"
    // JavaScript.g:338:1: callExpression : memberExpression ( LT )* arguments ( ( LT )* callExpressionSuffix )* ;
    public void callExpression() // throws RecognitionException [1]
    {   
        int callExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 49) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:339:2: ( memberExpression ( LT )* arguments ( ( LT )* callExpressionSuffix )* )
            // JavaScript.g:339:4: memberExpression ( LT )* arguments ( ( LT )* callExpressionSuffix )*
            {
            	PushFollow(FOLLOW_memberExpression_in_callExpression1409);
            	memberExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:339:21: ( LT )*
            	do 
            	{
            	    int alt134 = 2;
            	    int LA134_0 = input.LA(1);

            	    if ( (LA134_0 == LT) )
            	    {
            	        alt134 = 1;
            	    }


            	    switch (alt134) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_callExpression1411); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop134;
            	    }
            	} while (true);

            	loop134:
            		;	// Stops C# compiler whining that label 'loop134' has no statements

            	PushFollow(FOLLOW_arguments_in_callExpression1414);
            	arguments();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:339:35: ( ( LT )* callExpressionSuffix )*
            	do 
            	{
            	    int alt136 = 2;
            	    alt136 = dfa136.Predict(input);
            	    switch (alt136) 
            		{
            			case 1 :
            			    // JavaScript.g:339:36: ( LT )* callExpressionSuffix
            			    {
            			    	// JavaScript.g:339:36: ( LT )*
            			    	do 
            			    	{
            			    	    int alt135 = 2;
            			    	    int LA135_0 = input.LA(1);

            			    	    if ( (LA135_0 == LT) )
            			    	    {
            			    	        alt135 = 1;
            			    	    }


            			    	    switch (alt135) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_callExpression1417); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop135;
            			    	    }
            			    	} while (true);

            			    	loop135:
            			    		;	// Stops C# compiler whining that label 'loop135' has no statements

            			    	PushFollow(FOLLOW_callExpressionSuffix_in_callExpression1420);
            			    	callExpressionSuffix();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop136;
            	    }
            	} while (true);

            	loop136:
            		;	// Stops C# compiler whining that label 'loop136' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 49, callExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "callExpression"


    // $ANTLR start "callExpressionSuffix"
    // JavaScript.g:342:1: callExpressionSuffix : ( arguments | indexSuffix | propertyReferenceSuffix );
    public void callExpressionSuffix() // throws RecognitionException [1]
    {   
        int callExpressionSuffix_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 50) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:343:2: ( arguments | indexSuffix | propertyReferenceSuffix )
            int alt137 = 3;
            switch ( input.LA(1) ) 
            {
            case 30:
            	{
                alt137 = 1;
                }
                break;
            case 57:
            	{
                alt137 = 2;
                }
                break;
            case 59:
            	{
                alt137 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d137s0 =
            	        new NoViableAltException("", 137, 0, input);

            	    throw nvae_d137s0;
            }

            switch (alt137) 
            {
                case 1 :
                    // JavaScript.g:343:4: arguments
                    {
                    	PushFollow(FOLLOW_arguments_in_callExpressionSuffix1434);
                    	arguments();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:344:4: indexSuffix
                    {
                    	PushFollow(FOLLOW_indexSuffix_in_callExpressionSuffix1439);
                    	indexSuffix();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // JavaScript.g:345:4: propertyReferenceSuffix
                    {
                    	PushFollow(FOLLOW_propertyReferenceSuffix_in_callExpressionSuffix1444);
                    	propertyReferenceSuffix();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 50, callExpressionSuffix_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "callExpressionSuffix"


    // $ANTLR start "arguments"
    // JavaScript.g:348:1: arguments : '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        int arguments_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 51) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:349:2: ( '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')' )
            // JavaScript.g:349:4: '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')'
            {
            	Match(input,30,FOLLOW_30_in_arguments1455); if (state.failed) return ;
            	// JavaScript.g:349:8: ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )?
            	int alt142 = 2;
            	alt142 = dfa142.Predict(input);
            	switch (alt142) 
            	{
            	    case 1 :
            	        // JavaScript.g:349:9: ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )*
            	        {
            	        	// JavaScript.g:349:9: ( LT )*
            	        	do 
            	        	{
            	        	    int alt138 = 2;
            	        	    int LA138_0 = input.LA(1);

            	        	    if ( (LA138_0 == LT) )
            	        	    {
            	        	        alt138 = 1;
            	        	    }


            	        	    switch (alt138) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_arguments1458); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop138;
            	        	    }
            	        	} while (true);

            	        	loop138:
            	        		;	// Stops C# compiler whining that label 'loop138' has no statements

            	        	PushFollow(FOLLOW_assignmentExpression_in_arguments1461);
            	        	assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	// JavaScript.g:349:34: ( ( LT )* ',' ( LT )* assignmentExpression )*
            	        	do 
            	        	{
            	        	    int alt141 = 2;
            	        	    alt141 = dfa141.Predict(input);
            	        	    switch (alt141) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:349:35: ( LT )* ',' ( LT )* assignmentExpression
            	        			    {
            	        			    	// JavaScript.g:349:35: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt139 = 2;
            	        			    	    int LA139_0 = input.LA(1);

            	        			    	    if ( (LA139_0 == LT) )
            	        			    	    {
            	        			    	        alt139 = 1;
            	        			    	    }


            	        			    	    switch (alt139) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:0:0: LT
            	        			    			    {
            	        			    			    	Match(input,LT,FOLLOW_LT_in_arguments1464); if (state.failed) return ;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop139;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop139:
            	        			    		;	// Stops C# compiler whining that label 'loop139' has no statements

            	        			    	Match(input,31,FOLLOW_31_in_arguments1467); if (state.failed) return ;
            	        			    	// JavaScript.g:349:43: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt140 = 2;
            	        			    	    int LA140_0 = input.LA(1);

            	        			    	    if ( (LA140_0 == LT) )
            	        			    	    {
            	        			    	        alt140 = 1;
            	        			    	    }


            	        			    	    switch (alt140) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:0:0: LT
            	        			    			    {
            	        			    			    	Match(input,LT,FOLLOW_LT_in_arguments1469); if (state.failed) return ;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop140;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop140:
            	        			    		;	// Stops C# compiler whining that label 'loop140' has no statements

            	        			    	PushFollow(FOLLOW_assignmentExpression_in_arguments1472);
            	        			    	assignmentExpression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop141;
            	        	    }
            	        	} while (true);

            	        	loop141:
            	        		;	// Stops C# compiler whining that label 'loop141' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:349:72: ( LT )*
            	do 
            	{
            	    int alt143 = 2;
            	    int LA143_0 = input.LA(1);

            	    if ( (LA143_0 == LT) )
            	    {
            	        alt143 = 1;
            	    }


            	    switch (alt143) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_arguments1478); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop143;
            	    }
            	} while (true);

            	loop143:
            		;	// Stops C# compiler whining that label 'loop143' has no statements

            	Match(input,32,FOLLOW_32_in_arguments1481); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 51, arguments_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "arguments"


    // $ANTLR start "indexSuffix"
    // JavaScript.g:352:1: indexSuffix : '[' ( LT )* expression ( LT )* ']' ;
    public void indexSuffix() // throws RecognitionException [1]
    {   
        int indexSuffix_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 52) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:353:2: ( '[' ( LT )* expression ( LT )* ']' )
            // JavaScript.g:353:4: '[' ( LT )* expression ( LT )* ']'
            {
            	Match(input,57,FOLLOW_57_in_indexSuffix1493); if (state.failed) return ;
            	// JavaScript.g:353:8: ( LT )*
            	do 
            	{
            	    int alt144 = 2;
            	    int LA144_0 = input.LA(1);

            	    if ( (LA144_0 == LT) )
            	    {
            	        alt144 = 1;
            	    }


            	    switch (alt144) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_indexSuffix1495); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop144;
            	    }
            	} while (true);

            	loop144:
            		;	// Stops C# compiler whining that label 'loop144' has no statements

            	PushFollow(FOLLOW_expression_in_indexSuffix1498);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:353:23: ( LT )*
            	do 
            	{
            	    int alt145 = 2;
            	    int LA145_0 = input.LA(1);

            	    if ( (LA145_0 == LT) )
            	    {
            	        alt145 = 1;
            	    }


            	    switch (alt145) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_indexSuffix1500); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop145;
            	    }
            	} while (true);

            	loop145:
            		;	// Stops C# compiler whining that label 'loop145' has no statements

            	Match(input,58,FOLLOW_58_in_indexSuffix1503); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 52, indexSuffix_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "indexSuffix"


    // $ANTLR start "propertyReferenceSuffix"
    // JavaScript.g:356:1: propertyReferenceSuffix : '.' ( LT )* Identifier ;
    public void propertyReferenceSuffix() // throws RecognitionException [1]
    {   
        int propertyReferenceSuffix_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 53) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:357:2: ( '.' ( LT )* Identifier )
            // JavaScript.g:357:4: '.' ( LT )* Identifier
            {
            	Match(input,59,FOLLOW_59_in_propertyReferenceSuffix1516); if (state.failed) return ;
            	// JavaScript.g:357:8: ( LT )*
            	do 
            	{
            	    int alt146 = 2;
            	    int LA146_0 = input.LA(1);

            	    if ( (LA146_0 == LT) )
            	    {
            	        alt146 = 1;
            	    }


            	    switch (alt146) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_propertyReferenceSuffix1518); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop146;
            	    }
            	} while (true);

            	loop146:
            		;	// Stops C# compiler whining that label 'loop146' has no statements

            	Match(input,Identifier,FOLLOW_Identifier_in_propertyReferenceSuffix1521); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 53, propertyReferenceSuffix_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "propertyReferenceSuffix"


    // $ANTLR start "assignmentOperator"
    // JavaScript.g:360:1: assignmentOperator : ( '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|=' );
    public void assignmentOperator() // throws RecognitionException [1]
    {   
        int assignmentOperator_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 54) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:361:2: ( '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|=' )
            // JavaScript.g:
            {
            	if ( input.LA(1) == 37 || (input.LA(1) >= 60 && input.LA(1) <= 70) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 54, assignmentOperator_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "assignmentOperator"


    // $ANTLR start "conditionalExpression"
    // JavaScript.g:364:1: conditionalExpression : logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )? ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        int conditionalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 55) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:365:2: ( logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )? )
            // JavaScript.g:365:4: logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?
            {
            	PushFollow(FOLLOW_logicalORExpression_in_conditionalExpression1588);
            	logicalORExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:365:24: ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?
            	int alt151 = 2;
            	alt151 = dfa151.Predict(input);
            	switch (alt151) 
            	{
            	    case 1 :
            	        // JavaScript.g:365:25: ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression
            	        {
            	        	// JavaScript.g:365:25: ( LT )*
            	        	do 
            	        	{
            	        	    int alt147 = 2;
            	        	    int LA147_0 = input.LA(1);

            	        	    if ( (LA147_0 == LT) )
            	        	    {
            	        	        alt147 = 1;
            	        	    }


            	        	    switch (alt147) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpression1591); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop147;
            	        	    }
            	        	} while (true);

            	        	loop147:
            	        		;	// Stops C# compiler whining that label 'loop147' has no statements

            	        	Match(input,71,FOLLOW_71_in_conditionalExpression1594); if (state.failed) return ;
            	        	// JavaScript.g:365:33: ( LT )*
            	        	do 
            	        	{
            	        	    int alt148 = 2;
            	        	    int LA148_0 = input.LA(1);

            	        	    if ( (LA148_0 == LT) )
            	        	    {
            	        	        alt148 = 1;
            	        	    }


            	        	    switch (alt148) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpression1596); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop148;
            	        	    }
            	        	} while (true);

            	        	loop148:
            	        		;	// Stops C# compiler whining that label 'loop148' has no statements

            	        	PushFollow(FOLLOW_assignmentExpression_in_conditionalExpression1599);
            	        	assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	// JavaScript.g:365:58: ( LT )*
            	        	do 
            	        	{
            	        	    int alt149 = 2;
            	        	    int LA149_0 = input.LA(1);

            	        	    if ( (LA149_0 == LT) )
            	        	    {
            	        	        alt149 = 1;
            	        	    }


            	        	    switch (alt149) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpression1601); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop149;
            	        	    }
            	        	} while (true);

            	        	loop149:
            	        		;	// Stops C# compiler whining that label 'loop149' has no statements

            	        	Match(input,48,FOLLOW_48_in_conditionalExpression1604); if (state.failed) return ;
            	        	// JavaScript.g:365:66: ( LT )*
            	        	do 
            	        	{
            	        	    int alt150 = 2;
            	        	    int LA150_0 = input.LA(1);

            	        	    if ( (LA150_0 == LT) )
            	        	    {
            	        	        alt150 = 1;
            	        	    }


            	        	    switch (alt150) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpression1606); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop150;
            	        	    }
            	        	} while (true);

            	        	loop150:
            	        		;	// Stops C# compiler whining that label 'loop150' has no statements

            	        	PushFollow(FOLLOW_assignmentExpression_in_conditionalExpression1609);
            	        	assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 55, conditionalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalExpression"


    // $ANTLR start "conditionalExpressionNoIn"
    // JavaScript.g:368:1: conditionalExpressionNoIn : logicalORExpressionNoIn ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )? ;
    public void conditionalExpressionNoIn() // throws RecognitionException [1]
    {   
        int conditionalExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 56) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:369:2: ( logicalORExpressionNoIn ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )? )
            // JavaScript.g:369:4: logicalORExpressionNoIn ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )?
            {
            	PushFollow(FOLLOW_logicalORExpressionNoIn_in_conditionalExpressionNoIn1622);
            	logicalORExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:369:28: ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )?
            	int alt156 = 2;
            	alt156 = dfa156.Predict(input);
            	switch (alt156) 
            	{
            	    case 1 :
            	        // JavaScript.g:369:29: ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn
            	        {
            	        	// JavaScript.g:369:29: ( LT )*
            	        	do 
            	        	{
            	        	    int alt152 = 2;
            	        	    int LA152_0 = input.LA(1);

            	        	    if ( (LA152_0 == LT) )
            	        	    {
            	        	        alt152 = 1;
            	        	    }


            	        	    switch (alt152) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpressionNoIn1625); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop152;
            	        	    }
            	        	} while (true);

            	        	loop152:
            	        		;	// Stops C# compiler whining that label 'loop152' has no statements

            	        	Match(input,71,FOLLOW_71_in_conditionalExpressionNoIn1628); if (state.failed) return ;
            	        	// JavaScript.g:369:37: ( LT )*
            	        	do 
            	        	{
            	        	    int alt153 = 2;
            	        	    int LA153_0 = input.LA(1);

            	        	    if ( (LA153_0 == LT) )
            	        	    {
            	        	        alt153 = 1;
            	        	    }


            	        	    switch (alt153) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpressionNoIn1630); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop153;
            	        	    }
            	        	} while (true);

            	        	loop153:
            	        		;	// Stops C# compiler whining that label 'loop153' has no statements

            	        	PushFollow(FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn1633);
            	        	assignmentExpressionNoIn();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	// JavaScript.g:369:66: ( LT )*
            	        	do 
            	        	{
            	        	    int alt154 = 2;
            	        	    int LA154_0 = input.LA(1);

            	        	    if ( (LA154_0 == LT) )
            	        	    {
            	        	        alt154 = 1;
            	        	    }


            	        	    switch (alt154) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpressionNoIn1635); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop154;
            	        	    }
            	        	} while (true);

            	        	loop154:
            	        		;	// Stops C# compiler whining that label 'loop154' has no statements

            	        	Match(input,48,FOLLOW_48_in_conditionalExpressionNoIn1638); if (state.failed) return ;
            	        	// JavaScript.g:369:74: ( LT )*
            	        	do 
            	        	{
            	        	    int alt155 = 2;
            	        	    int LA155_0 = input.LA(1);

            	        	    if ( (LA155_0 == LT) )
            	        	    {
            	        	        alt155 = 1;
            	        	    }


            	        	    switch (alt155) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:0:0: LT
            	        			    {
            	        			    	Match(input,LT,FOLLOW_LT_in_conditionalExpressionNoIn1640); if (state.failed) return ;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop155;
            	        	    }
            	        	} while (true);

            	        	loop155:
            	        		;	// Stops C# compiler whining that label 'loop155' has no statements

            	        	PushFollow(FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn1643);
            	        	assignmentExpressionNoIn();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 56, conditionalExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalExpressionNoIn"


    // $ANTLR start "logicalORExpression"
    // JavaScript.g:372:1: logicalORExpression : logicalANDExpression ( ( LT )* '||' ( LT )* logicalANDExpression )* ;
    public void logicalORExpression() // throws RecognitionException [1]
    {   
        int logicalORExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 57) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:373:2: ( logicalANDExpression ( ( LT )* '||' ( LT )* logicalANDExpression )* )
            // JavaScript.g:373:4: logicalANDExpression ( ( LT )* '||' ( LT )* logicalANDExpression )*
            {
            	PushFollow(FOLLOW_logicalANDExpression_in_logicalORExpression1656);
            	logicalANDExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:373:25: ( ( LT )* '||' ( LT )* logicalANDExpression )*
            	do 
            	{
            	    int alt159 = 2;
            	    alt159 = dfa159.Predict(input);
            	    switch (alt159) 
            		{
            			case 1 :
            			    // JavaScript.g:373:26: ( LT )* '||' ( LT )* logicalANDExpression
            			    {
            			    	// JavaScript.g:373:26: ( LT )*
            			    	do 
            			    	{
            			    	    int alt157 = 2;
            			    	    int LA157_0 = input.LA(1);

            			    	    if ( (LA157_0 == LT) )
            			    	    {
            			    	        alt157 = 1;
            			    	    }


            			    	    switch (alt157) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalORExpression1659); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop157;
            			    	    }
            			    	} while (true);

            			    	loop157:
            			    		;	// Stops C# compiler whining that label 'loop157' has no statements

            			    	Match(input,72,FOLLOW_72_in_logicalORExpression1662); if (state.failed) return ;
            			    	// JavaScript.g:373:35: ( LT )*
            			    	do 
            			    	{
            			    	    int alt158 = 2;
            			    	    int LA158_0 = input.LA(1);

            			    	    if ( (LA158_0 == LT) )
            			    	    {
            			    	        alt158 = 1;
            			    	    }


            			    	    switch (alt158) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalORExpression1664); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop158;
            			    	    }
            			    	} while (true);

            			    	loop158:
            			    		;	// Stops C# compiler whining that label 'loop158' has no statements

            			    	PushFollow(FOLLOW_logicalANDExpression_in_logicalORExpression1667);
            			    	logicalANDExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop159;
            	    }
            	} while (true);

            	loop159:
            		;	// Stops C# compiler whining that label 'loop159' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 57, logicalORExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "logicalORExpression"


    // $ANTLR start "logicalORExpressionNoIn"
    // JavaScript.g:376:1: logicalORExpressionNoIn : logicalANDExpressionNoIn ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )* ;
    public void logicalORExpressionNoIn() // throws RecognitionException [1]
    {   
        int logicalORExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 58) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:377:2: ( logicalANDExpressionNoIn ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )* )
            // JavaScript.g:377:4: logicalANDExpressionNoIn ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )*
            {
            	PushFollow(FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn1681);
            	logicalANDExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:377:29: ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )*
            	do 
            	{
            	    int alt162 = 2;
            	    alt162 = dfa162.Predict(input);
            	    switch (alt162) 
            		{
            			case 1 :
            			    // JavaScript.g:377:30: ( LT )* '||' ( LT )* logicalANDExpressionNoIn
            			    {
            			    	// JavaScript.g:377:30: ( LT )*
            			    	do 
            			    	{
            			    	    int alt160 = 2;
            			    	    int LA160_0 = input.LA(1);

            			    	    if ( (LA160_0 == LT) )
            			    	    {
            			    	        alt160 = 1;
            			    	    }


            			    	    switch (alt160) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalORExpressionNoIn1684); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop160;
            			    	    }
            			    	} while (true);

            			    	loop160:
            			    		;	// Stops C# compiler whining that label 'loop160' has no statements

            			    	Match(input,72,FOLLOW_72_in_logicalORExpressionNoIn1687); if (state.failed) return ;
            			    	// JavaScript.g:377:39: ( LT )*
            			    	do 
            			    	{
            			    	    int alt161 = 2;
            			    	    int LA161_0 = input.LA(1);

            			    	    if ( (LA161_0 == LT) )
            			    	    {
            			    	        alt161 = 1;
            			    	    }


            			    	    switch (alt161) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalORExpressionNoIn1689); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop161;
            			    	    }
            			    	} while (true);

            			    	loop161:
            			    		;	// Stops C# compiler whining that label 'loop161' has no statements

            			    	PushFollow(FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn1692);
            			    	logicalANDExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop162;
            	    }
            	} while (true);

            	loop162:
            		;	// Stops C# compiler whining that label 'loop162' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 58, logicalORExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "logicalORExpressionNoIn"


    // $ANTLR start "logicalANDExpression"
    // JavaScript.g:380:1: logicalANDExpression : bitwiseORExpression ( ( LT )* '&&' ( LT )* bitwiseORExpression )* ;
    public void logicalANDExpression() // throws RecognitionException [1]
    {   
        int logicalANDExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 59) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:381:2: ( bitwiseORExpression ( ( LT )* '&&' ( LT )* bitwiseORExpression )* )
            // JavaScript.g:381:4: bitwiseORExpression ( ( LT )* '&&' ( LT )* bitwiseORExpression )*
            {
            	PushFollow(FOLLOW_bitwiseORExpression_in_logicalANDExpression1706);
            	bitwiseORExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:381:24: ( ( LT )* '&&' ( LT )* bitwiseORExpression )*
            	do 
            	{
            	    int alt165 = 2;
            	    alt165 = dfa165.Predict(input);
            	    switch (alt165) 
            		{
            			case 1 :
            			    // JavaScript.g:381:25: ( LT )* '&&' ( LT )* bitwiseORExpression
            			    {
            			    	// JavaScript.g:381:25: ( LT )*
            			    	do 
            			    	{
            			    	    int alt163 = 2;
            			    	    int LA163_0 = input.LA(1);

            			    	    if ( (LA163_0 == LT) )
            			    	    {
            			    	        alt163 = 1;
            			    	    }


            			    	    switch (alt163) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalANDExpression1709); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop163;
            			    	    }
            			    	} while (true);

            			    	loop163:
            			    		;	// Stops C# compiler whining that label 'loop163' has no statements

            			    	Match(input,73,FOLLOW_73_in_logicalANDExpression1712); if (state.failed) return ;
            			    	// JavaScript.g:381:34: ( LT )*
            			    	do 
            			    	{
            			    	    int alt164 = 2;
            			    	    int LA164_0 = input.LA(1);

            			    	    if ( (LA164_0 == LT) )
            			    	    {
            			    	        alt164 = 1;
            			    	    }


            			    	    switch (alt164) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalANDExpression1714); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop164;
            			    	    }
            			    	} while (true);

            			    	loop164:
            			    		;	// Stops C# compiler whining that label 'loop164' has no statements

            			    	PushFollow(FOLLOW_bitwiseORExpression_in_logicalANDExpression1717);
            			    	bitwiseORExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop165;
            	    }
            	} while (true);

            	loop165:
            		;	// Stops C# compiler whining that label 'loop165' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 59, logicalANDExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "logicalANDExpression"


    // $ANTLR start "logicalANDExpressionNoIn"
    // JavaScript.g:384:1: logicalANDExpressionNoIn : bitwiseORExpressionNoIn ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )* ;
    public void logicalANDExpressionNoIn() // throws RecognitionException [1]
    {   
        int logicalANDExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 60) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:385:2: ( bitwiseORExpressionNoIn ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )* )
            // JavaScript.g:385:4: bitwiseORExpressionNoIn ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )*
            {
            	PushFollow(FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1731);
            	bitwiseORExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:385:28: ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )*
            	do 
            	{
            	    int alt168 = 2;
            	    alt168 = dfa168.Predict(input);
            	    switch (alt168) 
            		{
            			case 1 :
            			    // JavaScript.g:385:29: ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn
            			    {
            			    	// JavaScript.g:385:29: ( LT )*
            			    	do 
            			    	{
            			    	    int alt166 = 2;
            			    	    int LA166_0 = input.LA(1);

            			    	    if ( (LA166_0 == LT) )
            			    	    {
            			    	        alt166 = 1;
            			    	    }


            			    	    switch (alt166) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalANDExpressionNoIn1734); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop166;
            			    	    }
            			    	} while (true);

            			    	loop166:
            			    		;	// Stops C# compiler whining that label 'loop166' has no statements

            			    	Match(input,73,FOLLOW_73_in_logicalANDExpressionNoIn1737); if (state.failed) return ;
            			    	// JavaScript.g:385:38: ( LT )*
            			    	do 
            			    	{
            			    	    int alt167 = 2;
            			    	    int LA167_0 = input.LA(1);

            			    	    if ( (LA167_0 == LT) )
            			    	    {
            			    	        alt167 = 1;
            			    	    }


            			    	    switch (alt167) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_logicalANDExpressionNoIn1739); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop167;
            			    	    }
            			    	} while (true);

            			    	loop167:
            			    		;	// Stops C# compiler whining that label 'loop167' has no statements

            			    	PushFollow(FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1742);
            			    	bitwiseORExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop168;
            	    }
            	} while (true);

            	loop168:
            		;	// Stops C# compiler whining that label 'loop168' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 60, logicalANDExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "logicalANDExpressionNoIn"


    // $ANTLR start "bitwiseORExpression"
    // JavaScript.g:388:1: bitwiseORExpression : bitwiseXORExpression ( ( LT )* '|' ( LT )* bitwiseXORExpression )* ;
    public void bitwiseORExpression() // throws RecognitionException [1]
    {   
        int bitwiseORExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 61) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:389:2: ( bitwiseXORExpression ( ( LT )* '|' ( LT )* bitwiseXORExpression )* )
            // JavaScript.g:389:4: bitwiseXORExpression ( ( LT )* '|' ( LT )* bitwiseXORExpression )*
            {
            	PushFollow(FOLLOW_bitwiseXORExpression_in_bitwiseORExpression1756);
            	bitwiseXORExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:389:25: ( ( LT )* '|' ( LT )* bitwiseXORExpression )*
            	do 
            	{
            	    int alt171 = 2;
            	    alt171 = dfa171.Predict(input);
            	    switch (alt171) 
            		{
            			case 1 :
            			    // JavaScript.g:389:26: ( LT )* '|' ( LT )* bitwiseXORExpression
            			    {
            			    	// JavaScript.g:389:26: ( LT )*
            			    	do 
            			    	{
            			    	    int alt169 = 2;
            			    	    int LA169_0 = input.LA(1);

            			    	    if ( (LA169_0 == LT) )
            			    	    {
            			    	        alt169 = 1;
            			    	    }


            			    	    switch (alt169) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseORExpression1759); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop169;
            			    	    }
            			    	} while (true);

            			    	loop169:
            			    		;	// Stops C# compiler whining that label 'loop169' has no statements

            			    	Match(input,74,FOLLOW_74_in_bitwiseORExpression1762); if (state.failed) return ;
            			    	// JavaScript.g:389:34: ( LT )*
            			    	do 
            			    	{
            			    	    int alt170 = 2;
            			    	    int LA170_0 = input.LA(1);

            			    	    if ( (LA170_0 == LT) )
            			    	    {
            			    	        alt170 = 1;
            			    	    }


            			    	    switch (alt170) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseORExpression1764); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop170;
            			    	    }
            			    	} while (true);

            			    	loop170:
            			    		;	// Stops C# compiler whining that label 'loop170' has no statements

            			    	PushFollow(FOLLOW_bitwiseXORExpression_in_bitwiseORExpression1767);
            			    	bitwiseXORExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop171;
            	    }
            	} while (true);

            	loop171:
            		;	// Stops C# compiler whining that label 'loop171' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 61, bitwiseORExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "bitwiseORExpression"


    // $ANTLR start "bitwiseORExpressionNoIn"
    // JavaScript.g:392:1: bitwiseORExpressionNoIn : bitwiseXORExpressionNoIn ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )* ;
    public void bitwiseORExpressionNoIn() // throws RecognitionException [1]
    {   
        int bitwiseORExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 62) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:393:2: ( bitwiseXORExpressionNoIn ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )* )
            // JavaScript.g:393:4: bitwiseXORExpressionNoIn ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )*
            {
            	PushFollow(FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1781);
            	bitwiseXORExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:393:29: ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )*
            	do 
            	{
            	    int alt174 = 2;
            	    alt174 = dfa174.Predict(input);
            	    switch (alt174) 
            		{
            			case 1 :
            			    // JavaScript.g:393:30: ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn
            			    {
            			    	// JavaScript.g:393:30: ( LT )*
            			    	do 
            			    	{
            			    	    int alt172 = 2;
            			    	    int LA172_0 = input.LA(1);

            			    	    if ( (LA172_0 == LT) )
            			    	    {
            			    	        alt172 = 1;
            			    	    }


            			    	    switch (alt172) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseORExpressionNoIn1784); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop172;
            			    	    }
            			    	} while (true);

            			    	loop172:
            			    		;	// Stops C# compiler whining that label 'loop172' has no statements

            			    	Match(input,74,FOLLOW_74_in_bitwiseORExpressionNoIn1787); if (state.failed) return ;
            			    	// JavaScript.g:393:38: ( LT )*
            			    	do 
            			    	{
            			    	    int alt173 = 2;
            			    	    int LA173_0 = input.LA(1);

            			    	    if ( (LA173_0 == LT) )
            			    	    {
            			    	        alt173 = 1;
            			    	    }


            			    	    switch (alt173) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseORExpressionNoIn1789); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop173;
            			    	    }
            			    	} while (true);

            			    	loop173:
            			    		;	// Stops C# compiler whining that label 'loop173' has no statements

            			    	PushFollow(FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1792);
            			    	bitwiseXORExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop174;
            	    }
            	} while (true);

            	loop174:
            		;	// Stops C# compiler whining that label 'loop174' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 62, bitwiseORExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "bitwiseORExpressionNoIn"


    // $ANTLR start "bitwiseXORExpression"
    // JavaScript.g:396:1: bitwiseXORExpression : bitwiseANDExpression ( ( LT )* '^' ( LT )* bitwiseANDExpression )* ;
    public void bitwiseXORExpression() // throws RecognitionException [1]
    {   
        int bitwiseXORExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 63) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:397:2: ( bitwiseANDExpression ( ( LT )* '^' ( LT )* bitwiseANDExpression )* )
            // JavaScript.g:397:4: bitwiseANDExpression ( ( LT )* '^' ( LT )* bitwiseANDExpression )*
            {
            	PushFollow(FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression1806);
            	bitwiseANDExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:397:25: ( ( LT )* '^' ( LT )* bitwiseANDExpression )*
            	do 
            	{
            	    int alt177 = 2;
            	    alt177 = dfa177.Predict(input);
            	    switch (alt177) 
            		{
            			case 1 :
            			    // JavaScript.g:397:26: ( LT )* '^' ( LT )* bitwiseANDExpression
            			    {
            			    	// JavaScript.g:397:26: ( LT )*
            			    	do 
            			    	{
            			    	    int alt175 = 2;
            			    	    int LA175_0 = input.LA(1);

            			    	    if ( (LA175_0 == LT) )
            			    	    {
            			    	        alt175 = 1;
            			    	    }


            			    	    switch (alt175) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseXORExpression1809); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop175;
            			    	    }
            			    	} while (true);

            			    	loop175:
            			    		;	// Stops C# compiler whining that label 'loop175' has no statements

            			    	Match(input,75,FOLLOW_75_in_bitwiseXORExpression1812); if (state.failed) return ;
            			    	// JavaScript.g:397:34: ( LT )*
            			    	do 
            			    	{
            			    	    int alt176 = 2;
            			    	    int LA176_0 = input.LA(1);

            			    	    if ( (LA176_0 == LT) )
            			    	    {
            			    	        alt176 = 1;
            			    	    }


            			    	    switch (alt176) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseXORExpression1814); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop176;
            			    	    }
            			    	} while (true);

            			    	loop176:
            			    		;	// Stops C# compiler whining that label 'loop176' has no statements

            			    	PushFollow(FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression1817);
            			    	bitwiseANDExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop177;
            	    }
            	} while (true);

            	loop177:
            		;	// Stops C# compiler whining that label 'loop177' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 63, bitwiseXORExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "bitwiseXORExpression"


    // $ANTLR start "bitwiseXORExpressionNoIn"
    // JavaScript.g:400:1: bitwiseXORExpressionNoIn : bitwiseANDExpressionNoIn ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )* ;
    public void bitwiseXORExpressionNoIn() // throws RecognitionException [1]
    {   
        int bitwiseXORExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 64) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:401:2: ( bitwiseANDExpressionNoIn ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )* )
            // JavaScript.g:401:4: bitwiseANDExpressionNoIn ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )*
            {
            	PushFollow(FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1831);
            	bitwiseANDExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:401:29: ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )*
            	do 
            	{
            	    int alt180 = 2;
            	    alt180 = dfa180.Predict(input);
            	    switch (alt180) 
            		{
            			case 1 :
            			    // JavaScript.g:401:30: ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn
            			    {
            			    	// JavaScript.g:401:30: ( LT )*
            			    	do 
            			    	{
            			    	    int alt178 = 2;
            			    	    int LA178_0 = input.LA(1);

            			    	    if ( (LA178_0 == LT) )
            			    	    {
            			    	        alt178 = 1;
            			    	    }


            			    	    switch (alt178) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseXORExpressionNoIn1834); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop178;
            			    	    }
            			    	} while (true);

            			    	loop178:
            			    		;	// Stops C# compiler whining that label 'loop178' has no statements

            			    	Match(input,75,FOLLOW_75_in_bitwiseXORExpressionNoIn1837); if (state.failed) return ;
            			    	// JavaScript.g:401:38: ( LT )*
            			    	do 
            			    	{
            			    	    int alt179 = 2;
            			    	    int LA179_0 = input.LA(1);

            			    	    if ( (LA179_0 == LT) )
            			    	    {
            			    	        alt179 = 1;
            			    	    }


            			    	    switch (alt179) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseXORExpressionNoIn1839); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop179;
            			    	    }
            			    	} while (true);

            			    	loop179:
            			    		;	// Stops C# compiler whining that label 'loop179' has no statements

            			    	PushFollow(FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1842);
            			    	bitwiseANDExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop180;
            	    }
            	} while (true);

            	loop180:
            		;	// Stops C# compiler whining that label 'loop180' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 64, bitwiseXORExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "bitwiseXORExpressionNoIn"


    // $ANTLR start "bitwiseANDExpression"
    // JavaScript.g:404:1: bitwiseANDExpression : equalityExpression ( ( LT )* '&' ( LT )* equalityExpression )* ;
    public void bitwiseANDExpression() // throws RecognitionException [1]
    {   
        int bitwiseANDExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 65) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:405:2: ( equalityExpression ( ( LT )* '&' ( LT )* equalityExpression )* )
            // JavaScript.g:405:4: equalityExpression ( ( LT )* '&' ( LT )* equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_bitwiseANDExpression1856);
            	equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:405:23: ( ( LT )* '&' ( LT )* equalityExpression )*
            	do 
            	{
            	    int alt183 = 2;
            	    alt183 = dfa183.Predict(input);
            	    switch (alt183) 
            		{
            			case 1 :
            			    // JavaScript.g:405:24: ( LT )* '&' ( LT )* equalityExpression
            			    {
            			    	// JavaScript.g:405:24: ( LT )*
            			    	do 
            			    	{
            			    	    int alt181 = 2;
            			    	    int LA181_0 = input.LA(1);

            			    	    if ( (LA181_0 == LT) )
            			    	    {
            			    	        alt181 = 1;
            			    	    }


            			    	    switch (alt181) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseANDExpression1859); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop181;
            			    	    }
            			    	} while (true);

            			    	loop181:
            			    		;	// Stops C# compiler whining that label 'loop181' has no statements

            			    	Match(input,76,FOLLOW_76_in_bitwiseANDExpression1862); if (state.failed) return ;
            			    	// JavaScript.g:405:32: ( LT )*
            			    	do 
            			    	{
            			    	    int alt182 = 2;
            			    	    int LA182_0 = input.LA(1);

            			    	    if ( (LA182_0 == LT) )
            			    	    {
            			    	        alt182 = 1;
            			    	    }


            			    	    switch (alt182) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseANDExpression1864); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop182;
            			    	    }
            			    	} while (true);

            			    	loop182:
            			    		;	// Stops C# compiler whining that label 'loop182' has no statements

            			    	PushFollow(FOLLOW_equalityExpression_in_bitwiseANDExpression1867);
            			    	equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop183;
            	    }
            	} while (true);

            	loop183:
            		;	// Stops C# compiler whining that label 'loop183' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 65, bitwiseANDExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "bitwiseANDExpression"


    // $ANTLR start "bitwiseANDExpressionNoIn"
    // JavaScript.g:408:1: bitwiseANDExpressionNoIn : equalityExpressionNoIn ( ( LT )* '&' ( LT )* equalityExpressionNoIn )* ;
    public void bitwiseANDExpressionNoIn() // throws RecognitionException [1]
    {   
        int bitwiseANDExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 66) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:409:2: ( equalityExpressionNoIn ( ( LT )* '&' ( LT )* equalityExpressionNoIn )* )
            // JavaScript.g:409:4: equalityExpressionNoIn ( ( LT )* '&' ( LT )* equalityExpressionNoIn )*
            {
            	PushFollow(FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1881);
            	equalityExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:409:27: ( ( LT )* '&' ( LT )* equalityExpressionNoIn )*
            	do 
            	{
            	    int alt186 = 2;
            	    alt186 = dfa186.Predict(input);
            	    switch (alt186) 
            		{
            			case 1 :
            			    // JavaScript.g:409:28: ( LT )* '&' ( LT )* equalityExpressionNoIn
            			    {
            			    	// JavaScript.g:409:28: ( LT )*
            			    	do 
            			    	{
            			    	    int alt184 = 2;
            			    	    int LA184_0 = input.LA(1);

            			    	    if ( (LA184_0 == LT) )
            			    	    {
            			    	        alt184 = 1;
            			    	    }


            			    	    switch (alt184) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseANDExpressionNoIn1884); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop184;
            			    	    }
            			    	} while (true);

            			    	loop184:
            			    		;	// Stops C# compiler whining that label 'loop184' has no statements

            			    	Match(input,76,FOLLOW_76_in_bitwiseANDExpressionNoIn1887); if (state.failed) return ;
            			    	// JavaScript.g:409:36: ( LT )*
            			    	do 
            			    	{
            			    	    int alt185 = 2;
            			    	    int LA185_0 = input.LA(1);

            			    	    if ( (LA185_0 == LT) )
            			    	    {
            			    	        alt185 = 1;
            			    	    }


            			    	    switch (alt185) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_bitwiseANDExpressionNoIn1889); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop185;
            			    	    }
            			    	} while (true);

            			    	loop185:
            			    		;	// Stops C# compiler whining that label 'loop185' has no statements

            			    	PushFollow(FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1892);
            			    	equalityExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop186;
            	    }
            	} while (true);

            	loop186:
            		;	// Stops C# compiler whining that label 'loop186' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 66, bitwiseANDExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "bitwiseANDExpressionNoIn"


    // $ANTLR start "equalityExpression"
    // JavaScript.g:412:1: equalityExpression : relationalExpression ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        int equalityExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 67) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:413:2: ( relationalExpression ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )* )
            // JavaScript.g:413:4: relationalExpression ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1906);
            	relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:413:25: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )*
            	do 
            	{
            	    int alt189 = 2;
            	    alt189 = dfa189.Predict(input);
            	    switch (alt189) 
            		{
            			case 1 :
            			    // JavaScript.g:413:26: ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression
            			    {
            			    	// JavaScript.g:413:26: ( LT )*
            			    	do 
            			    	{
            			    	    int alt187 = 2;
            			    	    int LA187_0 = input.LA(1);

            			    	    if ( (LA187_0 == LT) )
            			    	    {
            			    	        alt187 = 1;
            			    	    }


            			    	    switch (alt187) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_equalityExpression1909); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop187;
            			    	    }
            			    	} while (true);

            			    	loop187:
            			    		;	// Stops C# compiler whining that label 'loop187' has no statements

            			    	if ( (input.LA(1) >= 77 && input.LA(1) <= 80) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:413:60: ( LT )*
            			    	do 
            			    	{
            			    	    int alt188 = 2;
            			    	    int LA188_0 = input.LA(1);

            			    	    if ( (LA188_0 == LT) )
            			    	    {
            			    	        alt188 = 1;
            			    	    }


            			    	    switch (alt188) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_equalityExpression1928); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop188;
            			    	    }
            			    	} while (true);

            			    	loop188:
            			    		;	// Stops C# compiler whining that label 'loop188' has no statements

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1931);
            			    	relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop189;
            	    }
            	} while (true);

            	loop189:
            		;	// Stops C# compiler whining that label 'loop189' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 67, equalityExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "equalityExpression"


    // $ANTLR start "equalityExpressionNoIn"
    // JavaScript.g:416:1: equalityExpressionNoIn : relationalExpressionNoIn ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )* ;
    public void equalityExpressionNoIn() // throws RecognitionException [1]
    {   
        int equalityExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 68) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:417:2: ( relationalExpressionNoIn ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )* )
            // JavaScript.g:417:4: relationalExpressionNoIn ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )*
            {
            	PushFollow(FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn1944);
            	relationalExpressionNoIn();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:417:29: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )*
            	do 
            	{
            	    int alt192 = 2;
            	    alt192 = dfa192.Predict(input);
            	    switch (alt192) 
            		{
            			case 1 :
            			    // JavaScript.g:417:30: ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn
            			    {
            			    	// JavaScript.g:417:30: ( LT )*
            			    	do 
            			    	{
            			    	    int alt190 = 2;
            			    	    int LA190_0 = input.LA(1);

            			    	    if ( (LA190_0 == LT) )
            			    	    {
            			    	        alt190 = 1;
            			    	    }


            			    	    switch (alt190) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_equalityExpressionNoIn1947); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop190;
            			    	    }
            			    	} while (true);

            			    	loop190:
            			    		;	// Stops C# compiler whining that label 'loop190' has no statements

            			    	if ( (input.LA(1) >= 77 && input.LA(1) <= 80) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:417:64: ( LT )*
            			    	do 
            			    	{
            			    	    int alt191 = 2;
            			    	    int LA191_0 = input.LA(1);

            			    	    if ( (LA191_0 == LT) )
            			    	    {
            			    	        alt191 = 1;
            			    	    }


            			    	    switch (alt191) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_equalityExpressionNoIn1966); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop191;
            			    	    }
            			    	} while (true);

            			    	loop191:
            			    		;	// Stops C# compiler whining that label 'loop191' has no statements

            			    	PushFollow(FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn1969);
            			    	relationalExpressionNoIn();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop192;
            	    }
            	} while (true);

            	loop192:
            		;	// Stops C# compiler whining that label 'loop192' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 68, equalityExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "equalityExpressionNoIn"


    // $ANTLR start "relationalExpression"
    // JavaScript.g:420:1: relationalExpression : shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        int relationalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 69) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:421:2: ( shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )* )
            // JavaScript.g:421:4: shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )*
            {
            	PushFollow(FOLLOW_shiftExpression_in_relationalExpression1983);
            	shiftExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:421:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )*
            	do 
            	{
            	    int alt195 = 2;
            	    alt195 = dfa195.Predict(input);
            	    switch (alt195) 
            		{
            			case 1 :
            			    // JavaScript.g:421:21: ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression
            			    {
            			    	// JavaScript.g:421:21: ( LT )*
            			    	do 
            			    	{
            			    	    int alt193 = 2;
            			    	    int LA193_0 = input.LA(1);

            			    	    if ( (LA193_0 == LT) )
            			    	    {
            			    	        alt193 = 1;
            			    	    }


            			    	    switch (alt193) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_relationalExpression1986); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop193;
            			    	    }
            			    	} while (true);

            			    	loop193:
            			    		;	// Stops C# compiler whining that label 'loop193' has no statements

            			    	if ( input.LA(1) == 43 || (input.LA(1) >= 81 && input.LA(1) <= 85) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:421:73: ( LT )*
            			    	do 
            			    	{
            			    	    int alt194 = 2;
            			    	    int LA194_0 = input.LA(1);

            			    	    if ( (LA194_0 == LT) )
            			    	    {
            			    	        alt194 = 1;
            			    	    }


            			    	    switch (alt194) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_relationalExpression2013); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop194;
            			    	    }
            			    	} while (true);

            			    	loop194:
            			    		;	// Stops C# compiler whining that label 'loop194' has no statements

            			    	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2016);
            			    	shiftExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop195;
            	    }
            	} while (true);

            	loop195:
            		;	// Stops C# compiler whining that label 'loop195' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 69, relationalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "relationalExpression"


    // $ANTLR start "relationalExpressionNoIn"
    // JavaScript.g:424:1: relationalExpressionNoIn : shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )* ;
    public void relationalExpressionNoIn() // throws RecognitionException [1]
    {   
        int relationalExpressionNoIn_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 70) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:425:2: ( shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )* )
            // JavaScript.g:425:4: shiftExpression ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )*
            {
            	PushFollow(FOLLOW_shiftExpression_in_relationalExpressionNoIn2029);
            	shiftExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:425:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )*
            	do 
            	{
            	    int alt198 = 2;
            	    alt198 = dfa198.Predict(input);
            	    switch (alt198) 
            		{
            			case 1 :
            			    // JavaScript.g:425:21: ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression
            			    {
            			    	// JavaScript.g:425:21: ( LT )*
            			    	do 
            			    	{
            			    	    int alt196 = 2;
            			    	    int LA196_0 = input.LA(1);

            			    	    if ( (LA196_0 == LT) )
            			    	    {
            			    	        alt196 = 1;
            			    	    }


            			    	    switch (alt196) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_relationalExpressionNoIn2032); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop196;
            			    	    }
            			    	} while (true);

            			    	loop196:
            			    		;	// Stops C# compiler whining that label 'loop196' has no statements

            			    	if ( (input.LA(1) >= 81 && input.LA(1) <= 85) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:425:66: ( LT )*
            			    	do 
            			    	{
            			    	    int alt197 = 2;
            			    	    int LA197_0 = input.LA(1);

            			    	    if ( (LA197_0 == LT) )
            			    	    {
            			    	        alt197 = 1;
            			    	    }


            			    	    switch (alt197) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_relationalExpressionNoIn2055); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop197;
            			    	    }
            			    	} while (true);

            			    	loop197:
            			    		;	// Stops C# compiler whining that label 'loop197' has no statements

            			    	PushFollow(FOLLOW_shiftExpression_in_relationalExpressionNoIn2058);
            			    	shiftExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop198;
            	    }
            	} while (true);

            	loop198:
            		;	// Stops C# compiler whining that label 'loop198' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 70, relationalExpressionNoIn_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "relationalExpressionNoIn"


    // $ANTLR start "shiftExpression"
    // JavaScript.g:428:1: shiftExpression : additiveExpression ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )* ;
    public void shiftExpression() // throws RecognitionException [1]
    {   
        int shiftExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 71) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:429:2: ( additiveExpression ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )* )
            // JavaScript.g:429:4: additiveExpression ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_shiftExpression2071);
            	additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:429:23: ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )*
            	do 
            	{
            	    int alt201 = 2;
            	    alt201 = dfa201.Predict(input);
            	    switch (alt201) 
            		{
            			case 1 :
            			    // JavaScript.g:429:24: ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression
            			    {
            			    	// JavaScript.g:429:24: ( LT )*
            			    	do 
            			    	{
            			    	    int alt199 = 2;
            			    	    int LA199_0 = input.LA(1);

            			    	    if ( (LA199_0 == LT) )
            			    	    {
            			    	        alt199 = 1;
            			    	    }


            			    	    switch (alt199) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_shiftExpression2074); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop199;
            			    	    }
            			    	} while (true);

            			    	loop199:
            			    		;	// Stops C# compiler whining that label 'loop199' has no statements

            			    	if ( (input.LA(1) >= 86 && input.LA(1) <= 88) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:429:50: ( LT )*
            			    	do 
            			    	{
            			    	    int alt200 = 2;
            			    	    int LA200_0 = input.LA(1);

            			    	    if ( (LA200_0 == LT) )
            			    	    {
            			    	        alt200 = 1;
            			    	    }


            			    	    switch (alt200) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_shiftExpression2089); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop200;
            			    	    }
            			    	} while (true);

            			    	loop200:
            			    		;	// Stops C# compiler whining that label 'loop200' has no statements

            			    	PushFollow(FOLLOW_additiveExpression_in_shiftExpression2092);
            			    	additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop201;
            	    }
            	} while (true);

            	loop201:
            		;	// Stops C# compiler whining that label 'loop201' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 71, shiftExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "shiftExpression"


    // $ANTLR start "additiveExpression"
    // JavaScript.g:432:1: additiveExpression : multiplicativeExpression ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        int additiveExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 72) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:433:2: ( multiplicativeExpression ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )* )
            // JavaScript.g:433:4: multiplicativeExpression ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression2105);
            	multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:433:29: ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )*
            	do 
            	{
            	    int alt204 = 2;
            	    alt204 = dfa204.Predict(input);
            	    switch (alt204) 
            		{
            			case 1 :
            			    // JavaScript.g:433:30: ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression
            			    {
            			    	// JavaScript.g:433:30: ( LT )*
            			    	do 
            			    	{
            			    	    int alt202 = 2;
            			    	    int LA202_0 = input.LA(1);

            			    	    if ( (LA202_0 == LT) )
            			    	    {
            			    	        alt202 = 1;
            			    	    }


            			    	    switch (alt202) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_additiveExpression2108); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop202;
            			    	    }
            			    	} while (true);

            			    	loop202:
            			    		;	// Stops C# compiler whining that label 'loop202' has no statements

            			    	if ( (input.LA(1) >= 89 && input.LA(1) <= 90) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:433:46: ( LT )*
            			    	do 
            			    	{
            			    	    int alt203 = 2;
            			    	    int LA203_0 = input.LA(1);

            			    	    if ( (LA203_0 == LT) )
            			    	    {
            			    	        alt203 = 1;
            			    	    }


            			    	    switch (alt203) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_additiveExpression2119); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop203;
            			    	    }
            			    	} while (true);

            			    	loop203:
            			    		;	// Stops C# compiler whining that label 'loop203' has no statements

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression2122);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop204;
            	    }
            	} while (true);

            	loop204:
            		;	// Stops C# compiler whining that label 'loop204' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 72, additiveExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "additiveExpression"


    // $ANTLR start "multiplicativeExpression"
    // JavaScript.g:436:1: multiplicativeExpression : unaryExpression ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        int multiplicativeExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 73) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:437:2: ( unaryExpression ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )* )
            // JavaScript.g:437:4: unaryExpression ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )*
            {
            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression2135);
            	unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:437:20: ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )*
            	do 
            	{
            	    int alt207 = 2;
            	    alt207 = dfa207.Predict(input);
            	    switch (alt207) 
            		{
            			case 1 :
            			    // JavaScript.g:437:21: ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression
            			    {
            			    	// JavaScript.g:437:21: ( LT )*
            			    	do 
            			    	{
            			    	    int alt205 = 2;
            			    	    int LA205_0 = input.LA(1);

            			    	    if ( (LA205_0 == LT) )
            			    	    {
            			    	        alt205 = 1;
            			    	    }


            			    	    switch (alt205) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_multiplicativeExpression2138); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop205;
            			    	    }
            			    	} while (true);

            			    	loop205:
            			    		;	// Stops C# compiler whining that label 'loop205' has no statements

            			    	if ( (input.LA(1) >= 91 && input.LA(1) <= 93) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	// JavaScript.g:437:43: ( LT )*
            			    	do 
            			    	{
            			    	    int alt206 = 2;
            			    	    int LA206_0 = input.LA(1);

            			    	    if ( (LA206_0 == LT) )
            			    	    {
            			    	        alt206 = 1;
            			    	    }


            			    	    switch (alt206) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_multiplicativeExpression2153); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop206;
            			    	    }
            			    	} while (true);

            			    	loop206:
            			    		;	// Stops C# compiler whining that label 'loop206' has no statements

            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression2156);
            			    	unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop207;
            	    }
            	} while (true);

            	loop207:
            		;	// Stops C# compiler whining that label 'loop207' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 73, multiplicativeExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "multiplicativeExpression"


    // $ANTLR start "unaryExpression"
    // JavaScript.g:440:1: unaryExpression : ( postfixExpression | ( 'delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!' ) unaryExpression );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        int unaryExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 74) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:441:2: ( postfixExpression | ( 'delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!' ) unaryExpression )
            int alt208 = 2;
            int LA208_0 = input.LA(1);

            if ( ((LA208_0 >= Identifier && LA208_0 <= NumericLiteral) || (LA208_0 >= 29 && LA208_0 <= 30) || LA208_0 == 33 || (LA208_0 >= 56 && LA208_0 <= 57) || (LA208_0 >= 101 && LA208_0 <= 104)) )
            {
                alt208 = 1;
            }
            else if ( ((LA208_0 >= 89 && LA208_0 <= 90) || (LA208_0 >= 94 && LA208_0 <= 100)) )
            {
                alt208 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d208s0 =
                    new NoViableAltException("", 208, 0, input);

                throw nvae_d208s0;
            }
            switch (alt208) 
            {
                case 1 :
                    // JavaScript.g:441:4: postfixExpression
                    {
                    	PushFollow(FOLLOW_postfixExpression_in_unaryExpression2169);
                    	postfixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:442:4: ( 'delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!' ) unaryExpression
                    {
                    	if ( (input.LA(1) >= 89 && input.LA(1) <= 90) || (input.LA(1) >= 94 && input.LA(1) <= 100) ) 
                    	{
                    	    input.Consume();
                    	    state.errorRecovery = false;state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    throw mse;
                    	}

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2210);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 74, unaryExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "unaryExpression"


    // $ANTLR start "postfixExpression"
    // JavaScript.g:445:1: postfixExpression : leftHandSideExpression ( '++' | '--' )? ;
    public void postfixExpression() // throws RecognitionException [1]
    {   
        int postfixExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 75) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:446:2: ( leftHandSideExpression ( '++' | '--' )? )
            // JavaScript.g:446:4: leftHandSideExpression ( '++' | '--' )?
            {
            	PushFollow(FOLLOW_leftHandSideExpression_in_postfixExpression2222);
            	leftHandSideExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:446:27: ( '++' | '--' )?
            	int alt209 = 2;
            	int LA209_0 = input.LA(1);

            	if ( ((LA209_0 >= 97 && LA209_0 <= 98)) )
            	{
            	    alt209 = 1;
            	}
            	switch (alt209) 
            	{
            	    case 1 :
            	        // JavaScript.g:
            	        {
            	        	if ( (input.LA(1) >= 97 && input.LA(1) <= 98) ) 
            	        	{
            	        	    input.Consume();
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}


            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 75, postfixExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "postfixExpression"


    // $ANTLR start "primaryExpression"
    // JavaScript.g:449:1: primaryExpression : ( 'this' | Identifier | literal | arrayLiteral | objectLiteral | '(' ( LT )* expression ( LT )* ')' );
    public void primaryExpression() // throws RecognitionException [1]
    {   
        int primaryExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 76) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:450:2: ( 'this' | Identifier | literal | arrayLiteral | objectLiteral | '(' ( LT )* expression ( LT )* ')' )
            int alt212 = 6;
            switch ( input.LA(1) ) 
            {
            case 101:
            	{
                alt212 = 1;
                }
                break;
            case Identifier:
            	{
                alt212 = 2;
                }
                break;
            case StringLiteral:
            case NumericLiteral:
            case 102:
            case 103:
            case 104:
            	{
                alt212 = 3;
                }
                break;
            case 57:
            	{
                alt212 = 4;
                }
                break;
            case 33:
            	{
                alt212 = 5;
                }
                break;
            case 30:
            	{
                alt212 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d212s0 =
            	        new NoViableAltException("", 212, 0, input);

            	    throw nvae_d212s0;
            }

            switch (alt212) 
            {
                case 1 :
                    // JavaScript.g:450:4: 'this'
                    {
                    	Match(input,101,FOLLOW_101_in_primaryExpression2242); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:451:4: Identifier
                    {
                    	Match(input,Identifier,FOLLOW_Identifier_in_primaryExpression2247); if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // JavaScript.g:452:4: literal
                    {
                    	PushFollow(FOLLOW_literal_in_primaryExpression2252);
                    	literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 4 :
                    // JavaScript.g:453:4: arrayLiteral
                    {
                    	PushFollow(FOLLOW_arrayLiteral_in_primaryExpression2257);
                    	arrayLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 5 :
                    // JavaScript.g:454:4: objectLiteral
                    {
                    	PushFollow(FOLLOW_objectLiteral_in_primaryExpression2262);
                    	objectLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 6 :
                    // JavaScript.g:455:4: '(' ( LT )* expression ( LT )* ')'
                    {
                    	Match(input,30,FOLLOW_30_in_primaryExpression2267); if (state.failed) return ;
                    	// JavaScript.g:455:8: ( LT )*
                    	do 
                    	{
                    	    int alt210 = 2;
                    	    int LA210_0 = input.LA(1);

                    	    if ( (LA210_0 == LT) )
                    	    {
                    	        alt210 = 1;
                    	    }


                    	    switch (alt210) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_primaryExpression2269); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop210;
                    	    }
                    	} while (true);

                    	loop210:
                    		;	// Stops C# compiler whining that label 'loop210' has no statements

                    	PushFollow(FOLLOW_expression_in_primaryExpression2272);
                    	expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// JavaScript.g:455:23: ( LT )*
                    	do 
                    	{
                    	    int alt211 = 2;
                    	    int LA211_0 = input.LA(1);

                    	    if ( (LA211_0 == LT) )
                    	    {
                    	        alt211 = 1;
                    	    }


                    	    switch (alt211) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:0:0: LT
                    			    {
                    			    	Match(input,LT,FOLLOW_LT_in_primaryExpression2274); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop211;
                    	    }
                    	} while (true);

                    	loop211:
                    		;	// Stops C# compiler whining that label 'loop211' has no statements

                    	Match(input,32,FOLLOW_32_in_primaryExpression2277); if (state.failed) return ;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 76, primaryExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "primaryExpression"


    // $ANTLR start "arrayLiteral"
    // JavaScript.g:459:1: arrayLiteral : '[' ( LT )* ( assignmentExpression )? ( ( LT )* ',' ( ( LT )* assignmentExpression )? )* ( LT )* ']' ;
    public void arrayLiteral() // throws RecognitionException [1]
    {   
        int arrayLiteral_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 77) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:460:2: ( '[' ( LT )* ( assignmentExpression )? ( ( LT )* ',' ( ( LT )* assignmentExpression )? )* ( LT )* ']' )
            // JavaScript.g:460:4: '[' ( LT )* ( assignmentExpression )? ( ( LT )* ',' ( ( LT )* assignmentExpression )? )* ( LT )* ']'
            {
            	Match(input,57,FOLLOW_57_in_arrayLiteral2290); if (state.failed) return ;
            	// JavaScript.g:460:8: ( LT )*
            	do 
            	{
            	    int alt213 = 2;
            	    int LA213_0 = input.LA(1);

            	    if ( (LA213_0 == LT) )
            	    {
            	        int LA213_2 = input.LA(2);

            	        if ( (synpred280_JavaScript()) )
            	        {
            	            alt213 = 1;
            	        }


            	    }


            	    switch (alt213) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_arrayLiteral2292); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop213;
            	    }
            	} while (true);

            	loop213:
            		;	// Stops C# compiler whining that label 'loop213' has no statements

            	// JavaScript.g:460:12: ( assignmentExpression )?
            	int alt214 = 2;
            	int LA214_0 = input.LA(1);

            	if ( ((LA214_0 >= Identifier && LA214_0 <= NumericLiteral) || (LA214_0 >= 29 && LA214_0 <= 30) || LA214_0 == 33 || (LA214_0 >= 56 && LA214_0 <= 57) || (LA214_0 >= 89 && LA214_0 <= 90) || (LA214_0 >= 94 && LA214_0 <= 104)) )
            	{
            	    alt214 = 1;
            	}
            	switch (alt214) 
            	{
            	    case 1 :
            	        // JavaScript.g:0:0: assignmentExpression
            	        {
            	        	PushFollow(FOLLOW_assignmentExpression_in_arrayLiteral2295);
            	        	assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	// JavaScript.g:460:34: ( ( LT )* ',' ( ( LT )* assignmentExpression )? )*
            	do 
            	{
            	    int alt218 = 2;
            	    alt218 = dfa218.Predict(input);
            	    switch (alt218) 
            		{
            			case 1 :
            			    // JavaScript.g:460:35: ( LT )* ',' ( ( LT )* assignmentExpression )?
            			    {
            			    	// JavaScript.g:460:35: ( LT )*
            			    	do 
            			    	{
            			    	    int alt215 = 2;
            			    	    int LA215_0 = input.LA(1);

            			    	    if ( (LA215_0 == LT) )
            			    	    {
            			    	        alt215 = 1;
            			    	    }


            			    	    switch (alt215) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_arrayLiteral2299); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop215;
            			    	    }
            			    	} while (true);

            			    	loop215:
            			    		;	// Stops C# compiler whining that label 'loop215' has no statements

            			    	Match(input,31,FOLLOW_31_in_arrayLiteral2302); if (state.failed) return ;
            			    	// JavaScript.g:460:43: ( ( LT )* assignmentExpression )?
            			    	int alt217 = 2;
            			    	alt217 = dfa217.Predict(input);
            			    	switch (alt217) 
            			    	{
            			    	    case 1 :
            			    	        // JavaScript.g:460:44: ( LT )* assignmentExpression
            			    	        {
            			    	        	// JavaScript.g:460:44: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt216 = 2;
            			    	        	    int LA216_0 = input.LA(1);

            			    	        	    if ( (LA216_0 == LT) )
            			    	        	    {
            			    	        	        alt216 = 1;
            			    	        	    }


            			    	        	    switch (alt216) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:0:0: LT
            			    	        			    {
            			    	        			    	Match(input,LT,FOLLOW_LT_in_arrayLiteral2305); if (state.failed) return ;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop216;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop216:
            			    	        		;	// Stops C# compiler whining that label 'loop216' has no statements

            			    	        	PushFollow(FOLLOW_assignmentExpression_in_arrayLiteral2308);
            			    	        	assignmentExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return ;

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop218;
            	    }
            	} while (true);

            	loop218:
            		;	// Stops C# compiler whining that label 'loop218' has no statements

            	// JavaScript.g:460:73: ( LT )*
            	do 
            	{
            	    int alt219 = 2;
            	    int LA219_0 = input.LA(1);

            	    if ( (LA219_0 == LT) )
            	    {
            	        alt219 = 1;
            	    }


            	    switch (alt219) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_arrayLiteral2314); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop219;
            	    }
            	} while (true);

            	loop219:
            		;	// Stops C# compiler whining that label 'loop219' has no statements

            	Match(input,58,FOLLOW_58_in_arrayLiteral2317); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 77, arrayLiteral_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "arrayLiteral"


    // $ANTLR start "objectLiteral"
    // JavaScript.g:464:1: objectLiteral : '{' ( LT )* propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( LT )* '}' ;
    public void objectLiteral() // throws RecognitionException [1]
    {   
        int objectLiteral_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 78) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:465:2: ( '{' ( LT )* propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( LT )* '}' )
            // JavaScript.g:465:4: '{' ( LT )* propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( LT )* '}'
            {
            	Match(input,33,FOLLOW_33_in_objectLiteral2336); if (state.failed) return ;
            	// JavaScript.g:465:8: ( LT )*
            	do 
            	{
            	    int alt220 = 2;
            	    int LA220_0 = input.LA(1);

            	    if ( (LA220_0 == LT) )
            	    {
            	        alt220 = 1;
            	    }


            	    switch (alt220) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_objectLiteral2338); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop220;
            	    }
            	} while (true);

            	loop220:
            		;	// Stops C# compiler whining that label 'loop220' has no statements

            	PushFollow(FOLLOW_propertyNameAndValue_in_objectLiteral2341);
            	propertyNameAndValue();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:465:33: ( ( LT )* ',' ( LT )* propertyNameAndValue )*
            	do 
            	{
            	    int alt223 = 2;
            	    alt223 = dfa223.Predict(input);
            	    switch (alt223) 
            		{
            			case 1 :
            			    // JavaScript.g:465:34: ( LT )* ',' ( LT )* propertyNameAndValue
            			    {
            			    	// JavaScript.g:465:34: ( LT )*
            			    	do 
            			    	{
            			    	    int alt221 = 2;
            			    	    int LA221_0 = input.LA(1);

            			    	    if ( (LA221_0 == LT) )
            			    	    {
            			    	        alt221 = 1;
            			    	    }


            			    	    switch (alt221) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_objectLiteral2344); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop221;
            			    	    }
            			    	} while (true);

            			    	loop221:
            			    		;	// Stops C# compiler whining that label 'loop221' has no statements

            			    	Match(input,31,FOLLOW_31_in_objectLiteral2347); if (state.failed) return ;
            			    	// JavaScript.g:465:42: ( LT )*
            			    	do 
            			    	{
            			    	    int alt222 = 2;
            			    	    int LA222_0 = input.LA(1);

            			    	    if ( (LA222_0 == LT) )
            			    	    {
            			    	        alt222 = 1;
            			    	    }


            			    	    switch (alt222) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:0:0: LT
            			    			    {
            			    			    	Match(input,LT,FOLLOW_LT_in_objectLiteral2349); if (state.failed) return ;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop222;
            			    	    }
            			    	} while (true);

            			    	loop222:
            			    		;	// Stops C# compiler whining that label 'loop222' has no statements

            			    	PushFollow(FOLLOW_propertyNameAndValue_in_objectLiteral2352);
            			    	propertyNameAndValue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop223;
            	    }
            	} while (true);

            	loop223:
            		;	// Stops C# compiler whining that label 'loop223' has no statements

            	// JavaScript.g:465:69: ( LT )*
            	do 
            	{
            	    int alt224 = 2;
            	    int LA224_0 = input.LA(1);

            	    if ( (LA224_0 == LT) )
            	    {
            	        alt224 = 1;
            	    }


            	    switch (alt224) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_objectLiteral2356); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop224;
            	    }
            	} while (true);

            	loop224:
            		;	// Stops C# compiler whining that label 'loop224' has no statements

            	Match(input,34,FOLLOW_34_in_objectLiteral2359); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 78, objectLiteral_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "objectLiteral"


    // $ANTLR start "propertyNameAndValue"
    // JavaScript.g:468:1: propertyNameAndValue : propertyName ( LT )* ':' ( LT )* assignmentExpression ;
    public void propertyNameAndValue() // throws RecognitionException [1]
    {   
        int propertyNameAndValue_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 79) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:469:2: ( propertyName ( LT )* ':' ( LT )* assignmentExpression )
            // JavaScript.g:469:4: propertyName ( LT )* ':' ( LT )* assignmentExpression
            {
            	PushFollow(FOLLOW_propertyName_in_propertyNameAndValue2371);
            	propertyName();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// JavaScript.g:469:17: ( LT )*
            	do 
            	{
            	    int alt225 = 2;
            	    int LA225_0 = input.LA(1);

            	    if ( (LA225_0 == LT) )
            	    {
            	        alt225 = 1;
            	    }


            	    switch (alt225) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_propertyNameAndValue2373); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop225;
            	    }
            	} while (true);

            	loop225:
            		;	// Stops C# compiler whining that label 'loop225' has no statements

            	Match(input,48,FOLLOW_48_in_propertyNameAndValue2376); if (state.failed) return ;
            	// JavaScript.g:469:25: ( LT )*
            	do 
            	{
            	    int alt226 = 2;
            	    int LA226_0 = input.LA(1);

            	    if ( (LA226_0 == LT) )
            	    {
            	        alt226 = 1;
            	    }


            	    switch (alt226) 
            		{
            			case 1 :
            			    // JavaScript.g:0:0: LT
            			    {
            			    	Match(input,LT,FOLLOW_LT_in_propertyNameAndValue2378); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop226;
            	    }
            	} while (true);

            	loop226:
            		;	// Stops C# compiler whining that label 'loop226' has no statements

            	PushFollow(FOLLOW_assignmentExpression_in_propertyNameAndValue2381);
            	assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 79, propertyNameAndValue_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "propertyNameAndValue"


    // $ANTLR start "propertyName"
    // JavaScript.g:472:1: propertyName : ( Identifier | StringLiteral | NumericLiteral );
    public void propertyName() // throws RecognitionException [1]
    {   
        int propertyName_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 80) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:473:2: ( Identifier | StringLiteral | NumericLiteral )
            // JavaScript.g:
            {
            	if ( (input.LA(1) >= Identifier && input.LA(1) <= NumericLiteral) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 80, propertyName_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "propertyName"


    // $ANTLR start "literal"
    // JavaScript.g:479:1: literal : ( 'null' | 'true' | 'false' | StringLiteral | NumericLiteral );
    public void literal() // throws RecognitionException [1]
    {   
        int literal_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 81) ) 
    	    {
    	    	return ; 
    	    }
            // JavaScript.g:480:2: ( 'null' | 'true' | 'false' | StringLiteral | NumericLiteral )
            // JavaScript.g:
            {
            	if ( (input.LA(1) >= StringLiteral && input.LA(1) <= NumericLiteral) || (input.LA(1) >= 102 && input.LA(1) <= 104) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 81, literal_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "literal"

    // $ANTLR start "synpred5_JavaScript"
    public void synpred5_JavaScript_fragment() {
        // JavaScript.g:128:4: ( functionDeclaration )
        // JavaScript.g:128:4: functionDeclaration
        {
        	PushFollow(FOLLOW_functionDeclaration_in_synpred5_JavaScript89);
        	functionDeclaration();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_JavaScript"

    // $ANTLR start "synpred9_JavaScript"
    public void synpred9_JavaScript_fragment() {
        // JavaScript.g:138:15: ( LT )
        // JavaScript.g:138:15: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred9_JavaScript140); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_JavaScript"

    // $ANTLR start "synpred21_JavaScript"
    public void synpred21_JavaScript_fragment() {
        // JavaScript.g:151:4: ( statementBlock )
        // JavaScript.g:151:4: statementBlock
        {
        	PushFollow(FOLLOW_statementBlock_in_synpred21_JavaScript229);
        	statementBlock();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_JavaScript"

    // $ANTLR start "synpred24_JavaScript"
    public void synpred24_JavaScript_fragment() {
        JavaScriptParser.expressionStatement_return s = default(JavaScriptParser.expressionStatement_return);


        // JavaScript.g:154:4: (s= expressionStatement )
        // JavaScript.g:154:4: s= expressionStatement
        {
        	if ( (state.backtracking==0) )
        	{
        	   RaiseEnterExpressionStatement(); 
        	}
        	PushFollow(FOLLOW_expressionStatement_in_synpred24_JavaScript248);
        	s = expressionStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred24_JavaScript"

    // $ANTLR start "synpred31_JavaScript"
    public void synpred31_JavaScript_fragment() {
        // JavaScript.g:161:4: ( labelledStatement )
        // JavaScript.g:161:4: labelledStatement
        {
        	PushFollow(FOLLOW_labelledStatement_in_synpred31_JavaScript299);
        	labelledStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_JavaScript"

    // $ANTLR start "synpred34_JavaScript"
    public void synpred34_JavaScript_fragment() {
        // JavaScript.g:168:8: ( LT )
        // JavaScript.g:168:8: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred34_JavaScript332); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_JavaScript"

    // $ANTLR start "synpred47_JavaScript"
    public void synpred47_JavaScript_fragment() {
        // JavaScript.g:188:15: ( LT )
        // JavaScript.g:188:15: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred47_JavaScript450); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_JavaScript"

    // $ANTLR start "synpred49_JavaScript"
    public void synpred49_JavaScript_fragment() {
        // JavaScript.g:192:15: ( LT )
        // JavaScript.g:192:15: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred49_JavaScript468); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_JavaScript"

    // $ANTLR start "synpred60_JavaScript"
    public void synpred60_JavaScript_fragment() {
        // JavaScript.g:212:103: ( ( LT )* 'else' ( LT )* statement )
        // JavaScript.g:212:103: ( LT )* 'else' ( LT )* statement
        {
        	// JavaScript.g:212:103: ( LT )*
        	do 
        	{
        	    int alt239 = 2;
        	    int LA239_0 = input.LA(1);

        	    if ( (LA239_0 == LT) )
        	    {
        	        alt239 = 1;
        	    }


        	    switch (alt239) 
        		{
        			case 1 :
        			    // JavaScript.g:0:0: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred60_JavaScript577); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop239;
        	    }
        	} while (true);

        	loop239:
        		;	// Stops C# compiler whining that label 'loop239' has no statements

        	Match(input,39,FOLLOW_39_in_synpred60_JavaScript580); if (state.failed) return ;
        	// JavaScript.g:212:114: ( LT )*
        	do 
        	{
        	    int alt240 = 2;
        	    int LA240_0 = input.LA(1);

        	    if ( (LA240_0 == LT) )
        	    {
        	        alt240 = 1;
        	    }


        	    switch (alt240) 
        		{
        			case 1 :
        			    // JavaScript.g:0:0: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred60_JavaScript582); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop240;
        	    }
        	} while (true);

        	loop240:
        		;	// Stops C# compiler whining that label 'loop240' has no statements

        	PushFollow(FOLLOW_statement_in_synpred60_JavaScript587);
        	statement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred60_JavaScript"

    // $ANTLR start "synpred63_JavaScript"
    public void synpred63_JavaScript_fragment() {
        // JavaScript.g:218:4: ( forStatement )
        // JavaScript.g:218:4: forStatement
        {
        	PushFollow(FOLLOW_forStatement_in_synpred63_JavaScript613);
        	forStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred63_JavaScript"

    // $ANTLR start "synpred118_JavaScript"
    public void synpred118_JavaScript_fragment() {
        // JavaScript.g:277:34: ( LT )
        // JavaScript.g:277:34: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred118_JavaScript1051); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred118_JavaScript"

    // $ANTLR start "synpred121_JavaScript"
    public void synpred121_JavaScript_fragment() {
        // JavaScript.g:281:22: ( LT )
        // JavaScript.g:281:22: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred121_JavaScript1078); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred121_JavaScript"

    // $ANTLR start "synpred140_JavaScript"
    public void synpred140_JavaScript_fragment() {
        // JavaScript.g:310:4: ( conditionalExpression )
        // JavaScript.g:310:4: conditionalExpression
        {
        	PushFollow(FOLLOW_conditionalExpression_in_synpred140_JavaScript1260);
        	conditionalExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred140_JavaScript"

    // $ANTLR start "synpred143_JavaScript"
    public void synpred143_JavaScript_fragment() {
        // JavaScript.g:315:4: ( conditionalExpressionNoIn )
        // JavaScript.g:315:4: conditionalExpressionNoIn
        {
        	PushFollow(FOLLOW_conditionalExpressionNoIn_in_synpred143_JavaScript1287);
        	conditionalExpressionNoIn();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred143_JavaScript"

    // $ANTLR start "synpred146_JavaScript"
    public void synpred146_JavaScript_fragment() {
        // JavaScript.g:320:4: ( callExpression )
        // JavaScript.g:320:4: callExpression
        {
        	PushFollow(FOLLOW_callExpression_in_synpred146_JavaScript1314);
        	callExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred146_JavaScript"

    // $ANTLR start "synpred147_JavaScript"
    public void synpred147_JavaScript_fragment() {
        // JavaScript.g:325:4: ( memberExpression )
        // JavaScript.g:325:4: memberExpression
        {
        	PushFollow(FOLLOW_memberExpression_in_synpred147_JavaScript1331);
        	memberExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred147_JavaScript"

    // $ANTLR start "synpred154_JavaScript"
    public void synpred154_JavaScript_fragment() {
        // JavaScript.g:330:89: ( ( LT )* memberExpressionSuffix )
        // JavaScript.g:330:89: ( LT )* memberExpressionSuffix
        {
        	// JavaScript.g:330:89: ( LT )*
        	do 
        	{
        	    int alt254 = 2;
        	    int LA254_0 = input.LA(1);

        	    if ( (LA254_0 == LT) )
        	    {
        	        alt254 = 1;
        	    }


        	    switch (alt254) 
        		{
        			case 1 :
        			    // JavaScript.g:0:0: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred154_JavaScript1376); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop254;
        	    }
        	} while (true);

        	loop254:
        		;	// Stops C# compiler whining that label 'loop254' has no statements

        	PushFollow(FOLLOW_memberExpressionSuffix_in_synpred154_JavaScript1379);
        	memberExpressionSuffix();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred154_JavaScript"

    // $ANTLR start "synpred158_JavaScript"
    public void synpred158_JavaScript_fragment() {
        // JavaScript.g:339:36: ( ( LT )* callExpressionSuffix )
        // JavaScript.g:339:36: ( LT )* callExpressionSuffix
        {
        	// JavaScript.g:339:36: ( LT )*
        	do 
        	{
        	    int alt255 = 2;
        	    int LA255_0 = input.LA(1);

        	    if ( (LA255_0 == LT) )
        	    {
        	        alt255 = 1;
        	    }


        	    switch (alt255) 
        		{
        			case 1 :
        			    // JavaScript.g:0:0: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred158_JavaScript1417); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop255;
        	    }
        	} while (true);

        	loop255:
        		;	// Stops C# compiler whining that label 'loop255' has no statements

        	PushFollow(FOLLOW_callExpressionSuffix_in_synpred158_JavaScript1420);
        	callExpressionSuffix();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred158_JavaScript"

    // $ANTLR start "synpred256_JavaScript"
    public void synpred256_JavaScript_fragment() {
        // JavaScript.g:433:30: ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )
        // JavaScript.g:433:30: ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression
        {
        	// JavaScript.g:433:30: ( LT )*
        	do 
        	{
        	    int alt300 = 2;
        	    int LA300_0 = input.LA(1);

        	    if ( (LA300_0 == LT) )
        	    {
        	        alt300 = 1;
        	    }


        	    switch (alt300) 
        		{
        			case 1 :
        			    // JavaScript.g:0:0: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred256_JavaScript2108); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop300;
        	    }
        	} while (true);

        	loop300:
        		;	// Stops C# compiler whining that label 'loop300' has no statements

        	if ( (input.LA(1) >= 89 && input.LA(1) <= 90) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}

        	// JavaScript.g:433:46: ( LT )*
        	do 
        	{
        	    int alt301 = 2;
        	    int LA301_0 = input.LA(1);

        	    if ( (LA301_0 == LT) )
        	    {
        	        alt301 = 1;
        	    }


        	    switch (alt301) 
        		{
        			case 1 :
        			    // JavaScript.g:0:0: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred256_JavaScript2119); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop301;
        	    }
        	} while (true);

        	loop301:
        		;	// Stops C# compiler whining that label 'loop301' has no statements

        	PushFollow(FOLLOW_multiplicativeExpression_in_synpred256_JavaScript2122);
        	multiplicativeExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred256_JavaScript"

    // $ANTLR start "synpred280_JavaScript"
    public void synpred280_JavaScript_fragment() {
        // JavaScript.g:460:8: ( LT )
        // JavaScript.g:460:8: LT
        {
        	Match(input,LT,FOLLOW_LT_in_synpred280_JavaScript2292); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred280_JavaScript"

    // Delegated rules

   	public bool synpred60_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred60_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred121_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred121_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred146_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred146_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred154_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred154_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred34_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred147_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred147_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred63_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred63_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred47_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred256_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred256_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred280_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred280_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred118_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred118_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred158_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred158_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred9_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred21_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred31_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred49_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred24_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred24_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred143_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred143_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred140_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred140_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA4 dfa4;
   	protected DFA5 dfa5;
   	protected DFA17 dfa17;
   	protected DFA16 dfa16;
   	protected DFA21 dfa21;
   	protected DFA26 dfa26;
   	protected DFA30 dfa30;
   	protected DFA33 dfa33;
   	protected DFA57 dfa57;
   	protected DFA60 dfa60;
   	protected DFA63 dfa63;
   	protected DFA90 dfa90;
   	protected DFA94 dfa94;
   	protected DFA93 dfa93;
   	protected DFA106 dfa106;
   	protected DFA115 dfa115;
   	protected DFA118 dfa118;
   	protected DFA121 dfa121;
   	protected DFA124 dfa124;
   	protected DFA125 dfa125;
   	protected DFA127 dfa127;
   	protected DFA132 dfa132;
   	protected DFA136 dfa136;
   	protected DFA142 dfa142;
   	protected DFA141 dfa141;
   	protected DFA151 dfa151;
   	protected DFA156 dfa156;
   	protected DFA159 dfa159;
   	protected DFA162 dfa162;
   	protected DFA165 dfa165;
   	protected DFA168 dfa168;
   	protected DFA171 dfa171;
   	protected DFA174 dfa174;
   	protected DFA177 dfa177;
   	protected DFA180 dfa180;
   	protected DFA183 dfa183;
   	protected DFA186 dfa186;
   	protected DFA189 dfa189;
   	protected DFA192 dfa192;
   	protected DFA195 dfa195;
   	protected DFA198 dfa198;
   	protected DFA201 dfa201;
   	protected DFA204 dfa204;
   	protected DFA207 dfa207;
   	protected DFA218 dfa218;
   	protected DFA217 dfa217;
   	protected DFA223 dfa223;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa5 = new DFA5(this);
    	this.dfa17 = new DFA17(this);
    	this.dfa16 = new DFA16(this);
    	this.dfa21 = new DFA21(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa30 = new DFA30(this);
    	this.dfa33 = new DFA33(this);
    	this.dfa57 = new DFA57(this);
    	this.dfa60 = new DFA60(this);
    	this.dfa63 = new DFA63(this);
    	this.dfa90 = new DFA90(this);
    	this.dfa94 = new DFA94(this);
    	this.dfa93 = new DFA93(this);
    	this.dfa106 = new DFA106(this);
    	this.dfa115 = new DFA115(this);
    	this.dfa118 = new DFA118(this);
    	this.dfa121 = new DFA121(this);
    	this.dfa124 = new DFA124(this);
    	this.dfa125 = new DFA125(this);
    	this.dfa127 = new DFA127(this);
    	this.dfa132 = new DFA132(this);
    	this.dfa136 = new DFA136(this);
    	this.dfa142 = new DFA142(this);
    	this.dfa141 = new DFA141(this);
    	this.dfa151 = new DFA151(this);
    	this.dfa156 = new DFA156(this);
    	this.dfa159 = new DFA159(this);
    	this.dfa162 = new DFA162(this);
    	this.dfa165 = new DFA165(this);
    	this.dfa168 = new DFA168(this);
    	this.dfa171 = new DFA171(this);
    	this.dfa174 = new DFA174(this);
    	this.dfa177 = new DFA177(this);
    	this.dfa180 = new DFA180(this);
    	this.dfa183 = new DFA183(this);
    	this.dfa186 = new DFA186(this);
    	this.dfa189 = new DFA189(this);
    	this.dfa192 = new DFA192(this);
    	this.dfa195 = new DFA195(this);
    	this.dfa198 = new DFA198(this);
    	this.dfa201 = new DFA201(this);
    	this.dfa204 = new DFA204(this);
    	this.dfa207 = new DFA207(this);
    	this.dfa218 = new DFA218(this);
    	this.dfa217 = new DFA217(this);
    	this.dfa223 = new DFA223(this);

	    this.dfa5.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA5_SpecialStateTransition);


	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);












	    this.dfa121.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA121_SpecialStateTransition);
	    this.dfa124.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA124_SpecialStateTransition);
	    this.dfa125.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA125_SpecialStateTransition);
	    this.dfa127.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA127_SpecialStateTransition);
	    this.dfa132.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA132_SpecialStateTransition);
	    this.dfa136.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA136_SpecialStateTransition);



















	    this.dfa204.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA204_SpecialStateTransition);




	}

    const string DFA4_eotS =
        "\x04\uffff";
    const string DFA4_eofS =
        "\x02\x02\x02\uffff";
    const string DFA4_minS =
        "\x02\x04\x02\uffff";
    const string DFA4_maxS =
        "\x02\x68\x02\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA4_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x03\x03\x15\uffff\x02\x03\x02\uffff\x01\x03\x01\x02"+
            "\x02\x03\x01\uffff\x01\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x03\x03\x15\uffff\x02\x03\x02\uffff\x01\x03\x01\x02"+
            "\x02\x03\x01\uffff\x01\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 124:18: ( ( LT )* sourceElement )*"; }
        }

    }

    const string DFA5_eotS =
        "\x18\uffff";
    const string DFA5_eofS =
        "\x18\uffff";
    const string DFA5_minS =
        "\x01\x05\x01\x00\x16\uffff";
    const string DFA5_maxS =
        "\x01\x68\x01\x00\x16\uffff";
    const string DFA5_acceptS =
        "\x02\uffff\x01\x02\x14\uffff\x01\x01";
    const string DFA5_specialS =
        "\x01\uffff\x01\x00\x16\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x03\x02\x15\uffff\x01\x01\x01\x02\x02\uffff\x01\x02\x01\uffff"+
            "\x02\x02\x01\uffff\x01\x02\x01\uffff\x03\x02\x01\uffff\x04\x02"+
            "\x01\uffff\x01\x02\x02\uffff\x02\x02\x02\uffff\x02\x02\x1f\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "127:1: sourceElement : ( functionDeclaration | statement );"; }
        }

    }


    protected internal int DFA5_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA5_1 = input.LA(1);

                   	 
                   	int index5_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index5_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae5 =
            new NoViableAltException(dfa.Description, 5, _s, input);
        dfa.Error(nvae5);
        throw nvae5;
    }
    const string DFA17_eotS =
        "\x04\uffff";
    const string DFA17_eofS =
        "\x04\uffff";
    const string DFA17_minS =
        "\x02\x04\x02\uffff";
    const string DFA17_maxS =
        "\x02\x20\x02\uffff";
    const string DFA17_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA17_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x01\x01\x02\x1a\uffff\x01\x03",
            "\x01\x01\x01\x02\x1a\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "142:8: ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )?"; }
        }

    }

    const string DFA16_eotS =
        "\x04\uffff";
    const string DFA16_eofS =
        "\x04\uffff";
    const string DFA16_minS =
        "\x02\x04\x02\uffff";
    const string DFA16_maxS =
        "\x02\x20\x02\uffff";
    const string DFA16_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA16_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 142:24: ( ( LT )* ',' ( LT )* Identifier )*"; }
        }

    }

    const string DFA21_eotS =
        "\x19\uffff";
    const string DFA21_eofS =
        "\x19\uffff";
    const string DFA21_minS =
        "\x01\x05\x01\x00\x03\uffff\x01\x00\x13\uffff";
    const string DFA21_maxS =
        "\x01\x68\x01\x00\x03\uffff\x01\x00\x13\uffff";
    const string DFA21_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x07\uffff\x01\x05\x01\x06\x02"+
        "\uffff\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0c\x01\x0d\x01\x0e\x01"+
        "\x01\x01\x0b";
    const string DFA21_specialS =
        "\x01\uffff\x01\x00\x03\uffff\x01\x01\x13\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x05\x02\x04\x15\uffff\x02\x04\x02\uffff\x01\x01\x01\uffff"+
            "\x01\x02\x01\x03\x01\uffff\x01\x0c\x01\uffff\x03\x0d\x01\uffff"+
            "\x01\x10\x01\x11\x01\x12\x01\x13\x01\uffff\x01\x14\x02\uffff"+
            "\x01\x15\x01\x16\x02\uffff\x02\x04\x1f\uffff\x02\x04\x03\uffff"+
            "\x0b\x04",
            "\x01\uffff",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "150:1: statement : ( statementBlock | variableStatement | emptyStatement | s= expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | w= returnStatement | withStatement | labelledStatement | switchStatement | throwStatement | tryStatement );"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_1 = input.LA(1);

                   	 
                   	int index21_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred21_JavaScript()) ) { s = 23; }

                   	else if ( (synpred24_JavaScript()) ) { s = 4; }

                   	 
                   	input.Seek(index21_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA21_5 = input.LA(1);

                   	 
                   	int index21_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred24_JavaScript()) ) { s = 4; }

                   	else if ( (synpred31_JavaScript()) ) { s = 24; }

                   	 
                   	input.Seek(index21_5);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
    const string DFA26_eotS =
        "\x04\uffff";
    const string DFA26_eofS =
        "\x01\x02\x03\uffff";
    const string DFA26_minS =
        "\x02\x04\x02\uffff";
    const string DFA26_maxS =
        "\x02\x68\x02\uffff";
    const string DFA26_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA26_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x01\x03\x03\x15\uffff\x02\x03\x02\uffff\x01\x03\x01\x02"+
            "\x02\x03\x01\uffff\x01\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\x02\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x03\x03\x15\uffff\x02\x03\x02\uffff\x01\x03\x01\x02"+
            "\x02\x03\x01\uffff\x01\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\x02\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 172:14: ( ( LT )* statement )*"; }
        }

    }

    const string DFA30_eotS =
        "\x05\uffff";
    const string DFA30_eofS =
        "\x01\uffff\x01\x02\x02\uffff\x01\x02";
    const string DFA30_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA30_maxS =
        "\x01\x24\x01\x68\x02\uffff\x01\x68";
    const string DFA30_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA30_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA30_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x02",
            "\x01\x04\x03\x02\x15\uffff\x02\x02\x01\x03\x01\uffff\x04\x02"+
            "\x01\uffff\x05\x02\x01\uffff\x04\x02\x01\uffff\x05\x02\x02\uffff"+
            "\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x02\x02\x01\x03\x01\uffff\x04\x02"+
            "\x01\uffff\x05\x02\x01\uffff\x04\x02\x01\uffff\x05\x02\x02\uffff"+
            "\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA30_eot = DFA.UnpackEncodedString(DFA30_eotS);
    static readonly short[] DFA30_eof = DFA.UnpackEncodedString(DFA30_eofS);
    static readonly char[] DFA30_min = DFA.UnpackEncodedStringToUnsignedChars(DFA30_minS);
    static readonly char[] DFA30_max = DFA.UnpackEncodedStringToUnsignedChars(DFA30_maxS);
    static readonly short[] DFA30_accept = DFA.UnpackEncodedString(DFA30_acceptS);
    static readonly short[] DFA30_special = DFA.UnpackEncodedString(DFA30_specialS);
    static readonly short[][] DFA30_transition = DFA.UnpackEncodedStringArray(DFA30_transitionS);

    protected class DFA30 : DFA
    {
        public DFA30(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 30;
            this.eot = DFA30_eot;
            this.eof = DFA30_eof;
            this.min = DFA30_min;
            this.max = DFA30_max;
            this.accept = DFA30_accept;
            this.special = DFA30_special;
            this.transition = DFA30_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 180:24: ( ( LT )* ',' ( LT )* variableDeclaration )*"; }
        }

    }

    const string DFA33_eotS =
        "\x04\uffff";
    const string DFA33_eofS =
        "\x01\x02\x03\uffff";
    const string DFA33_minS =
        "\x02\x04\x02\uffff";
    const string DFA33_maxS =
        "\x02\x24\x02\uffff";
    const string DFA33_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA33_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
    static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
    static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
    static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
    static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
    static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
    static readonly short[][] DFA33_transition = DFA.UnpackEncodedStringArray(DFA33_transitionS);

    protected class DFA33 : DFA
    {
        public DFA33(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 33;
            this.eot = DFA33_eot;
            this.eof = DFA33_eof;
            this.min = DFA33_min;
            this.max = DFA33_max;
            this.accept = DFA33_accept;
            this.special = DFA33_special;
            this.transition = DFA33_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 184:28: ( ( LT )* ',' ( LT )* variableDeclarationNoIn )*"; }
        }

    }

    const string DFA57_eotS =
        "\x04\uffff";
    const string DFA57_eofS =
        "\x04\uffff";
    const string DFA57_minS =
        "\x02\x04\x02\uffff";
    const string DFA57_maxS =
        "\x02\x68\x02\uffff";
    const string DFA57_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA57_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA57_transitionS = {
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff"+
            "\x01\x02\x01\x03\x13\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff"+
            "\x0b\x02",
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x02\uffff\x01\x02\x01\uffff"+
            "\x01\x02\x01\x03\x13\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff"+
            "\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA57_eot = DFA.UnpackEncodedString(DFA57_eotS);
    static readonly short[] DFA57_eof = DFA.UnpackEncodedString(DFA57_eofS);
    static readonly char[] DFA57_min = DFA.UnpackEncodedStringToUnsignedChars(DFA57_minS);
    static readonly char[] DFA57_max = DFA.UnpackEncodedStringToUnsignedChars(DFA57_maxS);
    static readonly short[] DFA57_accept = DFA.UnpackEncodedString(DFA57_acceptS);
    static readonly short[] DFA57_special = DFA.UnpackEncodedString(DFA57_specialS);
    static readonly short[][] DFA57_transition = DFA.UnpackEncodedStringArray(DFA57_transitionS);

    protected class DFA57 : DFA
    {
        public DFA57(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 57;
            this.eot = DFA57_eot;
            this.eof = DFA57_eof;
            this.min = DFA57_min;
            this.max = DFA57_max;
            this.accept = DFA57_accept;
            this.special = DFA57_special;
            this.transition = DFA57_transition;

        }

        override public string Description
        {
            get { return "231:18: ( ( LT )* forStatementInitialiserPart )?"; }
        }

    }

    const string DFA60_eotS =
        "\x04\uffff";
    const string DFA60_eofS =
        "\x04\uffff";
    const string DFA60_minS =
        "\x02\x04\x02\uffff";
    const string DFA60_maxS =
        "\x02\x68\x02\uffff";
    const string DFA60_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA60_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA60_transitionS = {
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x02\uffff\x01\x02\x02\uffff"+
            "\x01\x03\x13\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x02\uffff\x01\x02\x02\uffff"+
            "\x01\x03\x13\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA60_eot = DFA.UnpackEncodedString(DFA60_eotS);
    static readonly short[] DFA60_eof = DFA.UnpackEncodedString(DFA60_eofS);
    static readonly char[] DFA60_min = DFA.UnpackEncodedStringToUnsignedChars(DFA60_minS);
    static readonly char[] DFA60_max = DFA.UnpackEncodedStringToUnsignedChars(DFA60_maxS);
    static readonly short[] DFA60_accept = DFA.UnpackEncodedString(DFA60_acceptS);
    static readonly short[] DFA60_special = DFA.UnpackEncodedString(DFA60_specialS);
    static readonly short[][] DFA60_transition = DFA.UnpackEncodedStringArray(DFA60_transitionS);

    protected class DFA60 : DFA
    {
        public DFA60(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 60;
            this.eot = DFA60_eot;
            this.eof = DFA60_eof;
            this.min = DFA60_min;
            this.max = DFA60_max;
            this.accept = DFA60_accept;
            this.special = DFA60_special;
            this.transition = DFA60_transition;

        }

        override public string Description
        {
            get { return "231:61: ( ( LT )* expression )?"; }
        }

    }

    const string DFA63_eotS =
        "\x04\uffff";
    const string DFA63_eofS =
        "\x04\uffff";
    const string DFA63_minS =
        "\x02\x04\x02\uffff";
    const string DFA63_maxS =
        "\x02\x68\x02\uffff";
    const string DFA63_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA63_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA63_transitionS = {
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x01\uffff\x01\x03\x01\x02"+
            "\x16\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x01\uffff\x01\x03\x01\x02"+
            "\x16\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA63_eot = DFA.UnpackEncodedString(DFA63_eotS);
    static readonly short[] DFA63_eof = DFA.UnpackEncodedString(DFA63_eofS);
    static readonly char[] DFA63_min = DFA.UnpackEncodedStringToUnsignedChars(DFA63_minS);
    static readonly char[] DFA63_max = DFA.UnpackEncodedStringToUnsignedChars(DFA63_maxS);
    static readonly short[] DFA63_accept = DFA.UnpackEncodedString(DFA63_acceptS);
    static readonly short[] DFA63_special = DFA.UnpackEncodedString(DFA63_specialS);
    static readonly short[][] DFA63_transition = DFA.UnpackEncodedStringArray(DFA63_transitionS);

    protected class DFA63 : DFA
    {
        public DFA63(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 63;
            this.eot = DFA63_eot;
            this.eof = DFA63_eof;
            this.min = DFA63_min;
            this.max = DFA63_max;
            this.accept = DFA63_accept;
            this.special = DFA63_special;
            this.transition = DFA63_transition;

        }

        override public string Description
        {
            get { return "231:87: ( ( LT )* expression )?"; }
        }

    }

    const string DFA90_eotS =
        "\x04\uffff";
    const string DFA90_eofS =
        "\x04\uffff";
    const string DFA90_minS =
        "\x02\x04\x02\uffff";
    const string DFA90_maxS =
        "\x02\x33\x02\uffff";
    const string DFA90_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA90_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA90_transitionS = {
            "\x01\x01\x1d\uffff\x01\x02\x0f\uffff\x01\x03\x01\x02",
            "\x01\x01\x1d\uffff\x01\x02\x0f\uffff\x01\x03\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA90_eot = DFA.UnpackEncodedString(DFA90_eotS);
    static readonly short[] DFA90_eof = DFA.UnpackEncodedString(DFA90_eofS);
    static readonly char[] DFA90_min = DFA.UnpackEncodedStringToUnsignedChars(DFA90_minS);
    static readonly char[] DFA90_max = DFA.UnpackEncodedStringToUnsignedChars(DFA90_maxS);
    static readonly short[] DFA90_accept = DFA.UnpackEncodedString(DFA90_acceptS);
    static readonly short[] DFA90_special = DFA.UnpackEncodedString(DFA90_specialS);
    static readonly short[][] DFA90_transition = DFA.UnpackEncodedStringArray(DFA90_transitionS);

    protected class DFA90 : DFA
    {
        public DFA90(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 90;
            this.eot = DFA90_eot;
            this.eof = DFA90_eof;
            this.min = DFA90_min;
            this.max = DFA90_max;
            this.accept = DFA90_accept;
            this.special = DFA90_special;
            this.transition = DFA90_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 273:8: ( ( LT )* caseClause )*"; }
        }

    }

    const string DFA94_eotS =
        "\x04\uffff";
    const string DFA94_eofS =
        "\x04\uffff";
    const string DFA94_minS =
        "\x02\x04\x02\uffff";
    const string DFA94_maxS =
        "\x02\x33\x02\uffff";
    const string DFA94_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA94_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA94_transitionS = {
            "\x01\x01\x1d\uffff\x01\x03\x10\uffff\x01\x02",
            "\x01\x01\x1d\uffff\x01\x03\x10\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA94_eot = DFA.UnpackEncodedString(DFA94_eotS);
    static readonly short[] DFA94_eof = DFA.UnpackEncodedString(DFA94_eofS);
    static readonly char[] DFA94_min = DFA.UnpackEncodedStringToUnsignedChars(DFA94_minS);
    static readonly char[] DFA94_max = DFA.UnpackEncodedStringToUnsignedChars(DFA94_maxS);
    static readonly short[] DFA94_accept = DFA.UnpackEncodedString(DFA94_acceptS);
    static readonly short[] DFA94_special = DFA.UnpackEncodedString(DFA94_specialS);
    static readonly short[][] DFA94_transition = DFA.UnpackEncodedStringArray(DFA94_transitionS);

    protected class DFA94 : DFA
    {
        public DFA94(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 94;
            this.eot = DFA94_eot;
            this.eof = DFA94_eof;
            this.min = DFA94_min;
            this.max = DFA94_max;
            this.accept = DFA94_accept;
            this.special = DFA94_special;
            this.transition = DFA94_transition;

        }

        override public string Description
        {
            get { return "273:26: ( ( LT )* defaultClause ( ( LT )* caseClause )* )?"; }
        }

    }

    const string DFA93_eotS =
        "\x04\uffff";
    const string DFA93_eofS =
        "\x04\uffff";
    const string DFA93_minS =
        "\x02\x04\x02\uffff";
    const string DFA93_maxS =
        "\x02\x32\x02\uffff";
    const string DFA93_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA93_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA93_transitionS = {
            "\x01\x01\x1d\uffff\x01\x02\x0f\uffff\x01\x03",
            "\x01\x01\x1d\uffff\x01\x02\x0f\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA93_eot = DFA.UnpackEncodedString(DFA93_eotS);
    static readonly short[] DFA93_eof = DFA.UnpackEncodedString(DFA93_eofS);
    static readonly char[] DFA93_min = DFA.UnpackEncodedStringToUnsignedChars(DFA93_minS);
    static readonly char[] DFA93_max = DFA.UnpackEncodedStringToUnsignedChars(DFA93_maxS);
    static readonly short[] DFA93_accept = DFA.UnpackEncodedString(DFA93_acceptS);
    static readonly short[] DFA93_special = DFA.UnpackEncodedString(DFA93_specialS);
    static readonly short[][] DFA93_transition = DFA.UnpackEncodedStringArray(DFA93_transitionS);

    protected class DFA93 : DFA
    {
        public DFA93(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 93;
            this.eot = DFA93_eot;
            this.eof = DFA93_eof;
            this.min = DFA93_min;
            this.max = DFA93_max;
            this.accept = DFA93_accept;
            this.special = DFA93_special;
            this.transition = DFA93_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 273:45: ( ( LT )* caseClause )*"; }
        }

    }

    const string DFA106_eotS =
        "\x04\uffff";
    const string DFA106_eofS =
        "\x02\x03\x02\uffff";
    const string DFA106_minS =
        "\x02\x04\x02\uffff";
    const string DFA106_maxS =
        "\x02\x68\x02\uffff";
    const string DFA106_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA106_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA106_transitionS = {
            "\x01\x01\x03\x03\x15\uffff\x02\x03\x02\uffff\x04\x03\x01\uffff"+
            "\x05\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x01\uffff\x01\x02"+
            "\x02\x03\x1f\uffff\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x03\x03\x15\uffff\x02\x03\x02\uffff\x04\x03\x01\uffff"+
            "\x05\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x01\uffff\x01\x02"+
            "\x02\x03\x1f\uffff\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA106_eot = DFA.UnpackEncodedString(DFA106_eotS);
    static readonly short[] DFA106_eof = DFA.UnpackEncodedString(DFA106_eofS);
    static readonly char[] DFA106_min = DFA.UnpackEncodedStringToUnsignedChars(DFA106_minS);
    static readonly char[] DFA106_max = DFA.UnpackEncodedStringToUnsignedChars(DFA106_maxS);
    static readonly short[] DFA106_accept = DFA.UnpackEncodedString(DFA106_acceptS);
    static readonly short[] DFA106_special = DFA.UnpackEncodedString(DFA106_specialS);
    static readonly short[][] DFA106_transition = DFA.UnpackEncodedStringArray(DFA106_transitionS);

    protected class DFA106 : DFA
    {
        public DFA106(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 106;
            this.eot = DFA106_eot;
            this.eof = DFA106_eof;
            this.min = DFA106_min;
            this.max = DFA106_max;
            this.accept = DFA106_accept;
            this.special = DFA106_special;
            this.transition = DFA106_transition;

        }

        override public string Description
        {
            get { return "289:62: ( ( LT )* finallyClause )?"; }
        }

    }

    const string DFA115_eotS =
        "\x05\uffff";
    const string DFA115_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA115_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA115_maxS =
        "\x01\x3a\x01\x68\x02\uffff\x01\x68";
    const string DFA115_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA115_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA115_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x01\x02\x03\uffff\x01\x02\x0b\uffff"+
            "\x01\x02\x09\uffff\x01\x02",
            "\x01\x04\x03\x02\x15\uffff\x02\x02\x01\x03\x05\x02\x01\uffff"+
            "\x05\x02\x01\uffff\x0a\x02\x02\uffff\x03\x02\x1e\uffff\x02\x02"+
            "\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x02\x02\x01\x03\x05\x02\x01\uffff"+
            "\x05\x02\x01\uffff\x0a\x02\x02\uffff\x03\x02\x1e\uffff\x02\x02"+
            "\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA115_eot = DFA.UnpackEncodedString(DFA115_eotS);
    static readonly short[] DFA115_eof = DFA.UnpackEncodedString(DFA115_eofS);
    static readonly char[] DFA115_min = DFA.UnpackEncodedStringToUnsignedChars(DFA115_minS);
    static readonly char[] DFA115_max = DFA.UnpackEncodedStringToUnsignedChars(DFA115_maxS);
    static readonly short[] DFA115_accept = DFA.UnpackEncodedString(DFA115_acceptS);
    static readonly short[] DFA115_special = DFA.UnpackEncodedString(DFA115_specialS);
    static readonly short[][] DFA115_transition = DFA.UnpackEncodedStringArray(DFA115_transitionS);

    protected class DFA115 : DFA
    {
        public DFA115(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 115;
            this.eot = DFA115_eot;
            this.eof = DFA115_eof;
            this.min = DFA115_min;
            this.max = DFA115_max;
            this.accept = DFA115_accept;
            this.special = DFA115_special;
            this.transition = DFA115_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 302:25: ( ( LT )* ',' ( LT )* assignmentExpression )*"; }
        }

    }

    const string DFA118_eotS =
        "\x04\uffff";
    const string DFA118_eofS =
        "\x01\x02\x03\uffff";
    const string DFA118_minS =
        "\x02\x04\x02\uffff";
    const string DFA118_maxS =
        "\x02\x24\x02\uffff";
    const string DFA118_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA118_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA118_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA118_eot = DFA.UnpackEncodedString(DFA118_eotS);
    static readonly short[] DFA118_eof = DFA.UnpackEncodedString(DFA118_eofS);
    static readonly char[] DFA118_min = DFA.UnpackEncodedStringToUnsignedChars(DFA118_minS);
    static readonly char[] DFA118_max = DFA.UnpackEncodedStringToUnsignedChars(DFA118_maxS);
    static readonly short[] DFA118_accept = DFA.UnpackEncodedString(DFA118_acceptS);
    static readonly short[] DFA118_special = DFA.UnpackEncodedString(DFA118_specialS);
    static readonly short[][] DFA118_transition = DFA.UnpackEncodedStringArray(DFA118_transitionS);

    protected class DFA118 : DFA
    {
        public DFA118(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 118;
            this.eot = DFA118_eot;
            this.eof = DFA118_eof;
            this.min = DFA118_min;
            this.max = DFA118_max;
            this.accept = DFA118_accept;
            this.special = DFA118_special;
            this.transition = DFA118_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 306:29: ( ( LT )* ',' ( LT )* assignmentExpressionNoIn )*"; }
        }

    }

    const string DFA121_eotS =
        "\x0b\uffff";
    const string DFA121_eofS =
        "\x0b\uffff";
    const string DFA121_minS =
        "\x01\x05\x08\x00\x02\uffff";
    const string DFA121_maxS =
        "\x01\x68\x08\x00\x02\uffff";
    const string DFA121_acceptS =
        "\x09\uffff\x01\x01\x01\x02";
    const string DFA121_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x02\uffff}>";
    static readonly string[] DFA121_transitionS = {
            "\x01\x02\x02\x03\x15\uffff\x01\x07\x01\x06\x02\uffff\x01\x05"+
            "\x16\uffff\x01\x08\x01\x04\x1f\uffff\x02\x09\x03\uffff\x07\x09"+
            "\x01\x01\x03\x03",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA121_eot = DFA.UnpackEncodedString(DFA121_eotS);
    static readonly short[] DFA121_eof = DFA.UnpackEncodedString(DFA121_eofS);
    static readonly char[] DFA121_min = DFA.UnpackEncodedStringToUnsignedChars(DFA121_minS);
    static readonly char[] DFA121_max = DFA.UnpackEncodedStringToUnsignedChars(DFA121_maxS);
    static readonly short[] DFA121_accept = DFA.UnpackEncodedString(DFA121_acceptS);
    static readonly short[] DFA121_special = DFA.UnpackEncodedString(DFA121_specialS);
    static readonly short[][] DFA121_transition = DFA.UnpackEncodedStringArray(DFA121_transitionS);

    protected class DFA121 : DFA
    {
        public DFA121(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 121;
            this.eot = DFA121_eot;
            this.eof = DFA121_eof;
            this.min = DFA121_min;
            this.max = DFA121_max;
            this.accept = DFA121_accept;
            this.special = DFA121_special;
            this.transition = DFA121_transition;

        }

        override public string Description
        {
            get { return "309:1: assignmentExpression : ( conditionalExpression | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression );"; }
        }

    }


    protected internal int DFA121_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA121_1 = input.LA(1);

                   	 
                   	int index121_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA121_2 = input.LA(1);

                   	 
                   	int index121_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA121_3 = input.LA(1);

                   	 
                   	int index121_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA121_4 = input.LA(1);

                   	 
                   	int index121_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA121_5 = input.LA(1);

                   	 
                   	int index121_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA121_6 = input.LA(1);

                   	 
                   	int index121_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA121_7 = input.LA(1);

                   	 
                   	int index121_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA121_8 = input.LA(1);

                   	 
                   	int index121_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred140_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index121_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae121 =
            new NoViableAltException(dfa.Description, 121, _s, input);
        dfa.Error(nvae121);
        throw nvae121;
    }
    const string DFA124_eotS =
        "\x0b\uffff";
    const string DFA124_eofS =
        "\x0b\uffff";
    const string DFA124_minS =
        "\x01\x05\x08\x00\x02\uffff";
    const string DFA124_maxS =
        "\x01\x68\x08\x00\x02\uffff";
    const string DFA124_acceptS =
        "\x09\uffff\x01\x01\x01\x02";
    const string DFA124_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x02\uffff}>";
    static readonly string[] DFA124_transitionS = {
            "\x01\x02\x02\x03\x15\uffff\x01\x07\x01\x06\x02\uffff\x01\x05"+
            "\x16\uffff\x01\x08\x01\x04\x1f\uffff\x02\x09\x03\uffff\x07\x09"+
            "\x01\x01\x03\x03",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA124_eot = DFA.UnpackEncodedString(DFA124_eotS);
    static readonly short[] DFA124_eof = DFA.UnpackEncodedString(DFA124_eofS);
    static readonly char[] DFA124_min = DFA.UnpackEncodedStringToUnsignedChars(DFA124_minS);
    static readonly char[] DFA124_max = DFA.UnpackEncodedStringToUnsignedChars(DFA124_maxS);
    static readonly short[] DFA124_accept = DFA.UnpackEncodedString(DFA124_acceptS);
    static readonly short[] DFA124_special = DFA.UnpackEncodedString(DFA124_specialS);
    static readonly short[][] DFA124_transition = DFA.UnpackEncodedStringArray(DFA124_transitionS);

    protected class DFA124 : DFA
    {
        public DFA124(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 124;
            this.eot = DFA124_eot;
            this.eof = DFA124_eof;
            this.min = DFA124_min;
            this.max = DFA124_max;
            this.accept = DFA124_accept;
            this.special = DFA124_special;
            this.transition = DFA124_transition;

        }

        override public string Description
        {
            get { return "314:1: assignmentExpressionNoIn : ( conditionalExpressionNoIn | leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpressionNoIn );"; }
        }

    }


    protected internal int DFA124_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA124_1 = input.LA(1);

                   	 
                   	int index124_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA124_2 = input.LA(1);

                   	 
                   	int index124_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA124_3 = input.LA(1);

                   	 
                   	int index124_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA124_4 = input.LA(1);

                   	 
                   	int index124_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA124_5 = input.LA(1);

                   	 
                   	int index124_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA124_6 = input.LA(1);

                   	 
                   	int index124_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA124_7 = input.LA(1);

                   	 
                   	int index124_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA124_8 = input.LA(1);

                   	 
                   	int index124_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred143_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index124_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae124 =
            new NoViableAltException(dfa.Description, 124, _s, input);
        dfa.Error(nvae124);
        throw nvae124;
    }
    const string DFA125_eotS =
        "\x0b\uffff";
    const string DFA125_eofS =
        "\x0b\uffff";
    const string DFA125_minS =
        "\x01\x05\x08\x00\x02\uffff";
    const string DFA125_maxS =
        "\x01\x68\x08\x00\x02\uffff";
    const string DFA125_acceptS =
        "\x09\uffff\x01\x01\x01\x02";
    const string DFA125_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x02\uffff}>";
    static readonly string[] DFA125_transitionS = {
            "\x01\x02\x02\x03\x15\uffff\x01\x07\x01\x06\x02\uffff\x01\x05"+
            "\x16\uffff\x01\x08\x01\x04\x2b\uffff\x01\x01\x03\x03",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            ""
    };

    static readonly short[] DFA125_eot = DFA.UnpackEncodedString(DFA125_eotS);
    static readonly short[] DFA125_eof = DFA.UnpackEncodedString(DFA125_eofS);
    static readonly char[] DFA125_min = DFA.UnpackEncodedStringToUnsignedChars(DFA125_minS);
    static readonly char[] DFA125_max = DFA.UnpackEncodedStringToUnsignedChars(DFA125_maxS);
    static readonly short[] DFA125_accept = DFA.UnpackEncodedString(DFA125_acceptS);
    static readonly short[] DFA125_special = DFA.UnpackEncodedString(DFA125_specialS);
    static readonly short[][] DFA125_transition = DFA.UnpackEncodedStringArray(DFA125_transitionS);

    protected class DFA125 : DFA
    {
        public DFA125(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 125;
            this.eot = DFA125_eot;
            this.eof = DFA125_eof;
            this.min = DFA125_min;
            this.max = DFA125_max;
            this.accept = DFA125_accept;
            this.special = DFA125_special;
            this.transition = DFA125_transition;

        }

        override public string Description
        {
            get { return "319:1: leftHandSideExpression : ( callExpression | newExpression );"; }
        }

    }


    protected internal int DFA125_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA125_1 = input.LA(1);

                   	 
                   	int index125_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA125_2 = input.LA(1);

                   	 
                   	int index125_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA125_3 = input.LA(1);

                   	 
                   	int index125_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA125_4 = input.LA(1);

                   	 
                   	int index125_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA125_5 = input.LA(1);

                   	 
                   	int index125_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA125_6 = input.LA(1);

                   	 
                   	int index125_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA125_7 = input.LA(1);

                   	 
                   	int index125_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA125_8 = input.LA(1);

                   	 
                   	int index125_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred146_JavaScript()) ) { s = 9; }

                   	else if ( (true) ) { s = 10; }

                   	 
                   	input.Seek(index125_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae125 =
            new NoViableAltException(dfa.Description, 125, _s, input);
        dfa.Error(nvae125);
        throw nvae125;
    }
    const string DFA127_eotS =
        "\x0a\uffff";
    const string DFA127_eofS =
        "\x0a\uffff";
    const string DFA127_minS =
        "\x01\x05\x07\uffff\x01\x00\x01\uffff";
    const string DFA127_maxS =
        "\x01\x68\x07\uffff\x01\x00\x01\uffff";
    const string DFA127_acceptS =
        "\x01\uffff\x01\x01\x07\uffff\x01\x02";
    const string DFA127_specialS =
        "\x08\uffff\x01\x00\x01\uffff}>";
    static readonly string[] DFA127_transitionS = {
            "\x03\x01\x15\uffff\x02\x01\x02\uffff\x01\x01\x16\uffff\x01"+
            "\x08\x01\x01\x2b\uffff\x04\x01",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            ""
    };

    static readonly short[] DFA127_eot = DFA.UnpackEncodedString(DFA127_eotS);
    static readonly short[] DFA127_eof = DFA.UnpackEncodedString(DFA127_eofS);
    static readonly char[] DFA127_min = DFA.UnpackEncodedStringToUnsignedChars(DFA127_minS);
    static readonly char[] DFA127_max = DFA.UnpackEncodedStringToUnsignedChars(DFA127_maxS);
    static readonly short[] DFA127_accept = DFA.UnpackEncodedString(DFA127_acceptS);
    static readonly short[] DFA127_special = DFA.UnpackEncodedString(DFA127_specialS);
    static readonly short[][] DFA127_transition = DFA.UnpackEncodedStringArray(DFA127_transitionS);

    protected class DFA127 : DFA
    {
        public DFA127(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 127;
            this.eot = DFA127_eot;
            this.eof = DFA127_eof;
            this.min = DFA127_min;
            this.max = DFA127_max;
            this.accept = DFA127_accept;
            this.special = DFA127_special;
            this.transition = DFA127_transition;

        }

        override public string Description
        {
            get { return "324:1: newExpression : ( memberExpression | 'new' ( LT )* newExpression );"; }
        }

    }


    protected internal int DFA127_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA127_8 = input.LA(1);

                   	 
                   	int index127_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred147_JavaScript()) ) { s = 1; }

                   	else if ( (true) ) { s = 9; }

                   	 
                   	input.Seek(index127_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae127 =
            new NoViableAltException(dfa.Description, 127, _s, input);
        dfa.Error(nvae127);
        throw nvae127;
    }
    const string DFA132_eotS =
        "\x1a\uffff";
    const string DFA132_eofS =
        "\x01\x02\x19\uffff";
    const string DFA132_minS =
        "\x01\x04\x01\x00\x18\uffff";
    const string DFA132_maxS =
        "\x01\x62\x01\x00\x18\uffff";
    const string DFA132_acceptS =
        "\x02\uffff\x01\x02\x15\uffff\x01\x01\x01\uffff";
    const string DFA132_specialS =
        "\x01\uffff\x01\x00\x18\uffff}>";
    static readonly string[] DFA132_transitionS = {
            "\x01\x01\x19\uffff\x03\x02\x01\uffff\x01\x02\x01\uffff\x02"+
            "\x02\x05\uffff\x01\x02\x04\uffff\x01\x02\x08\uffff\x01\x18\x01"+
            "\x02\x01\x18\x22\x02\x03\uffff\x02\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA132_eot = DFA.UnpackEncodedString(DFA132_eotS);
    static readonly short[] DFA132_eof = DFA.UnpackEncodedString(DFA132_eofS);
    static readonly char[] DFA132_min = DFA.UnpackEncodedStringToUnsignedChars(DFA132_minS);
    static readonly char[] DFA132_max = DFA.UnpackEncodedStringToUnsignedChars(DFA132_maxS);
    static readonly short[] DFA132_accept = DFA.UnpackEncodedString(DFA132_acceptS);
    static readonly short[] DFA132_special = DFA.UnpackEncodedString(DFA132_specialS);
    static readonly short[][] DFA132_transition = DFA.UnpackEncodedStringArray(DFA132_transitionS);

    protected class DFA132 : DFA
    {
        public DFA132(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 132;
            this.eot = DFA132_eot;
            this.eof = DFA132_eof;
            this.min = DFA132_min;
            this.max = DFA132_max;
            this.accept = DFA132_accept;
            this.special = DFA132_special;
            this.transition = DFA132_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 330:88: ( ( LT )* memberExpressionSuffix )*"; }
        }

    }


    protected internal int DFA132_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA132_1 = input.LA(1);

                   	 
                   	int index132_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred154_JavaScript()) ) { s = 24; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index132_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae132 =
            new NoViableAltException(dfa.Description, 132, _s, input);
        dfa.Error(nvae132);
        throw nvae132;
    }
    const string DFA136_eotS =
        "\x1a\uffff";
    const string DFA136_eofS =
        "\x01\x02\x19\uffff";
    const string DFA136_minS =
        "\x01\x04\x01\x00\x18\uffff";
    const string DFA136_maxS =
        "\x01\x62\x01\x00\x18\uffff";
    const string DFA136_acceptS =
        "\x02\uffff\x01\x02\x14\uffff\x01\x01\x02\uffff";
    const string DFA136_specialS =
        "\x01\uffff\x01\x00\x18\uffff}>";
    static readonly string[] DFA136_transitionS = {
            "\x01\x01\x19\uffff\x01\x17\x02\x02\x01\uffff\x01\x02\x01\uffff"+
            "\x02\x02\x05\uffff\x01\x02\x04\uffff\x01\x02\x08\uffff\x01\x17"+
            "\x01\x02\x01\x17\x22\x02\x03\uffff\x02\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA136_eot = DFA.UnpackEncodedString(DFA136_eotS);
    static readonly short[] DFA136_eof = DFA.UnpackEncodedString(DFA136_eofS);
    static readonly char[] DFA136_min = DFA.UnpackEncodedStringToUnsignedChars(DFA136_minS);
    static readonly char[] DFA136_max = DFA.UnpackEncodedStringToUnsignedChars(DFA136_maxS);
    static readonly short[] DFA136_accept = DFA.UnpackEncodedString(DFA136_acceptS);
    static readonly short[] DFA136_special = DFA.UnpackEncodedString(DFA136_specialS);
    static readonly short[][] DFA136_transition = DFA.UnpackEncodedStringArray(DFA136_transitionS);

    protected class DFA136 : DFA
    {
        public DFA136(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 136;
            this.eot = DFA136_eot;
            this.eof = DFA136_eof;
            this.min = DFA136_min;
            this.max = DFA136_max;
            this.accept = DFA136_accept;
            this.special = DFA136_special;
            this.transition = DFA136_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 339:35: ( ( LT )* callExpressionSuffix )*"; }
        }

    }


    protected internal int DFA136_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA136_1 = input.LA(1);

                   	 
                   	int index136_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred158_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index136_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae136 =
            new NoViableAltException(dfa.Description, 136, _s, input);
        dfa.Error(nvae136);
        throw nvae136;
    }
    const string DFA142_eotS =
        "\x04\uffff";
    const string DFA142_eofS =
        "\x04\uffff";
    const string DFA142_minS =
        "\x02\x04\x02\uffff";
    const string DFA142_maxS =
        "\x02\x68\x02\uffff";
    const string DFA142_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA142_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA142_transitionS = {
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x01\uffff\x01\x03\x01\x02"+
            "\x16\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x01\uffff\x01\x03\x01\x02"+
            "\x16\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA142_eot = DFA.UnpackEncodedString(DFA142_eotS);
    static readonly short[] DFA142_eof = DFA.UnpackEncodedString(DFA142_eofS);
    static readonly char[] DFA142_min = DFA.UnpackEncodedStringToUnsignedChars(DFA142_minS);
    static readonly char[] DFA142_max = DFA.UnpackEncodedStringToUnsignedChars(DFA142_maxS);
    static readonly short[] DFA142_accept = DFA.UnpackEncodedString(DFA142_acceptS);
    static readonly short[] DFA142_special = DFA.UnpackEncodedString(DFA142_specialS);
    static readonly short[][] DFA142_transition = DFA.UnpackEncodedStringArray(DFA142_transitionS);

    protected class DFA142 : DFA
    {
        public DFA142(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 142;
            this.eot = DFA142_eot;
            this.eof = DFA142_eof;
            this.min = DFA142_min;
            this.max = DFA142_max;
            this.accept = DFA142_accept;
            this.special = DFA142_special;
            this.transition = DFA142_transition;

        }

        override public string Description
        {
            get { return "349:8: ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )?"; }
        }

    }

    const string DFA141_eotS =
        "\x04\uffff";
    const string DFA141_eofS =
        "\x04\uffff";
    const string DFA141_minS =
        "\x02\x04\x02\uffff";
    const string DFA141_maxS =
        "\x02\x20\x02\uffff";
    const string DFA141_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA141_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA141_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA141_eot = DFA.UnpackEncodedString(DFA141_eotS);
    static readonly short[] DFA141_eof = DFA.UnpackEncodedString(DFA141_eofS);
    static readonly char[] DFA141_min = DFA.UnpackEncodedStringToUnsignedChars(DFA141_minS);
    static readonly char[] DFA141_max = DFA.UnpackEncodedStringToUnsignedChars(DFA141_maxS);
    static readonly short[] DFA141_accept = DFA.UnpackEncodedString(DFA141_acceptS);
    static readonly short[] DFA141_special = DFA.UnpackEncodedString(DFA141_specialS);
    static readonly short[][] DFA141_transition = DFA.UnpackEncodedStringArray(DFA141_transitionS);

    protected class DFA141 : DFA
    {
        public DFA141(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 141;
            this.eot = DFA141_eot;
            this.eof = DFA141_eof;
            this.min = DFA141_min;
            this.max = DFA141_max;
            this.accept = DFA141_accept;
            this.special = DFA141_special;
            this.transition = DFA141_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 349:34: ( ( LT )* ',' ( LT )* assignmentExpression )*"; }
        }

    }

    const string DFA151_eotS =
        "\x05\uffff";
    const string DFA151_eofS =
        "\x02\x03\x02\uffff\x01\x03";
    const string DFA151_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA151_maxS =
        "\x01\x47\x01\x68\x02\uffff\x01\x68";
    const string DFA151_acceptS =
        "\x02\uffff\x01\x01\x01\x02\x01\uffff";
    const string DFA151_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA151_transitionS = {
            "\x01\x01\x1a\uffff\x02\x03\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x03\x0b\uffff\x01\x03\x09\uffff\x01\x03\x0c\uffff\x01\x02",
            "\x01\x04\x03\x03\x15\uffff\x08\x03\x01\uffff\x05\x03\x01\uffff"+
            "\x0a\x03\x02\uffff\x03\x03\x0c\uffff\x01\x02\x11\uffff\x02\x03"+
            "\x03\uffff\x0b\x03",
            "",
            "",
            "\x01\x04\x03\x03\x15\uffff\x08\x03\x01\uffff\x05\x03\x01\uffff"+
            "\x0a\x03\x02\uffff\x03\x03\x0c\uffff\x01\x02\x11\uffff\x02\x03"+
            "\x03\uffff\x0b\x03"
    };

    static readonly short[] DFA151_eot = DFA.UnpackEncodedString(DFA151_eotS);
    static readonly short[] DFA151_eof = DFA.UnpackEncodedString(DFA151_eofS);
    static readonly char[] DFA151_min = DFA.UnpackEncodedStringToUnsignedChars(DFA151_minS);
    static readonly char[] DFA151_max = DFA.UnpackEncodedStringToUnsignedChars(DFA151_maxS);
    static readonly short[] DFA151_accept = DFA.UnpackEncodedString(DFA151_acceptS);
    static readonly short[] DFA151_special = DFA.UnpackEncodedString(DFA151_specialS);
    static readonly short[][] DFA151_transition = DFA.UnpackEncodedStringArray(DFA151_transitionS);

    protected class DFA151 : DFA
    {
        public DFA151(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 151;
            this.eot = DFA151_eot;
            this.eof = DFA151_eof;
            this.min = DFA151_min;
            this.max = DFA151_max;
            this.accept = DFA151_accept;
            this.special = DFA151_special;
            this.transition = DFA151_transition;

        }

        override public string Description
        {
            get { return "365:24: ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?"; }
        }

    }

    const string DFA156_eotS =
        "\x04\uffff";
    const string DFA156_eofS =
        "\x01\x03\x03\uffff";
    const string DFA156_minS =
        "\x02\x04\x02\uffff";
    const string DFA156_maxS =
        "\x02\x47\x02\uffff";
    const string DFA156_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA156_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA156_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x03\x06\uffff\x01"+
            "\x03\x04\uffff\x01\x03\x16\uffff\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x04\uffff\x01\x03\x06\uffff\x01"+
            "\x03\x04\uffff\x01\x03\x16\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA156_eot = DFA.UnpackEncodedString(DFA156_eotS);
    static readonly short[] DFA156_eof = DFA.UnpackEncodedString(DFA156_eofS);
    static readonly char[] DFA156_min = DFA.UnpackEncodedStringToUnsignedChars(DFA156_minS);
    static readonly char[] DFA156_max = DFA.UnpackEncodedStringToUnsignedChars(DFA156_maxS);
    static readonly short[] DFA156_accept = DFA.UnpackEncodedString(DFA156_acceptS);
    static readonly short[] DFA156_special = DFA.UnpackEncodedString(DFA156_specialS);
    static readonly short[][] DFA156_transition = DFA.UnpackEncodedStringArray(DFA156_transitionS);

    protected class DFA156 : DFA
    {
        public DFA156(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 156;
            this.eot = DFA156_eot;
            this.eof = DFA156_eof;
            this.min = DFA156_min;
            this.max = DFA156_max;
            this.accept = DFA156_accept;
            this.special = DFA156_special;
            this.transition = DFA156_transition;

        }

        override public string Description
        {
            get { return "369:28: ( ( LT )* '?' ( LT )* assignmentExpressionNoIn ( LT )* ':' ( LT )* assignmentExpressionNoIn )?"; }
        }

    }

    const string DFA159_eotS =
        "\x05\uffff";
    const string DFA159_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA159_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA159_maxS =
        "\x01\x48\x01\x68\x02\uffff\x01\x68";
    const string DFA159_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA159_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA159_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0b\uffff\x01\x02\x09\uffff\x01\x02\x0c\uffff\x01\x02\x01"+
            "\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x01\x02\x01\x03\x10\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x01\x02\x01\x03\x10\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA159_eot = DFA.UnpackEncodedString(DFA159_eotS);
    static readonly short[] DFA159_eof = DFA.UnpackEncodedString(DFA159_eofS);
    static readonly char[] DFA159_min = DFA.UnpackEncodedStringToUnsignedChars(DFA159_minS);
    static readonly char[] DFA159_max = DFA.UnpackEncodedStringToUnsignedChars(DFA159_maxS);
    static readonly short[] DFA159_accept = DFA.UnpackEncodedString(DFA159_acceptS);
    static readonly short[] DFA159_special = DFA.UnpackEncodedString(DFA159_specialS);
    static readonly short[][] DFA159_transition = DFA.UnpackEncodedStringArray(DFA159_transitionS);

    protected class DFA159 : DFA
    {
        public DFA159(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 159;
            this.eot = DFA159_eot;
            this.eof = DFA159_eof;
            this.min = DFA159_min;
            this.max = DFA159_max;
            this.accept = DFA159_accept;
            this.special = DFA159_special;
            this.transition = DFA159_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 373:25: ( ( LT )* '||' ( LT )* logicalANDExpression )*"; }
        }

    }

    const string DFA162_eotS =
        "\x04\uffff";
    const string DFA162_eofS =
        "\x01\x02\x03\uffff";
    const string DFA162_minS =
        "\x02\x04\x02\uffff";
    const string DFA162_maxS =
        "\x02\x48\x02\uffff";
    const string DFA162_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA162_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA162_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x01\x02\x01\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x01\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA162_eot = DFA.UnpackEncodedString(DFA162_eotS);
    static readonly short[] DFA162_eof = DFA.UnpackEncodedString(DFA162_eofS);
    static readonly char[] DFA162_min = DFA.UnpackEncodedStringToUnsignedChars(DFA162_minS);
    static readonly char[] DFA162_max = DFA.UnpackEncodedStringToUnsignedChars(DFA162_maxS);
    static readonly short[] DFA162_accept = DFA.UnpackEncodedString(DFA162_acceptS);
    static readonly short[] DFA162_special = DFA.UnpackEncodedString(DFA162_specialS);
    static readonly short[][] DFA162_transition = DFA.UnpackEncodedStringArray(DFA162_transitionS);

    protected class DFA162 : DFA
    {
        public DFA162(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 162;
            this.eot = DFA162_eot;
            this.eof = DFA162_eof;
            this.min = DFA162_min;
            this.max = DFA162_max;
            this.accept = DFA162_accept;
            this.special = DFA162_special;
            this.transition = DFA162_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 377:29: ( ( LT )* '||' ( LT )* logicalANDExpressionNoIn )*"; }
        }

    }

    const string DFA165_eotS =
        "\x05\uffff";
    const string DFA165_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA165_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA165_maxS =
        "\x01\x49\x01\x68\x02\uffff\x01\x68";
    const string DFA165_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA165_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA165_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0b\uffff\x01\x02\x09\uffff\x01\x02\x0c\uffff\x02\x02\x01"+
            "\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x02\x02\x01\x03\x0f\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x02\x02\x01\x03\x0f\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA165_eot = DFA.UnpackEncodedString(DFA165_eotS);
    static readonly short[] DFA165_eof = DFA.UnpackEncodedString(DFA165_eofS);
    static readonly char[] DFA165_min = DFA.UnpackEncodedStringToUnsignedChars(DFA165_minS);
    static readonly char[] DFA165_max = DFA.UnpackEncodedStringToUnsignedChars(DFA165_maxS);
    static readonly short[] DFA165_accept = DFA.UnpackEncodedString(DFA165_acceptS);
    static readonly short[] DFA165_special = DFA.UnpackEncodedString(DFA165_specialS);
    static readonly short[][] DFA165_transition = DFA.UnpackEncodedStringArray(DFA165_transitionS);

    protected class DFA165 : DFA
    {
        public DFA165(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 165;
            this.eot = DFA165_eot;
            this.eof = DFA165_eof;
            this.min = DFA165_min;
            this.max = DFA165_max;
            this.accept = DFA165_accept;
            this.special = DFA165_special;
            this.transition = DFA165_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 381:24: ( ( LT )* '&&' ( LT )* bitwiseORExpression )*"; }
        }

    }

    const string DFA168_eotS =
        "\x04\uffff";
    const string DFA168_eofS =
        "\x01\x02\x03\uffff";
    const string DFA168_minS =
        "\x02\x04\x02\uffff";
    const string DFA168_maxS =
        "\x02\x49\x02\uffff";
    const string DFA168_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA168_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA168_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x02\x02\x01\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x02\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA168_eot = DFA.UnpackEncodedString(DFA168_eotS);
    static readonly short[] DFA168_eof = DFA.UnpackEncodedString(DFA168_eofS);
    static readonly char[] DFA168_min = DFA.UnpackEncodedStringToUnsignedChars(DFA168_minS);
    static readonly char[] DFA168_max = DFA.UnpackEncodedStringToUnsignedChars(DFA168_maxS);
    static readonly short[] DFA168_accept = DFA.UnpackEncodedString(DFA168_acceptS);
    static readonly short[] DFA168_special = DFA.UnpackEncodedString(DFA168_specialS);
    static readonly short[][] DFA168_transition = DFA.UnpackEncodedStringArray(DFA168_transitionS);

    protected class DFA168 : DFA
    {
        public DFA168(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 168;
            this.eot = DFA168_eot;
            this.eof = DFA168_eof;
            this.min = DFA168_min;
            this.max = DFA168_max;
            this.accept = DFA168_accept;
            this.special = DFA168_special;
            this.transition = DFA168_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 385:28: ( ( LT )* '&&' ( LT )* bitwiseORExpressionNoIn )*"; }
        }

    }

    const string DFA171_eotS =
        "\x05\uffff";
    const string DFA171_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA171_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA171_maxS =
        "\x01\x4a\x01\x68\x02\uffff\x01\x68";
    const string DFA171_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA171_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA171_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0b\uffff\x01\x02\x09\uffff\x01\x02\x0c\uffff\x03\x02\x01"+
            "\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x03\x02\x01\x03\x0e\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x03\x02\x01\x03\x0e\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA171_eot = DFA.UnpackEncodedString(DFA171_eotS);
    static readonly short[] DFA171_eof = DFA.UnpackEncodedString(DFA171_eofS);
    static readonly char[] DFA171_min = DFA.UnpackEncodedStringToUnsignedChars(DFA171_minS);
    static readonly char[] DFA171_max = DFA.UnpackEncodedStringToUnsignedChars(DFA171_maxS);
    static readonly short[] DFA171_accept = DFA.UnpackEncodedString(DFA171_acceptS);
    static readonly short[] DFA171_special = DFA.UnpackEncodedString(DFA171_specialS);
    static readonly short[][] DFA171_transition = DFA.UnpackEncodedStringArray(DFA171_transitionS);

    protected class DFA171 : DFA
    {
        public DFA171(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 171;
            this.eot = DFA171_eot;
            this.eof = DFA171_eof;
            this.min = DFA171_min;
            this.max = DFA171_max;
            this.accept = DFA171_accept;
            this.special = DFA171_special;
            this.transition = DFA171_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 389:25: ( ( LT )* '|' ( LT )* bitwiseXORExpression )*"; }
        }

    }

    const string DFA174_eotS =
        "\x04\uffff";
    const string DFA174_eofS =
        "\x01\x02\x03\uffff";
    const string DFA174_minS =
        "\x02\x04\x02\uffff";
    const string DFA174_maxS =
        "\x02\x4a\x02\uffff";
    const string DFA174_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA174_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA174_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x03\x02\x01\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x03\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA174_eot = DFA.UnpackEncodedString(DFA174_eotS);
    static readonly short[] DFA174_eof = DFA.UnpackEncodedString(DFA174_eofS);
    static readonly char[] DFA174_min = DFA.UnpackEncodedStringToUnsignedChars(DFA174_minS);
    static readonly char[] DFA174_max = DFA.UnpackEncodedStringToUnsignedChars(DFA174_maxS);
    static readonly short[] DFA174_accept = DFA.UnpackEncodedString(DFA174_acceptS);
    static readonly short[] DFA174_special = DFA.UnpackEncodedString(DFA174_specialS);
    static readonly short[][] DFA174_transition = DFA.UnpackEncodedStringArray(DFA174_transitionS);

    protected class DFA174 : DFA
    {
        public DFA174(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 174;
            this.eot = DFA174_eot;
            this.eof = DFA174_eof;
            this.min = DFA174_min;
            this.max = DFA174_max;
            this.accept = DFA174_accept;
            this.special = DFA174_special;
            this.transition = DFA174_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 393:29: ( ( LT )* '|' ( LT )* bitwiseXORExpressionNoIn )*"; }
        }

    }

    const string DFA177_eotS =
        "\x05\uffff";
    const string DFA177_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA177_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA177_maxS =
        "\x01\x4b\x01\x68\x02\uffff\x01\x68";
    const string DFA177_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA177_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA177_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0b\uffff\x01\x02\x09\uffff\x01\x02\x0c\uffff\x04\x02\x01"+
            "\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x04\x02\x01\x03\x0d\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x04\x02\x01\x03\x0d\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA177_eot = DFA.UnpackEncodedString(DFA177_eotS);
    static readonly short[] DFA177_eof = DFA.UnpackEncodedString(DFA177_eofS);
    static readonly char[] DFA177_min = DFA.UnpackEncodedStringToUnsignedChars(DFA177_minS);
    static readonly char[] DFA177_max = DFA.UnpackEncodedStringToUnsignedChars(DFA177_maxS);
    static readonly short[] DFA177_accept = DFA.UnpackEncodedString(DFA177_acceptS);
    static readonly short[] DFA177_special = DFA.UnpackEncodedString(DFA177_specialS);
    static readonly short[][] DFA177_transition = DFA.UnpackEncodedStringArray(DFA177_transitionS);

    protected class DFA177 : DFA
    {
        public DFA177(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 177;
            this.eot = DFA177_eot;
            this.eof = DFA177_eof;
            this.min = DFA177_min;
            this.max = DFA177_max;
            this.accept = DFA177_accept;
            this.special = DFA177_special;
            this.transition = DFA177_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 397:25: ( ( LT )* '^' ( LT )* bitwiseANDExpression )*"; }
        }

    }

    const string DFA180_eotS =
        "\x04\uffff";
    const string DFA180_eofS =
        "\x01\x02\x03\uffff";
    const string DFA180_minS =
        "\x02\x04\x02\uffff";
    const string DFA180_maxS =
        "\x02\x4b\x02\uffff";
    const string DFA180_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA180_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA180_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x04\x02\x01\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x04\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA180_eot = DFA.UnpackEncodedString(DFA180_eotS);
    static readonly short[] DFA180_eof = DFA.UnpackEncodedString(DFA180_eofS);
    static readonly char[] DFA180_min = DFA.UnpackEncodedStringToUnsignedChars(DFA180_minS);
    static readonly char[] DFA180_max = DFA.UnpackEncodedStringToUnsignedChars(DFA180_maxS);
    static readonly short[] DFA180_accept = DFA.UnpackEncodedString(DFA180_acceptS);
    static readonly short[] DFA180_special = DFA.UnpackEncodedString(DFA180_specialS);
    static readonly short[][] DFA180_transition = DFA.UnpackEncodedStringArray(DFA180_transitionS);

    protected class DFA180 : DFA
    {
        public DFA180(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 180;
            this.eot = DFA180_eot;
            this.eof = DFA180_eof;
            this.min = DFA180_min;
            this.max = DFA180_max;
            this.accept = DFA180_accept;
            this.special = DFA180_special;
            this.transition = DFA180_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 401:29: ( ( LT )* '^' ( LT )* bitwiseANDExpressionNoIn )*"; }
        }

    }

    const string DFA183_eotS =
        "\x05\uffff";
    const string DFA183_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA183_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA183_maxS =
        "\x01\x4c\x01\x68\x02\uffff\x01\x68";
    const string DFA183_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA183_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA183_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0b\uffff\x01\x02\x09\uffff\x01\x02\x0c\uffff\x05\x02\x01"+
            "\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x05\x02\x01\x03\x0c\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x05\x02\x01\x03\x0c\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA183_eot = DFA.UnpackEncodedString(DFA183_eotS);
    static readonly short[] DFA183_eof = DFA.UnpackEncodedString(DFA183_eofS);
    static readonly char[] DFA183_min = DFA.UnpackEncodedStringToUnsignedChars(DFA183_minS);
    static readonly char[] DFA183_max = DFA.UnpackEncodedStringToUnsignedChars(DFA183_maxS);
    static readonly short[] DFA183_accept = DFA.UnpackEncodedString(DFA183_acceptS);
    static readonly short[] DFA183_special = DFA.UnpackEncodedString(DFA183_specialS);
    static readonly short[][] DFA183_transition = DFA.UnpackEncodedStringArray(DFA183_transitionS);

    protected class DFA183 : DFA
    {
        public DFA183(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 183;
            this.eot = DFA183_eot;
            this.eof = DFA183_eof;
            this.min = DFA183_min;
            this.max = DFA183_max;
            this.accept = DFA183_accept;
            this.special = DFA183_special;
            this.transition = DFA183_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 405:23: ( ( LT )* '&' ( LT )* equalityExpression )*"; }
        }

    }

    const string DFA186_eotS =
        "\x04\uffff";
    const string DFA186_eofS =
        "\x01\x02\x03\uffff";
    const string DFA186_minS =
        "\x02\x04\x02\uffff";
    const string DFA186_maxS =
        "\x02\x4c\x02\uffff";
    const string DFA186_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA186_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA186_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x05\x02\x01\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x05\x02\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA186_eot = DFA.UnpackEncodedString(DFA186_eotS);
    static readonly short[] DFA186_eof = DFA.UnpackEncodedString(DFA186_eofS);
    static readonly char[] DFA186_min = DFA.UnpackEncodedStringToUnsignedChars(DFA186_minS);
    static readonly char[] DFA186_max = DFA.UnpackEncodedStringToUnsignedChars(DFA186_maxS);
    static readonly short[] DFA186_accept = DFA.UnpackEncodedString(DFA186_acceptS);
    static readonly short[] DFA186_special = DFA.UnpackEncodedString(DFA186_specialS);
    static readonly short[][] DFA186_transition = DFA.UnpackEncodedStringArray(DFA186_transitionS);

    protected class DFA186 : DFA
    {
        public DFA186(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 186;
            this.eot = DFA186_eot;
            this.eof = DFA186_eof;
            this.min = DFA186_min;
            this.max = DFA186_max;
            this.accept = DFA186_accept;
            this.special = DFA186_special;
            this.transition = DFA186_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 409:27: ( ( LT )* '&' ( LT )* equalityExpressionNoIn )*"; }
        }

    }

    const string DFA189_eotS =
        "\x05\uffff";
    const string DFA189_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA189_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA189_maxS =
        "\x01\x50\x01\x68\x02\uffff\x01\x68";
    const string DFA189_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA189_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA189_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x0b\uffff\x01\x02\x09\uffff\x01\x02\x0c\uffff\x06\x02\x04"+
            "\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x06\x02\x04\x03\x08\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x06\x02\x04\x03\x08\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA189_eot = DFA.UnpackEncodedString(DFA189_eotS);
    static readonly short[] DFA189_eof = DFA.UnpackEncodedString(DFA189_eofS);
    static readonly char[] DFA189_min = DFA.UnpackEncodedStringToUnsignedChars(DFA189_minS);
    static readonly char[] DFA189_max = DFA.UnpackEncodedStringToUnsignedChars(DFA189_maxS);
    static readonly short[] DFA189_accept = DFA.UnpackEncodedString(DFA189_acceptS);
    static readonly short[] DFA189_special = DFA.UnpackEncodedString(DFA189_specialS);
    static readonly short[][] DFA189_transition = DFA.UnpackEncodedStringArray(DFA189_transitionS);

    protected class DFA189 : DFA
    {
        public DFA189(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 189;
            this.eot = DFA189_eot;
            this.eof = DFA189_eof;
            this.min = DFA189_min;
            this.max = DFA189_max;
            this.accept = DFA189_accept;
            this.special = DFA189_special;
            this.transition = DFA189_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 413:25: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpression )*"; }
        }

    }

    const string DFA192_eotS =
        "\x04\uffff";
    const string DFA192_eofS =
        "\x01\x02\x03\uffff";
    const string DFA192_minS =
        "\x02\x04\x02\uffff";
    const string DFA192_maxS =
        "\x02\x50\x02\uffff";
    const string DFA192_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA192_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA192_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x06\x02\x04\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x06\x02\x04\x03",
            "",
            ""
    };

    static readonly short[] DFA192_eot = DFA.UnpackEncodedString(DFA192_eotS);
    static readonly short[] DFA192_eof = DFA.UnpackEncodedString(DFA192_eofS);
    static readonly char[] DFA192_min = DFA.UnpackEncodedStringToUnsignedChars(DFA192_minS);
    static readonly char[] DFA192_max = DFA.UnpackEncodedStringToUnsignedChars(DFA192_maxS);
    static readonly short[] DFA192_accept = DFA.UnpackEncodedString(DFA192_acceptS);
    static readonly short[] DFA192_special = DFA.UnpackEncodedString(DFA192_specialS);
    static readonly short[][] DFA192_transition = DFA.UnpackEncodedStringArray(DFA192_transitionS);

    protected class DFA192 : DFA
    {
        public DFA192(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 192;
            this.eot = DFA192_eot;
            this.eof = DFA192_eof;
            this.min = DFA192_min;
            this.max = DFA192_max;
            this.accept = DFA192_accept;
            this.special = DFA192_special;
            this.transition = DFA192_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 417:29: ( ( LT )* ( '==' | '!=' | '===' | '!==' ) ( LT )* relationalExpressionNoIn )*"; }
        }

    }

    const string DFA195_eotS =
        "\x05\uffff";
    const string DFA195_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA195_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA195_maxS =
        "\x01\x55\x01\x68\x02\uffff\x01\x68";
    const string DFA195_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA195_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA195_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x06\uffff\x01\x03\x04\uffff\x01\x02\x09\uffff\x01\x02\x0c"+
            "\uffff\x0a\x02\x05\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\x03"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x0a\x02\x05\x03\x03\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x05\x02\x01\x03"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x0a\x02\x05\x03\x03\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA195_eot = DFA.UnpackEncodedString(DFA195_eotS);
    static readonly short[] DFA195_eof = DFA.UnpackEncodedString(DFA195_eofS);
    static readonly char[] DFA195_min = DFA.UnpackEncodedStringToUnsignedChars(DFA195_minS);
    static readonly char[] DFA195_max = DFA.UnpackEncodedStringToUnsignedChars(DFA195_maxS);
    static readonly short[] DFA195_accept = DFA.UnpackEncodedString(DFA195_acceptS);
    static readonly short[] DFA195_special = DFA.UnpackEncodedString(DFA195_specialS);
    static readonly short[][] DFA195_transition = DFA.UnpackEncodedStringArray(DFA195_transitionS);

    protected class DFA195 : DFA
    {
        public DFA195(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 195;
            this.eot = DFA195_eot;
            this.eof = DFA195_eof;
            this.min = DFA195_min;
            this.max = DFA195_max;
            this.accept = DFA195_accept;
            this.special = DFA195_special;
            this.transition = DFA195_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 421:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' | 'in' ) ( LT )* shiftExpression )*"; }
        }

    }

    const string DFA198_eotS =
        "\x04\uffff";
    const string DFA198_eofS =
        "\x01\x02\x03\uffff";
    const string DFA198_minS =
        "\x02\x04\x02\uffff";
    const string DFA198_maxS =
        "\x02\x55\x02\uffff";
    const string DFA198_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA198_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA198_transitionS = {
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x0a\x02\x05\x03",
            "\x01\x01\x1a\uffff\x01\x02\x04\uffff\x01\x02\x06\uffff\x01"+
            "\x02\x04\uffff\x01\x02\x16\uffff\x0a\x02\x05\x03",
            "",
            ""
    };

    static readonly short[] DFA198_eot = DFA.UnpackEncodedString(DFA198_eotS);
    static readonly short[] DFA198_eof = DFA.UnpackEncodedString(DFA198_eofS);
    static readonly char[] DFA198_min = DFA.UnpackEncodedStringToUnsignedChars(DFA198_minS);
    static readonly char[] DFA198_max = DFA.UnpackEncodedStringToUnsignedChars(DFA198_maxS);
    static readonly short[] DFA198_accept = DFA.UnpackEncodedString(DFA198_acceptS);
    static readonly short[] DFA198_special = DFA.UnpackEncodedString(DFA198_specialS);
    static readonly short[][] DFA198_transition = DFA.UnpackEncodedStringArray(DFA198_transitionS);

    protected class DFA198 : DFA
    {
        public DFA198(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 198;
            this.eot = DFA198_eot;
            this.eof = DFA198_eof;
            this.min = DFA198_min;
            this.max = DFA198_max;
            this.accept = DFA198_accept;
            this.special = DFA198_special;
            this.transition = DFA198_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 425:20: ( ( LT )* ( '<' | '>' | '<=' | '>=' | 'instanceof' ) ( LT )* shiftExpression )*"; }
        }

    }

    const string DFA201_eotS =
        "\x05\uffff";
    const string DFA201_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA201_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA201_maxS =
        "\x01\x58\x01\x68\x02\uffff\x01\x68";
    const string DFA201_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA201_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA201_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x06\uffff\x01\x02\x04\uffff\x01\x02\x09\uffff\x01\x02\x0c"+
            "\uffff\x0f\x02\x03\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x10\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x0f\x02\x03\x03\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x10\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x0f\x02\x03\x03\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA201_eot = DFA.UnpackEncodedString(DFA201_eotS);
    static readonly short[] DFA201_eof = DFA.UnpackEncodedString(DFA201_eofS);
    static readonly char[] DFA201_min = DFA.UnpackEncodedStringToUnsignedChars(DFA201_minS);
    static readonly char[] DFA201_max = DFA.UnpackEncodedStringToUnsignedChars(DFA201_maxS);
    static readonly short[] DFA201_accept = DFA.UnpackEncodedString(DFA201_acceptS);
    static readonly short[] DFA201_special = DFA.UnpackEncodedString(DFA201_specialS);
    static readonly short[][] DFA201_transition = DFA.UnpackEncodedStringArray(DFA201_transitionS);

    protected class DFA201 : DFA
    {
        public DFA201(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 201;
            this.eot = DFA201_eot;
            this.eof = DFA201_eof;
            this.min = DFA201_min;
            this.max = DFA201_max;
            this.accept = DFA201_accept;
            this.special = DFA201_special;
            this.transition = DFA201_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 429:23: ( ( LT )* ( '<<' | '>>' | '>>>' ) ( LT )* additiveExpression )*"; }
        }

    }

    const string DFA204_eotS =
        "\x14\uffff";
    const string DFA204_eofS =
        "\x01\x02\x13\uffff";
    const string DFA204_minS =
        "\x01\x04\x01\x00\x12\uffff";
    const string DFA204_maxS =
        "\x01\x5a\x01\x00\x12\uffff";
    const string DFA204_acceptS =
        "\x02\uffff\x01\x02\x10\uffff\x01\x01";
    const string DFA204_specialS =
        "\x01\uffff\x01\x00\x12\uffff}>";
    static readonly string[] DFA204_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x06\uffff\x01\x02\x04\uffff\x01\x02\x09\uffff\x01\x02\x0c"+
            "\uffff\x12\x02\x02\x13",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA204_eot = DFA.UnpackEncodedString(DFA204_eotS);
    static readonly short[] DFA204_eof = DFA.UnpackEncodedString(DFA204_eofS);
    static readonly char[] DFA204_min = DFA.UnpackEncodedStringToUnsignedChars(DFA204_minS);
    static readonly char[] DFA204_max = DFA.UnpackEncodedStringToUnsignedChars(DFA204_maxS);
    static readonly short[] DFA204_accept = DFA.UnpackEncodedString(DFA204_acceptS);
    static readonly short[] DFA204_special = DFA.UnpackEncodedString(DFA204_specialS);
    static readonly short[][] DFA204_transition = DFA.UnpackEncodedStringArray(DFA204_transitionS);

    protected class DFA204 : DFA
    {
        public DFA204(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 204;
            this.eot = DFA204_eot;
            this.eof = DFA204_eof;
            this.min = DFA204_min;
            this.max = DFA204_max;
            this.accept = DFA204_accept;
            this.special = DFA204_special;
            this.transition = DFA204_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 433:29: ( ( LT )* ( '+' | '-' ) ( LT )* multiplicativeExpression )*"; }
        }

    }


    protected internal int DFA204_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA204_1 = input.LA(1);

                   	 
                   	int index204_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred256_JavaScript()) ) { s = 19; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index204_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae204 =
            new NoViableAltException(dfa.Description, 204, _s, input);
        dfa.Error(nvae204);
        throw nvae204;
    }
    const string DFA207_eotS =
        "\x05\uffff";
    const string DFA207_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA207_minS =
        "\x02\x04\x02\uffff\x01\x04";
    const string DFA207_maxS =
        "\x01\x5d\x01\x68\x02\uffff\x01\x68";
    const string DFA207_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA207_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA207_transitionS = {
            "\x01\x01\x1a\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff\x01"+
            "\x02\x06\uffff\x01\x02\x04\uffff\x01\x02\x09\uffff\x01\x02\x0c"+
            "\uffff\x14\x02\x03\x03",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x10\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x14\x02\x03\x03\x0b\x02",
            "",
            "",
            "\x01\x04\x03\x02\x15\uffff\x08\x02\x01\uffff\x10\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x14\x02\x03\x03\x0b\x02"
    };

    static readonly short[] DFA207_eot = DFA.UnpackEncodedString(DFA207_eotS);
    static readonly short[] DFA207_eof = DFA.UnpackEncodedString(DFA207_eofS);
    static readonly char[] DFA207_min = DFA.UnpackEncodedStringToUnsignedChars(DFA207_minS);
    static readonly char[] DFA207_max = DFA.UnpackEncodedStringToUnsignedChars(DFA207_maxS);
    static readonly short[] DFA207_accept = DFA.UnpackEncodedString(DFA207_acceptS);
    static readonly short[] DFA207_special = DFA.UnpackEncodedString(DFA207_specialS);
    static readonly short[][] DFA207_transition = DFA.UnpackEncodedStringArray(DFA207_transitionS);

    protected class DFA207 : DFA
    {
        public DFA207(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 207;
            this.eot = DFA207_eot;
            this.eof = DFA207_eof;
            this.min = DFA207_min;
            this.max = DFA207_max;
            this.accept = DFA207_accept;
            this.special = DFA207_special;
            this.transition = DFA207_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 437:20: ( ( LT )* ( '*' | '/' | '%' ) ( LT )* unaryExpression )*"; }
        }

    }

    const string DFA218_eotS =
        "\x04\uffff";
    const string DFA218_eofS =
        "\x04\uffff";
    const string DFA218_minS =
        "\x02\x04\x02\uffff";
    const string DFA218_maxS =
        "\x02\x3a\x02\uffff";
    const string DFA218_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA218_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA218_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x1a\uffff\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x1a\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA218_eot = DFA.UnpackEncodedString(DFA218_eotS);
    static readonly short[] DFA218_eof = DFA.UnpackEncodedString(DFA218_eofS);
    static readonly char[] DFA218_min = DFA.UnpackEncodedStringToUnsignedChars(DFA218_minS);
    static readonly char[] DFA218_max = DFA.UnpackEncodedStringToUnsignedChars(DFA218_maxS);
    static readonly short[] DFA218_accept = DFA.UnpackEncodedString(DFA218_acceptS);
    static readonly short[] DFA218_special = DFA.UnpackEncodedString(DFA218_specialS);
    static readonly short[][] DFA218_transition = DFA.UnpackEncodedStringArray(DFA218_transitionS);

    protected class DFA218 : DFA
    {
        public DFA218(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 218;
            this.eot = DFA218_eot;
            this.eof = DFA218_eof;
            this.min = DFA218_min;
            this.max = DFA218_max;
            this.accept = DFA218_accept;
            this.special = DFA218_special;
            this.transition = DFA218_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 460:34: ( ( LT )* ',' ( ( LT )* assignmentExpression )? )*"; }
        }

    }

    const string DFA217_eotS =
        "\x04\uffff";
    const string DFA217_eofS =
        "\x04\uffff";
    const string DFA217_minS =
        "\x02\x04\x02\uffff";
    const string DFA217_maxS =
        "\x02\x68\x02\uffff";
    const string DFA217_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA217_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA217_transitionS = {
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x01\x03\x01\uffff\x01\x02"+
            "\x16\uffff\x02\x02\x01\x03\x1e\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x03\x02\x15\uffff\x02\x02\x01\x03\x01\uffff\x01\x02"+
            "\x16\uffff\x02\x02\x01\x03\x1e\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA217_eot = DFA.UnpackEncodedString(DFA217_eotS);
    static readonly short[] DFA217_eof = DFA.UnpackEncodedString(DFA217_eofS);
    static readonly char[] DFA217_min = DFA.UnpackEncodedStringToUnsignedChars(DFA217_minS);
    static readonly char[] DFA217_max = DFA.UnpackEncodedStringToUnsignedChars(DFA217_maxS);
    static readonly short[] DFA217_accept = DFA.UnpackEncodedString(DFA217_acceptS);
    static readonly short[] DFA217_special = DFA.UnpackEncodedString(DFA217_specialS);
    static readonly short[][] DFA217_transition = DFA.UnpackEncodedStringArray(DFA217_transitionS);

    protected class DFA217 : DFA
    {
        public DFA217(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 217;
            this.eot = DFA217_eot;
            this.eof = DFA217_eof;
            this.min = DFA217_min;
            this.max = DFA217_max;
            this.accept = DFA217_accept;
            this.special = DFA217_special;
            this.transition = DFA217_transition;

        }

        override public string Description
        {
            get { return "460:43: ( ( LT )* assignmentExpression )?"; }
        }

    }

    const string DFA223_eotS =
        "\x04\uffff";
    const string DFA223_eofS =
        "\x04\uffff";
    const string DFA223_minS =
        "\x02\x04\x02\uffff";
    const string DFA223_maxS =
        "\x02\x22\x02\uffff";
    const string DFA223_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA223_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA223_transitionS = {
            "\x01\x01\x1a\uffff\x01\x03\x02\uffff\x01\x02",
            "\x01\x01\x1a\uffff\x01\x03\x02\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA223_eot = DFA.UnpackEncodedString(DFA223_eotS);
    static readonly short[] DFA223_eof = DFA.UnpackEncodedString(DFA223_eofS);
    static readonly char[] DFA223_min = DFA.UnpackEncodedStringToUnsignedChars(DFA223_minS);
    static readonly char[] DFA223_max = DFA.UnpackEncodedStringToUnsignedChars(DFA223_maxS);
    static readonly short[] DFA223_accept = DFA.UnpackEncodedString(DFA223_acceptS);
    static readonly short[] DFA223_special = DFA.UnpackEncodedString(DFA223_specialS);
    static readonly short[][] DFA223_transition = DFA.UnpackEncodedStringArray(DFA223_transitionS);

    protected class DFA223 : DFA
    {
        public DFA223(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 223;
            this.eot = DFA223_eot;
            this.eof = DFA223_eof;
            this.min = DFA223_min;
            this.max = DFA223_max;
            this.accept = DFA223_accept;
            this.special = DFA223_special;
            this.transition = DFA223_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 465:33: ( ( LT )* ',' ( LT )* propertyNameAndValue )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_LT_in_program49 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_sourceElements_in_program52 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_program54 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_EOF_in_program57 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sourceElement_in_sourceElements69 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_sourceElements72 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_sourceElement_in_sourceElements75 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_sourceElement89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_sourceElement94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_functionDeclaration107 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration109 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration112 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration116 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration119 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration121 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_functionBody_in_functionDeclaration124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_functionExpression138 = new BitSet(new ulong[]{0x0000000040000030UL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression140 = new BitSet(new ulong[]{0x0000000040000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionExpression143 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression146 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionExpression149 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression151 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_functionBody_in_functionExpression154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_formalParameterList166 = new BitSet(new ulong[]{0x0000000100000030UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList169 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterList172 = new BitSet(new ulong[]{0x0000000180000010UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList175 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_formalParameterList178 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList180 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterList183 = new BitSet(new ulong[]{0x0000000180000010UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList189 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_formalParameterList192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_functionBody203 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_functionBody205 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_sourceElements_in_functionBody210 = new BitSet(new ulong[]{0x0000000400000010UL});
    public static readonly BitSet FOLLOW_LT_in_functionBody214 = new BitSet(new ulong[]{0x0000000400000010UL});
    public static readonly BitSet FOLLOW_34_in_functionBody217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statementBlock_in_statement229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableStatement_in_statement234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_emptyStatement_in_statement239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionStatement_in_statement248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_iterationStatement_in_statement266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_continueStatement_in_statement273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStatement_in_statement278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStatement_in_statement287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_withStatement_in_statement294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_labelledStatement_in_statement299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_switchStatement_in_statement306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_throwStatement_in_statement313 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tryStatement_in_statement318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_statementBlock330 = new BitSet(new ulong[]{0x0332F75E600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_statementBlock332 = new BitSet(new ulong[]{0x0332F75E600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statementList_in_statementBlock335 = new BitSet(new ulong[]{0x0000000400000010UL});
    public static readonly BitSet FOLLOW_LT_in_statementBlock338 = new BitSet(new ulong[]{0x0000000400000010UL});
    public static readonly BitSet FOLLOW_34_in_statementBlock341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_statementList353 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_statementList356 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_statementList359 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_35_in_variableStatement373 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_variableStatement375 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_variableStatement378 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_variableStatement380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableDeclarationList398 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationList401 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_variableDeclarationList404 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationList406 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableDeclarationList409 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_variableDeclarationNoIn_in_variableDeclarationListNoIn423 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationListNoIn426 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_variableDeclarationListNoIn429 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationListNoIn431 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_variableDeclarationNoIn_in_variableDeclarationListNoIn434 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclaration448 = new BitSet(new ulong[]{0x0000002000000012UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclaration450 = new BitSet(new ulong[]{0x0000002000000012UL});
    public static readonly BitSet FOLLOW_initialiser_in_variableDeclaration453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclarationNoIn466 = new BitSet(new ulong[]{0x0000002000000012UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationNoIn468 = new BitSet(new ulong[]{0x0000002000000012UL});
    public static readonly BitSet FOLLOW_initialiserNoIn_in_variableDeclarationNoIn471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_initialiser484 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_initialiser486 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_initialiser489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_initialiserNoIn501 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_initialiserNoIn503 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_initialiserNoIn506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_emptyStatement518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionStatement530 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_expressionStatement532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_ifStatement550 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement552 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_ifStatement555 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement557 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement560 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement562 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_ifStatement565 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement567 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement572 = new BitSet(new ulong[]{0x0000008000000012UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement577 = new BitSet(new ulong[]{0x0000008000000010UL});
    public static readonly BitSet FOLLOW_39_in_ifStatement580 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement582 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement587 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doWhileStatement_in_iterationStatement603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_iterationStatement608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_iterationStatement613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInStatement_in_iterationStatement618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_doWhileStatement630 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement632 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_doWhileStatement635 = new BitSet(new ulong[]{0x0000020000000010UL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement637 = new BitSet(new ulong[]{0x0000020000000010UL});
    public static readonly BitSet FOLLOW_41_in_doWhileStatement640 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement642 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_doWhileStatement645 = new BitSet(new ulong[]{0x03000002600000E0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_doWhileStatement647 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_doWhileStatement649 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_doWhileStatement651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_whileStatement669 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement671 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_whileStatement674 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement676 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_whileStatement679 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement681 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_whileStatement684 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement686 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_whileStatement689 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_forStatement701 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement703 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_forStatement706 = new BitSet(new ulong[]{0x0300001A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement709 = new BitSet(new ulong[]{0x0300000A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_forStatementInitialiserPart_in_forStatement712 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement716 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_36_in_forStatement719 = new BitSet(new ulong[]{0x03000012600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement722 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_forStatement725 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement729 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_36_in_forStatement732 = new BitSet(new ulong[]{0x03000003600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement735 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_forStatement738 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement742 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_forStatement745 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement747 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_forStatement750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionNoIn_in_forStatementInitialiserPart762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_forStatementInitialiserPart767 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_forStatementInitialiserPart769 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_variableDeclarationListNoIn_in_forStatementInitialiserPart772 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_forInStatement784 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement786 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_forInStatement789 = new BitSet(new ulong[]{0x0300000A600000F0UL,0x000001E000000000UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement791 = new BitSet(new ulong[]{0x0300000A600000F0UL,0x000001E000000000UL});
    public static readonly BitSet FOLLOW_forInStatementInitialiserPart_in_forInStatement794 = new BitSet(new ulong[]{0x0000080000000010UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement796 = new BitSet(new ulong[]{0x0000080000000010UL});
    public static readonly BitSet FOLLOW_43_in_forInStatement799 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement801 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_forInStatement804 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement806 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_forInStatement809 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement811 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_forInStatement814 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_forInStatementInitialiserPart826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_forInStatementInitialiserPart831 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatementInitialiserPart833 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_variableDeclarationNoIn_in_forInStatementInitialiserPart836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_continueStatement847 = new BitSet(new ulong[]{0x0000001000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_continueStatement849 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_continueStatement852 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_breakStatement869 = new BitSet(new ulong[]{0x0000001000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_breakStatement871 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_breakStatement874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_returnStatement891 = new BitSet(new ulong[]{0x03000012600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_returnStatement893 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_returnStatement896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_withStatement914 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_withStatement916 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_withStatement919 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_withStatement921 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_withStatement924 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_withStatement926 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_withStatement929 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_withStatement931 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_withStatement934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_labelledStatement945 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_labelledStatement947 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_48_in_labelledStatement950 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_labelledStatement952 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_labelledStatement955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_switchStatement967 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement969 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_switchStatement972 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement974 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_switchStatement977 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement979 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_switchStatement982 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement984 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_caseBlock_in_switchStatement987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_caseBlock999 = new BitSet(new ulong[]{0x000C000400000010UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1002 = new BitSet(new ulong[]{0x0004000000000010UL});
    public static readonly BitSet FOLLOW_caseClause_in_caseBlock1005 = new BitSet(new ulong[]{0x000C000400000010UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1010 = new BitSet(new ulong[]{0x0008000000000010UL});
    public static readonly BitSet FOLLOW_defaultClause_in_caseBlock1013 = new BitSet(new ulong[]{0x0004000400000010UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1016 = new BitSet(new ulong[]{0x0004000000000010UL});
    public static readonly BitSet FOLLOW_caseClause_in_caseBlock1019 = new BitSet(new ulong[]{0x0004000400000010UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1025 = new BitSet(new ulong[]{0x0000000400000010UL});
    public static readonly BitSet FOLLOW_34_in_caseBlock1028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_caseClause1039 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_caseClause1041 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_caseClause1044 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_caseClause1046 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_48_in_caseClause1049 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_caseClause1051 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statementList_in_caseClause1056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_defaultClause1071 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_defaultClause1073 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_48_in_defaultClause1076 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_defaultClause1078 = new BitSet(new ulong[]{0x0332F75A600000F2UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statementList_in_defaultClause1083 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_throwStatement1098 = new BitSet(new ulong[]{0x03000002600000E0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_throwStatement1100 = new BitSet(new ulong[]{0x0000001000000010UL});
    public static readonly BitSet FOLLOW_set_in_throwStatement1102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_tryStatement1119 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_LT_in_tryStatement1121 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_statementBlock_in_tryStatement1124 = new BitSet(new ulong[]{0x00C0000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_tryStatement1126 = new BitSet(new ulong[]{0x00C0000000000010UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement1130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_catchClause_in_tryStatement1134 = new BitSet(new ulong[]{0x0080000000000012UL});
    public static readonly BitSet FOLLOW_LT_in_tryStatement1137 = new BitSet(new ulong[]{0x0080000000000010UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_catchClause1161 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1163 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_30_in_catchClause1166 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1168 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_catchClause1171 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1173 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_catchClause1176 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1178 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_statementBlock_in_catchClause1181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_finallyClause1193 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_LT_in_finallyClause1195 = new BitSet(new ulong[]{0x0000000200000010UL});
    public static readonly BitSet FOLLOW_statementBlock_in_finallyClause1198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression1210 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_LT_in_expression1213 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_expression1216 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_expression1218 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression1221 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_expressionNoIn1235 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_LT_in_expressionNoIn1238 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_expressionNoIn1241 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_expressionNoIn1243 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_expressionNoIn1246 = new BitSet(new ulong[]{0x0000000080000012UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_assignmentExpression1260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_assignmentExpression1265 = new BitSet(new ulong[]{0xF000002000000010UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_LT_in_assignmentExpression1267 = new BitSet(new ulong[]{0xF000002000000010UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignmentExpression1270 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_assignmentExpression1272 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_assignmentExpression1275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpressionNoIn_in_assignmentExpressionNoIn1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_assignmentExpressionNoIn1292 = new BitSet(new ulong[]{0xF000002000000010UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_LT_in_assignmentExpressionNoIn1294 = new BitSet(new ulong[]{0xF000002000000010UL,0x000000000000007FUL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignmentExpressionNoIn1297 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_assignmentExpressionNoIn1299 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_assignmentExpressionNoIn1302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callExpression_in_leftHandSideExpression1314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_newExpression_in_leftHandSideExpression1319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberExpression_in_newExpression1331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_newExpression1336 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001E000000000UL});
    public static readonly BitSet FOLLOW_LT_in_newExpression1338 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001E000000000UL});
    public static readonly BitSet FOLLOW_newExpression_in_newExpression1341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_memberExpression1354 = new BitSet(new ulong[]{0x0A00000000000012UL});
    public static readonly BitSet FOLLOW_functionExpression_in_memberExpression1358 = new BitSet(new ulong[]{0x0A00000000000012UL});
    public static readonly BitSet FOLLOW_56_in_memberExpression1362 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001E000000000UL});
    public static readonly BitSet FOLLOW_LT_in_memberExpression1364 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001E000000000UL});
    public static readonly BitSet FOLLOW_memberExpression_in_memberExpression1367 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_memberExpression1369 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_arguments_in_memberExpression1372 = new BitSet(new ulong[]{0x0A00000000000012UL});
    public static readonly BitSet FOLLOW_LT_in_memberExpression1376 = new BitSet(new ulong[]{0x0A00000000000010UL});
    public static readonly BitSet FOLLOW_memberExpressionSuffix_in_memberExpression1379 = new BitSet(new ulong[]{0x0A00000000000012UL});
    public static readonly BitSet FOLLOW_indexSuffix_in_memberExpressionSuffix1393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyReferenceSuffix_in_memberExpressionSuffix1398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberExpression_in_callExpression1409 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_LT_in_callExpression1411 = new BitSet(new ulong[]{0x0000000040000010UL});
    public static readonly BitSet FOLLOW_arguments_in_callExpression1414 = new BitSet(new ulong[]{0x0A00000040000012UL});
    public static readonly BitSet FOLLOW_LT_in_callExpression1417 = new BitSet(new ulong[]{0x0A00000040000010UL});
    public static readonly BitSet FOLLOW_callExpressionSuffix_in_callExpression1420 = new BitSet(new ulong[]{0x0A00000040000012UL});
    public static readonly BitSet FOLLOW_arguments_in_callExpressionSuffix1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_indexSuffix_in_callExpressionSuffix1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyReferenceSuffix_in_callExpressionSuffix1444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_arguments1455 = new BitSet(new ulong[]{0x03000003600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_arguments1458 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arguments1461 = new BitSet(new ulong[]{0x0000000180000010UL});
    public static readonly BitSet FOLLOW_LT_in_arguments1464 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_arguments1467 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_arguments1469 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arguments1472 = new BitSet(new ulong[]{0x0000000180000010UL});
    public static readonly BitSet FOLLOW_LT_in_arguments1478 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_arguments1481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_indexSuffix1493 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_indexSuffix1495 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_indexSuffix1498 = new BitSet(new ulong[]{0x0400000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_indexSuffix1500 = new BitSet(new ulong[]{0x0400000000000010UL});
    public static readonly BitSet FOLLOW_58_in_indexSuffix1503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_propertyReferenceSuffix1516 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_LT_in_propertyReferenceSuffix1518 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_Identifier_in_propertyReferenceSuffix1521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_assignmentOperator0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalORExpression_in_conditionalExpression1588 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression1591 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_conditionalExpression1594 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression1596 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_conditionalExpression1599 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression1601 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_48_in_conditionalExpression1604 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression1606 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_conditionalExpression1609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalORExpressionNoIn_in_conditionalExpressionNoIn1622 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpressionNoIn1625 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_conditionalExpressionNoIn1628 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpressionNoIn1630 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn1633 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpressionNoIn1635 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_48_in_conditionalExpressionNoIn1638 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpressionNoIn1640 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpressionNoIn_in_conditionalExpressionNoIn1643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalANDExpression_in_logicalORExpression1656 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LT_in_logicalORExpression1659 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_logicalORExpression1662 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_logicalORExpression1664 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_logicalANDExpression_in_logicalORExpression1667 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn1681 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LT_in_logicalORExpressionNoIn1684 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_72_in_logicalORExpressionNoIn1687 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_logicalORExpressionNoIn1689 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_logicalANDExpressionNoIn_in_logicalORExpressionNoIn1692 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_bitwiseORExpression_in_logicalANDExpression1706 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_LT_in_logicalANDExpression1709 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_logicalANDExpression1712 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_logicalANDExpression1714 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpression_in_logicalANDExpression1717 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1731 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_LT_in_logicalANDExpressionNoIn1734 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_logicalANDExpressionNoIn1737 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_logicalANDExpressionNoIn1739 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpressionNoIn_in_logicalANDExpressionNoIn1742 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpression_in_bitwiseORExpression1756 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseORExpression1759 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_bitwiseORExpression1762 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseORExpression1764 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpression_in_bitwiseORExpression1767 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1781 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseORExpressionNoIn1784 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_74_in_bitwiseORExpressionNoIn1787 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseORExpressionNoIn1789 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpressionNoIn_in_bitwiseORExpressionNoIn1792 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression1806 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseXORExpression1809 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_bitwiseXORExpression1812 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseXORExpression1814 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression1817 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1831 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseXORExpressionNoIn1834 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_75_in_bitwiseXORExpressionNoIn1837 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseXORExpressionNoIn1839 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpressionNoIn_in_bitwiseXORExpressionNoIn1842 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000000800UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseANDExpression1856 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseANDExpression1859 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_bitwiseANDExpression1862 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseANDExpression1864 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseANDExpression1867 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1881 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseANDExpressionNoIn1884 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_bitwiseANDExpressionNoIn1887 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseANDExpressionNoIn1889 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_equalityExpressionNoIn_in_bitwiseANDExpressionNoIn1892 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1906 = new BitSet(new ulong[]{0x0000000000000012UL,0x000000000001E000UL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression1909 = new BitSet(new ulong[]{0x0000000000000010UL,0x000000000001E000UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression1912 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression1928 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1931 = new BitSet(new ulong[]{0x0000000000000012UL,0x000000000001E000UL});
    public static readonly BitSet FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn1944 = new BitSet(new ulong[]{0x0000000000000012UL,0x000000000001E000UL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpressionNoIn1947 = new BitSet(new ulong[]{0x0000000000000010UL,0x000000000001E000UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpressionNoIn1950 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpressionNoIn1966 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_relationalExpressionNoIn_in_equalityExpressionNoIn1969 = new BitSet(new ulong[]{0x0000000000000012UL,0x000000000001E000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression1983 = new BitSet(new ulong[]{0x0000080000000012UL,0x00000000003E0000UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression1986 = new BitSet(new ulong[]{0x0000080000000010UL,0x00000000003E0000UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression1989 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2013 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2016 = new BitSet(new ulong[]{0x0000080000000012UL,0x00000000003E0000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpressionNoIn2029 = new BitSet(new ulong[]{0x0000000000000012UL,0x00000000003E0000UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpressionNoIn2032 = new BitSet(new ulong[]{0x0000000000000010UL,0x00000000003E0000UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpressionNoIn2035 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpressionNoIn2055 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpressionNoIn2058 = new BitSet(new ulong[]{0x0000000000000012UL,0x00000000003E0000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression2071 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000001C00000UL});
    public static readonly BitSet FOLLOW_LT_in_shiftExpression2074 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000001C00000UL});
    public static readonly BitSet FOLLOW_set_in_shiftExpression2077 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_shiftExpression2089 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression2092 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000001C00000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression2105 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_LT_in_additiveExpression2108 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_set_in_additiveExpression2111 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_additiveExpression2119 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression2122 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression2135 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000038000000UL});
    public static readonly BitSet FOLLOW_LT_in_multiplicativeExpression2138 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000038000000UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression2141 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_multiplicativeExpression2153 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression2156 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000038000000UL});
    public static readonly BitSet FOLLOW_postfixExpression_in_unaryExpression2169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpression2174 = new BitSet(new ulong[]{0x03000002600000E0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_postfixExpression2222 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000600000000UL});
    public static readonly BitSet FOLLOW_set_in_postfixExpression2224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_101_in_primaryExpression2242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_primaryExpression2247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression2252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayLiteral_in_primaryExpression2257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectLiteral_in_primaryExpression2262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_primaryExpression2267 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_primaryExpression2269 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_expression_in_primaryExpression2272 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_LT_in_primaryExpression2274 = new BitSet(new ulong[]{0x0000000100000010UL});
    public static readonly BitSet FOLLOW_32_in_primaryExpression2277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_arrayLiteral2290 = new BitSet(new ulong[]{0x07000002E00000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_arrayLiteral2292 = new BitSet(new ulong[]{0x07000002E00000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arrayLiteral2295 = new BitSet(new ulong[]{0x0400000080000010UL});
    public static readonly BitSet FOLLOW_LT_in_arrayLiteral2299 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_arrayLiteral2302 = new BitSet(new ulong[]{0x07000002E00000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_arrayLiteral2305 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arrayLiteral2308 = new BitSet(new ulong[]{0x0400000080000010UL});
    public static readonly BitSet FOLLOW_LT_in_arrayLiteral2314 = new BitSet(new ulong[]{0x0400000000000010UL});
    public static readonly BitSet FOLLOW_58_in_arrayLiteral2317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_objectLiteral2336 = new BitSet(new ulong[]{0x00000000000000F0UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral2338 = new BitSet(new ulong[]{0x00000000000000F0UL});
    public static readonly BitSet FOLLOW_propertyNameAndValue_in_objectLiteral2341 = new BitSet(new ulong[]{0x0000000480000010UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral2344 = new BitSet(new ulong[]{0x0000000080000010UL});
    public static readonly BitSet FOLLOW_31_in_objectLiteral2347 = new BitSet(new ulong[]{0x00000000000000F0UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral2349 = new BitSet(new ulong[]{0x00000000000000F0UL});
    public static readonly BitSet FOLLOW_propertyNameAndValue_in_objectLiteral2352 = new BitSet(new ulong[]{0x0000000480000010UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral2356 = new BitSet(new ulong[]{0x0000000400000010UL});
    public static readonly BitSet FOLLOW_34_in_objectLiteral2359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyName_in_propertyNameAndValue2371 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_propertyNameAndValue2373 = new BitSet(new ulong[]{0x0001000000000010UL});
    public static readonly BitSet FOLLOW_48_in_propertyNameAndValue2376 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_propertyNameAndValue2378 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_propertyNameAndValue2381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_propertyName0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_synpred5_JavaScript89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred9_JavaScript140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statementBlock_in_synpred21_JavaScript229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionStatement_in_synpred24_JavaScript248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_labelledStatement_in_synpred31_JavaScript299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred34_JavaScript332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred47_JavaScript450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred49_JavaScript468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred60_JavaScript577 = new BitSet(new ulong[]{0x0000008000000010UL});
    public static readonly BitSet FOLLOW_39_in_synpred60_JavaScript580 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_synpred60_JavaScript582 = new BitSet(new ulong[]{0x0332F75A600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_statement_in_synpred60_JavaScript587 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_synpred63_JavaScript613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred118_JavaScript1051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred121_JavaScript1078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_synpred140_JavaScript1260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpressionNoIn_in_synpred143_JavaScript1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_callExpression_in_synpred146_JavaScript1314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_memberExpression_in_synpred147_JavaScript1331 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred154_JavaScript1376 = new BitSet(new ulong[]{0x0A00000000000010UL});
    public static readonly BitSet FOLLOW_memberExpressionSuffix_in_synpred154_JavaScript1379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred158_JavaScript1417 = new BitSet(new ulong[]{0x0A00000040000010UL});
    public static readonly BitSet FOLLOW_callExpressionSuffix_in_synpred158_JavaScript1420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred256_JavaScript2108 = new BitSet(new ulong[]{0x0000000000000010UL,0x0000000006000000UL});
    public static readonly BitSet FOLLOW_set_in_synpred256_JavaScript2111 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_LT_in_synpred256_JavaScript2119 = new BitSet(new ulong[]{0x03000002600000F0UL,0x000001FFC6000000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_synpred256_JavaScript2122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred280_JavaScript2292 = new BitSet(new ulong[]{0x0000000000000002UL});

}
