// $ANTLR 3.1.2 JavaScript.g 2009-06-19 16:33:37

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

public partial class JavaScriptLexer : Lexer {
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
    public const int NumericLiteral = 7;
    public const int T__81 = 81;
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

    public JavaScriptLexer() 
    {
		InitializeCyclicDFAs();
    }
    public JavaScriptLexer(ICharStream input)
		: this(input, null) {
    }
    public JavaScriptLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "JavaScript.g";} 
    }

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:7:7: ( 'function' )
            // JavaScript.g:7:9: 'function'
            {
            	Match("function"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:8:7: ( '(' )
            // JavaScript.g:8:9: '('
            {
            	Match('('); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:9:7: ( ',' )
            // JavaScript.g:9:9: ','
            {
            	Match(','); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:10:7: ( ')' )
            // JavaScript.g:10:9: ')'
            {
            	Match(')'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:11:7: ( '{' )
            // JavaScript.g:11:9: '{'
            {
            	Match('{'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:12:7: ( '}' )
            // JavaScript.g:12:9: '}'
            {
            	Match('}'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:13:7: ( 'var' )
            // JavaScript.g:13:9: 'var'
            {
            	Match("var"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:14:7: ( ';' )
            // JavaScript.g:14:9: ';'
            {
            	Match(';'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:15:7: ( '=' )
            // JavaScript.g:15:9: '='
            {
            	Match('='); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:16:7: ( 'if' )
            // JavaScript.g:16:9: 'if'
            {
            	Match("if"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:17:7: ( 'else' )
            // JavaScript.g:17:9: 'else'
            {
            	Match("else"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:18:7: ( 'do' )
            // JavaScript.g:18:9: 'do'
            {
            	Match("do"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:19:7: ( 'while' )
            // JavaScript.g:19:9: 'while'
            {
            	Match("while"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:20:7: ( 'for' )
            // JavaScript.g:20:9: 'for'
            {
            	Match("for"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:21:7: ( 'in' )
            // JavaScript.g:21:9: 'in'
            {
            	Match("in"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:22:7: ( 'continue' )
            // JavaScript.g:22:9: 'continue'
            {
            	Match("continue"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:23:7: ( 'break' )
            // JavaScript.g:23:9: 'break'
            {
            	Match("break"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:24:7: ( 'return' )
            // JavaScript.g:24:9: 'return'
            {
            	Match("return"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:25:7: ( 'with' )
            // JavaScript.g:25:9: 'with'
            {
            	Match("with"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:26:7: ( ':' )
            // JavaScript.g:26:9: ':'
            {
            	Match(':'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:27:7: ( 'switch' )
            // JavaScript.g:27:9: 'switch'
            {
            	Match("switch"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:28:7: ( 'case' )
            // JavaScript.g:28:9: 'case'
            {
            	Match("case"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:29:7: ( 'default' )
            // JavaScript.g:29:9: 'default'
            {
            	Match("default"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:30:7: ( 'throw' )
            // JavaScript.g:30:9: 'throw'
            {
            	Match("throw"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:31:7: ( 'try' )
            // JavaScript.g:31:9: 'try'
            {
            	Match("try"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:32:7: ( 'catch' )
            // JavaScript.g:32:9: 'catch'
            {
            	Match("catch"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:33:7: ( 'finally' )
            // JavaScript.g:33:9: 'finally'
            {
            	Match("finally"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:34:7: ( 'new' )
            // JavaScript.g:34:9: 'new'
            {
            	Match("new"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:35:7: ( '[' )
            // JavaScript.g:35:9: '['
            {
            	Match('['); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:36:7: ( ']' )
            // JavaScript.g:36:9: ']'
            {
            	Match(']'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:37:7: ( '.' )
            // JavaScript.g:37:9: '.'
            {
            	Match('.'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:38:7: ( '*=' )
            // JavaScript.g:38:9: '*='
            {
            	Match("*="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:39:7: ( '/=' )
            // JavaScript.g:39:9: '/='
            {
            	Match("/="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:40:7: ( '%=' )
            // JavaScript.g:40:9: '%='
            {
            	Match("%="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:41:7: ( '+=' )
            // JavaScript.g:41:9: '+='
            {
            	Match("+="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:42:7: ( '-=' )
            // JavaScript.g:42:9: '-='
            {
            	Match("-="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:43:7: ( '<<=' )
            // JavaScript.g:43:9: '<<='
            {
            	Match("<<="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:44:7: ( '>>=' )
            // JavaScript.g:44:9: '>>='
            {
            	Match(">>="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:45:7: ( '>>>=' )
            // JavaScript.g:45:9: '>>>='
            {
            	Match(">>>="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:46:7: ( '&=' )
            // JavaScript.g:46:9: '&='
            {
            	Match("&="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:47:7: ( '^=' )
            // JavaScript.g:47:9: '^='
            {
            	Match("^="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:48:7: ( '|=' )
            // JavaScript.g:48:9: '|='
            {
            	Match("|="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:49:7: ( '?' )
            // JavaScript.g:49:9: '?'
            {
            	Match('?'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:50:7: ( '||' )
            // JavaScript.g:50:9: '||'
            {
            	Match("||"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:51:7: ( '&&' )
            // JavaScript.g:51:9: '&&'
            {
            	Match("&&"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:52:7: ( '|' )
            // JavaScript.g:52:9: '|'
            {
            	Match('|'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:53:7: ( '^' )
            // JavaScript.g:53:9: '^'
            {
            	Match('^'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:54:7: ( '&' )
            // JavaScript.g:54:9: '&'
            {
            	Match('&'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:55:7: ( '==' )
            // JavaScript.g:55:9: '=='
            {
            	Match("=="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:56:7: ( '!=' )
            // JavaScript.g:56:9: '!='
            {
            	Match("!="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:57:7: ( '===' )
            // JavaScript.g:57:9: '==='
            {
            	Match("==="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:58:7: ( '!==' )
            // JavaScript.g:58:9: '!=='
            {
            	Match("!=="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:59:7: ( '<' )
            // JavaScript.g:59:9: '<'
            {
            	Match('<'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public void mT__82() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__82;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:60:7: ( '>' )
            // JavaScript.g:60:9: '>'
            {
            	Match('>'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public void mT__83() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__83;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:61:7: ( '<=' )
            // JavaScript.g:61:9: '<='
            {
            	Match("<="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public void mT__84() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__84;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:62:7: ( '>=' )
            // JavaScript.g:62:9: '>='
            {
            	Match(">="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__84"

    // $ANTLR start "T__85"
    public void mT__85() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__85;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:63:7: ( 'instanceof' )
            // JavaScript.g:63:9: 'instanceof'
            {
            	Match("instanceof"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__85"

    // $ANTLR start "T__86"
    public void mT__86() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__86;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:64:7: ( '<<' )
            // JavaScript.g:64:9: '<<'
            {
            	Match("<<"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__86"

    // $ANTLR start "T__87"
    public void mT__87() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__87;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:65:7: ( '>>' )
            // JavaScript.g:65:9: '>>'
            {
            	Match(">>"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__87"

    // $ANTLR start "T__88"
    public void mT__88() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__88;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:66:7: ( '>>>' )
            // JavaScript.g:66:9: '>>>'
            {
            	Match(">>>"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__88"

    // $ANTLR start "T__89"
    public void mT__89() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__89;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:67:7: ( '+' )
            // JavaScript.g:67:9: '+'
            {
            	Match('+'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__89"

    // $ANTLR start "T__90"
    public void mT__90() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__90;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:68:7: ( '-' )
            // JavaScript.g:68:9: '-'
            {
            	Match('-'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__90"

    // $ANTLR start "T__91"
    public void mT__91() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__91;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:69:7: ( '*' )
            // JavaScript.g:69:9: '*'
            {
            	Match('*'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__91"

    // $ANTLR start "T__92"
    public void mT__92() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__92;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:70:7: ( '/' )
            // JavaScript.g:70:9: '/'
            {
            	Match('/'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__92"

    // $ANTLR start "T__93"
    public void mT__93() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__93;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:71:7: ( '%' )
            // JavaScript.g:71:9: '%'
            {
            	Match('%'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__93"

    // $ANTLR start "T__94"
    public void mT__94() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__94;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:72:7: ( 'delete' )
            // JavaScript.g:72:9: 'delete'
            {
            	Match("delete"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__94"

    // $ANTLR start "T__95"
    public void mT__95() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__95;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:73:7: ( 'void' )
            // JavaScript.g:73:9: 'void'
            {
            	Match("void"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__95"

    // $ANTLR start "T__96"
    public void mT__96() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__96;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:74:7: ( 'typeof' )
            // JavaScript.g:74:9: 'typeof'
            {
            	Match("typeof"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__96"

    // $ANTLR start "T__97"
    public void mT__97() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__97;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:75:7: ( '++' )
            // JavaScript.g:75:9: '++'
            {
            	Match("++"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__97"

    // $ANTLR start "T__98"
    public void mT__98() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__98;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:76:7: ( '--' )
            // JavaScript.g:76:9: '--'
            {
            	Match("--"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__98"

    // $ANTLR start "T__99"
    public void mT__99() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__99;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:77:7: ( '~' )
            // JavaScript.g:77:9: '~'
            {
            	Match('~'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__99"

    // $ANTLR start "T__100"
    public void mT__100() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__100;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:78:8: ( '!' )
            // JavaScript.g:78:10: '!'
            {
            	Match('!'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__100"

    // $ANTLR start "T__101"
    public void mT__101() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__101;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:79:8: ( 'this' )
            // JavaScript.g:79:10: 'this'
            {
            	Match("this"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__101"

    // $ANTLR start "T__102"
    public void mT__102() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__102;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:80:8: ( 'null' )
            // JavaScript.g:80:10: 'null'
            {
            	Match("null"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__102"

    // $ANTLR start "T__103"
    public void mT__103() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__103;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:81:8: ( 'true' )
            // JavaScript.g:81:10: 'true'
            {
            	Match("true"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__103"

    // $ANTLR start "T__104"
    public void mT__104() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__104;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:82:8: ( 'false' )
            // JavaScript.g:82:10: 'false'
            {
            	Match("false"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__104"

    // $ANTLR start "StringLiteral"
    public void mStringLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = StringLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:489:2: ( '\"' ( DoubleStringCharacter )* '\"' | '\\'' ( SingleStringCharacter )* '\\'' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == '\"') )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == '\'') )
            {
                alt3 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // JavaScript.g:489:4: '\"' ( DoubleStringCharacter )* '\"'
                    {
                    	Match('\"'); if (state.failed) return ;
                    	// JavaScript.g:489:8: ( DoubleStringCharacter )*
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t') || (LA1_0 >= '\u000B' && LA1_0 <= '\f') || (LA1_0 >= '\u000E' && LA1_0 <= '!') || (LA1_0 >= '#' && LA1_0 <= '\u2027') || (LA1_0 >= '\u202A' && LA1_0 <= '\uFFFF')) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:489:8: DoubleStringCharacter
                    			    {
                    			    	mDoubleStringCharacter(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop1;
                    	    }
                    	} while (true);

                    	loop1:
                    		;	// Stops C# compiler whining that label 'loop1' has no statements

                    	Match('\"'); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:490:4: '\\'' ( SingleStringCharacter )* '\\''
                    {
                    	Match('\''); if (state.failed) return ;
                    	// JavaScript.g:490:9: ( SingleStringCharacter )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\t') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '&') || (LA2_0 >= '(' && LA2_0 <= '\u2027') || (LA2_0 >= '\u202A' && LA2_0 <= '\uFFFF')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:490:9: SingleStringCharacter
                    			    {
                    			    	mSingleStringCharacter(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	Match('\''); if (state.failed) return ;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "StringLiteral"

    // $ANTLR start "DoubleStringCharacter"
    public void mDoubleStringCharacter() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:494:2: (~ ( '\"' | '\\\\' | LT ) | '\\\\' EscapeSequence )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( ((LA4_0 >= '\u0000' && LA4_0 <= '\t') || (LA4_0 >= '\u000B' && LA4_0 <= '\f') || (LA4_0 >= '\u000E' && LA4_0 <= '!') || (LA4_0 >= '#' && LA4_0 <= '[') || (LA4_0 >= ']' && LA4_0 <= '\u2027') || (LA4_0 >= '\u202A' && LA4_0 <= '\uFFFF')) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == '\\') )
            {
                alt4 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // JavaScript.g:494:4: ~ ( '\"' | '\\\\' | LT )
                    {
                    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\u2027') || (input.LA(1) >= '\u202A' && input.LA(1) <= '\uFFFF') ) 
                    	{
                    	    input.Consume();
                    	state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // JavaScript.g:495:4: '\\\\' EscapeSequence
                    {
                    	Match('\\'); if (state.failed) return ;
                    	mEscapeSequence(); if (state.failed) return ;

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DoubleStringCharacter"

    // $ANTLR start "SingleStringCharacter"
    public void mSingleStringCharacter() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:499:2: (~ ( '\\'' | '\\\\' | LT ) | '\\\\' EscapeSequence )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( ((LA5_0 >= '\u0000' && LA5_0 <= '\t') || (LA5_0 >= '\u000B' && LA5_0 <= '\f') || (LA5_0 >= '\u000E' && LA5_0 <= '&') || (LA5_0 >= '(' && LA5_0 <= '[') || (LA5_0 >= ']' && LA5_0 <= '\u2027') || (LA5_0 >= '\u202A' && LA5_0 <= '\uFFFF')) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == '\\') )
            {
                alt5 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // JavaScript.g:499:4: ~ ( '\\'' | '\\\\' | LT )
                    {
                    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\u2027') || (input.LA(1) >= '\u202A' && input.LA(1) <= '\uFFFF') ) 
                    	{
                    	    input.Consume();
                    	state.failed = false;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // JavaScript.g:500:4: '\\\\' EscapeSequence
                    {
                    	Match('\\'); if (state.failed) return ;
                    	mEscapeSequence(); if (state.failed) return ;

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SingleStringCharacter"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:504:2: ( CharacterEscapeSequence | '0' | HexEscapeSequence | UnicodeEscapeSequence )
            int alt6 = 4;
            int LA6_0 = input.LA(1);

            if ( ((LA6_0 >= '\u0000' && LA6_0 <= '\t') || (LA6_0 >= '\u000B' && LA6_0 <= '\f') || (LA6_0 >= '\u000E' && LA6_0 <= '/') || (LA6_0 >= ':' && LA6_0 <= 't') || (LA6_0 >= 'v' && LA6_0 <= 'w') || (LA6_0 >= 'y' && LA6_0 <= '\u2027') || (LA6_0 >= '\u202A' && LA6_0 <= '\uFFFF')) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == '0') )
            {
                alt6 = 2;
            }
            else if ( (LA6_0 == 'x') )
            {
                alt6 = 3;
            }
            else if ( (LA6_0 == 'u') )
            {
                alt6 = 4;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // JavaScript.g:504:4: CharacterEscapeSequence
                    {
                    	mCharacterEscapeSequence(); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:505:4: '0'
                    {
                    	Match('0'); if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // JavaScript.g:506:4: HexEscapeSequence
                    {
                    	mHexEscapeSequence(); if (state.failed) return ;

                    }
                    break;
                case 4 :
                    // JavaScript.g:507:4: UnicodeEscapeSequence
                    {
                    	mUnicodeEscapeSequence(); if (state.failed) return ;

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "CharacterEscapeSequence"
    public void mCharacterEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:511:2: ( SingleEscapeCharacter | NonEscapeCharacter )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == '\"' || LA7_0 == '\'' || LA7_0 == '\\' || LA7_0 == 'b' || LA7_0 == 'f' || LA7_0 == 'n' || LA7_0 == 'r' || LA7_0 == 't' || LA7_0 == 'v') )
            {
                alt7 = 1;
            }
            else if ( ((LA7_0 >= '\u0000' && LA7_0 <= '\t') || (LA7_0 >= '\u000B' && LA7_0 <= '\f') || (LA7_0 >= '\u000E' && LA7_0 <= '!') || (LA7_0 >= '#' && LA7_0 <= '&') || (LA7_0 >= '(' && LA7_0 <= '/') || (LA7_0 >= ':' && LA7_0 <= '[') || (LA7_0 >= ']' && LA7_0 <= 'a') || (LA7_0 >= 'c' && LA7_0 <= 'e') || (LA7_0 >= 'g' && LA7_0 <= 'm') || (LA7_0 >= 'o' && LA7_0 <= 'q') || LA7_0 == 's' || LA7_0 == 'w' || (LA7_0 >= 'y' && LA7_0 <= '\u2027') || (LA7_0 >= '\u202A' && LA7_0 <= '\uFFFF')) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // JavaScript.g:511:4: SingleEscapeCharacter
                    {
                    	mSingleEscapeCharacter(); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:512:4: NonEscapeCharacter
                    {
                    	mNonEscapeCharacter(); if (state.failed) return ;

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CharacterEscapeSequence"

    // $ANTLR start "NonEscapeCharacter"
    public void mNonEscapeCharacter() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:516:2: (~ ( EscapeCharacter | LT ) )
            // JavaScript.g:516:4: ~ ( EscapeCharacter | LT )
            {
            	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '/') || (input.LA(1) >= ':' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= 'a') || (input.LA(1) >= 'c' && input.LA(1) <= 'e') || (input.LA(1) >= 'g' && input.LA(1) <= 'm') || (input.LA(1) >= 'o' && input.LA(1) <= 'q') || input.LA(1) == 's' || input.LA(1) == 'w' || (input.LA(1) >= 'y' && input.LA(1) <= '\u2027') || (input.LA(1) >= '\u202A' && input.LA(1) <= '\uFFFF') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "NonEscapeCharacter"

    // $ANTLR start "SingleEscapeCharacter"
    public void mSingleEscapeCharacter() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:520:2: ( '\\'' | '\"' | '\\\\' | 'b' | 'f' | 'n' | 'r' | 't' | 'v' )
            // JavaScript.g:
            {
            	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'b' || input.LA(1) == 'f' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' || input.LA(1) == 'v' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "SingleEscapeCharacter"

    // $ANTLR start "EscapeCharacter"
    public void mEscapeCharacter() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:524:2: ( SingleEscapeCharacter | DecimalDigit | 'x' | 'u' )
            int alt8 = 4;
            switch ( input.LA(1) ) 
            {
            case '\"':
            case '\'':
            case '\\':
            case 'b':
            case 'f':
            case 'n':
            case 'r':
            case 't':
            case 'v':
            	{
                alt8 = 1;
                }
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            	{
                alt8 = 2;
                }
                break;
            case 'x':
            	{
                alt8 = 3;
                }
                break;
            case 'u':
            	{
                alt8 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // JavaScript.g:524:4: SingleEscapeCharacter
                    {
                    	mSingleEscapeCharacter(); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:525:4: DecimalDigit
                    {
                    	mDecimalDigit(); if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // JavaScript.g:526:4: 'x'
                    {
                    	Match('x'); if (state.failed) return ;

                    }
                    break;
                case 4 :
                    // JavaScript.g:527:4: 'u'
                    {
                    	Match('u'); if (state.failed) return ;

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeCharacter"

    // $ANTLR start "HexEscapeSequence"
    public void mHexEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:531:2: ( 'x' HexDigit HexDigit )
            // JavaScript.g:531:4: 'x' HexDigit HexDigit
            {
            	Match('x'); if (state.failed) return ;
            	mHexDigit(); if (state.failed) return ;
            	mHexDigit(); if (state.failed) return ;

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexEscapeSequence"

    // $ANTLR start "UnicodeEscapeSequence"
    public void mUnicodeEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:535:2: ( 'u' HexDigit HexDigit HexDigit HexDigit )
            // JavaScript.g:535:4: 'u' HexDigit HexDigit HexDigit HexDigit
            {
            	Match('u'); if (state.failed) return ;
            	mHexDigit(); if (state.failed) return ;
            	mHexDigit(); if (state.failed) return ;
            	mHexDigit(); if (state.failed) return ;
            	mHexDigit(); if (state.failed) return ;

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeEscapeSequence"

    // $ANTLR start "NumericLiteral"
    public void mNumericLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NumericLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:539:2: ( DecimalLiteral | HexIntegerLiteral )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == '0') )
            {
                int LA9_1 = input.LA(2);

                if ( (LA9_1 == 'X' || LA9_1 == 'x') )
                {
                    alt9 = 2;
                }
                else 
                {
                    alt9 = 1;}
            }
            else if ( (LA9_0 == '.' || (LA9_0 >= '1' && LA9_0 <= '9')) )
            {
                alt9 = 1;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // JavaScript.g:539:4: DecimalLiteral
                    {
                    	mDecimalLiteral(); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:540:4: HexIntegerLiteral
                    {
                    	mHexIntegerLiteral(); if (state.failed) return ;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NumericLiteral"

    // $ANTLR start "HexIntegerLiteral"
    public void mHexIntegerLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:544:2: ( '0' ( 'x' | 'X' ) ( HexDigit )+ )
            // JavaScript.g:544:4: '0' ( 'x' | 'X' ) ( HexDigit )+
            {
            	Match('0'); if (state.failed) return ;
            	if ( input.LA(1) == 'X' || input.LA(1) == 'x' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// JavaScript.g:544:20: ( HexDigit )+
            	int cnt10 = 0;
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= '0' && LA10_0 <= '9') || (LA10_0 >= 'A' && LA10_0 <= 'F') || (LA10_0 >= 'a' && LA10_0 <= 'f')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // JavaScript.g:544:20: HexDigit
            			    {
            			    	mHexDigit(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    if ( cnt10 >= 1 ) goto loop10;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee10 =
            		                new EarlyExitException(10, input);
            		            throw eee10;
            	    }
            	    cnt10++;
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexIntegerLiteral"

    // $ANTLR start "HexDigit"
    public void mHexDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:548:2: ( DecimalDigit | ( 'a' .. 'f' ) | ( 'A' .. 'F' ) )
            int alt11 = 3;
            switch ( input.LA(1) ) 
            {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            	{
                alt11 = 1;
                }
                break;
            case 'a':
            case 'b':
            case 'c':
            case 'd':
            case 'e':
            case 'f':
            	{
                alt11 = 2;
                }
                break;
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            case 'E':
            case 'F':
            	{
                alt11 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d11s0 =
            	        new NoViableAltException("", 11, 0, input);

            	    throw nvae_d11s0;
            }

            switch (alt11) 
            {
                case 1 :
                    // JavaScript.g:548:4: DecimalDigit
                    {
                    	mDecimalDigit(); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:548:19: ( 'a' .. 'f' )
                    {
                    	// JavaScript.g:548:19: ( 'a' .. 'f' )
                    	// JavaScript.g:548:20: 'a' .. 'f'
                    	{
                    		MatchRange('a','f'); if (state.failed) return ;

                    	}


                    }
                    break;
                case 3 :
                    // JavaScript.g:548:32: ( 'A' .. 'F' )
                    {
                    	// JavaScript.g:548:32: ( 'A' .. 'F' )
                    	// JavaScript.g:548:33: 'A' .. 'F'
                    	{
                    		MatchRange('A','F'); if (state.failed) return ;

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "HexDigit"

    // $ANTLR start "DecimalLiteral"
    public void mDecimalLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:552:2: ( ( DecimalDigit )+ '.' ( DecimalDigit )* ( ExponentPart )? | ( '.' )? ( DecimalDigit )+ ( ExponentPart )? )
            int alt18 = 2;
            alt18 = dfa18.Predict(input);
            switch (alt18) 
            {
                case 1 :
                    // JavaScript.g:552:4: ( DecimalDigit )+ '.' ( DecimalDigit )* ( ExponentPart )?
                    {
                    	// JavaScript.g:552:4: ( DecimalDigit )+
                    	int cnt12 = 0;
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( ((LA12_0 >= '0' && LA12_0 <= '9')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:552:4: DecimalDigit
                    			    {
                    			    	mDecimalDigit(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt12 >= 1 ) goto loop12;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    		            EarlyExitException eee12 =
                    		                new EarlyExitException(12, input);
                    		            throw eee12;
                    	    }
                    	    cnt12++;
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whinging that label 'loop12' has no statements

                    	Match('.'); if (state.failed) return ;
                    	// JavaScript.g:552:22: ( DecimalDigit )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( ((LA13_0 >= '0' && LA13_0 <= '9')) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:552:22: DecimalDigit
                    			    {
                    			    	mDecimalDigit(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements

                    	// JavaScript.g:552:36: ( ExponentPart )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == 'E' || LA14_0 == 'e') )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // JavaScript.g:552:36: ExponentPart
                    	        {
                    	        	mExponentPart(); if (state.failed) return ;

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // JavaScript.g:553:4: ( '.' )? ( DecimalDigit )+ ( ExponentPart )?
                    {
                    	// JavaScript.g:553:4: ( '.' )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( (LA15_0 == '.') )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // JavaScript.g:553:4: '.'
                    	        {
                    	        	Match('.'); if (state.failed) return ;

                    	        }
                    	        break;

                    	}

                    	// JavaScript.g:553:9: ( DecimalDigit )+
                    	int cnt16 = 0;
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( ((LA16_0 >= '0' && LA16_0 <= '9')) )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:553:9: DecimalDigit
                    			    {
                    			    	mDecimalDigit(); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt16 >= 1 ) goto loop16;
                    			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    		            EarlyExitException eee16 =
                    		                new EarlyExitException(16, input);
                    		            throw eee16;
                    	    }
                    	    cnt16++;
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whinging that label 'loop16' has no statements

                    	// JavaScript.g:553:23: ( ExponentPart )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == 'E' || LA17_0 == 'e') )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // JavaScript.g:553:23: ExponentPart
                    	        {
                    	        	mExponentPart(); if (state.failed) return ;

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DecimalLiteral"

    // $ANTLR start "DecimalDigit"
    public void mDecimalDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:557:2: ( ( '0' .. '9' ) )
            // JavaScript.g:557:4: ( '0' .. '9' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DecimalDigit"

    // $ANTLR start "ExponentPart"
    public void mExponentPart() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:561:2: ( ( 'e' | 'E' ) ( '+' | '-' )? ( DecimalDigit )+ )
            // JavaScript.g:561:4: ( 'e' | 'E' ) ( '+' | '-' )? ( DecimalDigit )+
            {
            	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// JavaScript.g:561:16: ( '+' | '-' )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == '+' || LA19_0 == '-') )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // JavaScript.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();
            	        	state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// JavaScript.g:561:30: ( DecimalDigit )+
            	int cnt20 = 0;
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= '0' && LA20_0 <= '9')) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // JavaScript.g:561:30: DecimalDigit
            			    {
            			    	mDecimalDigit(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    if ( cnt20 >= 1 ) goto loop20;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee20 =
            		                new EarlyExitException(20, input);
            		            throw eee20;
            	    }
            	    cnt20++;
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whinging that label 'loop20' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ExponentPart"

    // $ANTLR start "Identifier"
    public void mIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:565:2: ( IdentifierStart ( IdentifierPart )* )
            // JavaScript.g:565:4: IdentifierStart ( IdentifierPart )*
            {
            	mIdentifierStart(); if (state.failed) return ;
            	// JavaScript.g:565:20: ( IdentifierPart )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == '$' || (LA21_0 >= '0' && LA21_0 <= '9') || (LA21_0 >= 'A' && LA21_0 <= 'Z') || LA21_0 == '_' || (LA21_0 >= 'a' && LA21_0 <= 'z')) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // JavaScript.g:565:20: IdentifierPart
            			    {
            			    	mIdentifierPart(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Identifier"

    // $ANTLR start "IdentifierStart"
    public void mIdentifierStart() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:569:2: ( UnicodeLetter | '$' | '_' )
            // JavaScript.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "IdentifierStart"

    // $ANTLR start "IdentifierPart"
    public void mIdentifierPart() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:575:2: ( ( IdentifierStart )=> IdentifierStart | UnicodeDigit )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == '$' || (LA22_0 >= 'A' && LA22_0 <= 'Z') || LA22_0 == '_' || (LA22_0 >= 'a' && LA22_0 <= 'z')) && (synpred1_JavaScript()) )
            {
                alt22 = 1;
            }
            else if ( ((LA22_0 >= '0' && LA22_0 <= '9')) )
            {
                alt22 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // JavaScript.g:575:4: ( IdentifierStart )=> IdentifierStart
                    {
                    	mIdentifierStart(); if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // JavaScript.g:576:4: UnicodeDigit
                    {
                    	mUnicodeDigit(); if (state.failed) return ;

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IdentifierPart"

    // $ANTLR start "UnicodeLetter"
    public void mUnicodeLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:580:2: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
            // JavaScript.g:580:4: ( 'a' .. 'z' | 'A' .. 'Z' )
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeLetter"

    // $ANTLR start "UnicodeDigit"
    public void mUnicodeDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // JavaScript.g:583:2: ( '0' .. '9' )
            // JavaScript.g:583:4: '0' .. '9'
            {
            	MatchRange('0','9'); if (state.failed) return ;

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeDigit"

    // $ANTLR start "Comment"
    public void mComment() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Comment;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:586:2: ( '/*' ( options {greedy=false; } : . )* '*/' )
            // JavaScript.g:586:4: '/*' ( options {greedy=false; } : . )* '*/'
            {
            	Match("/*"); if (state.failed) return ;

            	// JavaScript.g:586:9: ( options {greedy=false; } : . )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == '*') )
            	    {
            	        int LA23_1 = input.LA(2);

            	        if ( (LA23_1 == '/') )
            	        {
            	            alt23 = 2;
            	        }
            	        else if ( ((LA23_1 >= '\u0000' && LA23_1 <= '.') || (LA23_1 >= '0' && LA23_1 <= '\uFFFF')) )
            	        {
            	            alt23 = 1;
            	        }


            	    }
            	    else if ( ((LA23_0 >= '\u0000' && LA23_0 <= ')') || (LA23_0 >= '+' && LA23_0 <= '\uFFFF')) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // JavaScript.g:586:36: .
            			    {
            			    	MatchAny(); if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	Match("*/"); if (state.failed) return ;

            	if ( (state.backtracking==0) )
            	{
            	  _channel=HIDDEN;
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Comment"

    // $ANTLR start "LineComment"
    public void mLineComment() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LineComment;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:590:2: ( '//' (~ ( LT ) )* )
            // JavaScript.g:590:4: '//' (~ ( LT ) )*
            {
            	Match("//"); if (state.failed) return ;

            	// JavaScript.g:590:9: (~ ( LT ) )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= '\u0000' && LA24_0 <= '\t') || (LA24_0 >= '\u000B' && LA24_0 <= '\f') || (LA24_0 >= '\u000E' && LA24_0 <= '\u2027') || (LA24_0 >= '\u202A' && LA24_0 <= '\uFFFF')) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // JavaScript.g:590:9: ~ ( LT )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\u2027') || (input.LA(1) >= '\u202A' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements

            	if ( (state.backtracking==0) )
            	{
            	  _channel=HIDDEN;
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LineComment"

    // $ANTLR start "LT"
    public void mLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:594:2: ( '\\n' | '\\r' | '\\u2028' | '\\u2029' )
            // JavaScript.g:
            {
            	if ( input.LA(1) == '\n' || input.LA(1) == '\r' || (input.LA(1) >= '\u2028' && input.LA(1) <= '\u2029') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LT"

    // $ANTLR start "WhiteSpace"
    public void mWhiteSpace() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WhiteSpace;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // JavaScript.g:601:2: ( ( '\\t' | '\\v' | '\\f' | ' ' | '\\u00A0' ) )
            // JavaScript.g:601:4: ( '\\t' | '\\v' | '\\f' | ' ' | '\\u00A0' )
            {
            	if ( input.LA(1) == '\t' || input.LA(1) == '\f' || input.LA(1) == ' ' || input.LA(1) == 'v' || input.LA(1) == '\u00A0' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	if ( (state.backtracking==0) )
            	{
            	  _channel=HIDDEN;
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WhiteSpace"

    override public void mTokens() // throws RecognitionException 
    {
        // JavaScript.g:1:8: ( T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | T__94 | T__95 | T__96 | T__97 | T__98 | T__99 | T__100 | T__101 | T__102 | T__103 | T__104 | StringLiteral | NumericLiteral | Identifier | Comment | LineComment | LT | WhiteSpace )
        int alt25 = 83;
        alt25 = dfa25.Predict(input);
        switch (alt25) 
        {
            case 1 :
                // JavaScript.g:1:10: T__29
                {
                	mT__29(); if (state.failed) return ;

                }
                break;
            case 2 :
                // JavaScript.g:1:16: T__30
                {
                	mT__30(); if (state.failed) return ;

                }
                break;
            case 3 :
                // JavaScript.g:1:22: T__31
                {
                	mT__31(); if (state.failed) return ;

                }
                break;
            case 4 :
                // JavaScript.g:1:28: T__32
                {
                	mT__32(); if (state.failed) return ;

                }
                break;
            case 5 :
                // JavaScript.g:1:34: T__33
                {
                	mT__33(); if (state.failed) return ;

                }
                break;
            case 6 :
                // JavaScript.g:1:40: T__34
                {
                	mT__34(); if (state.failed) return ;

                }
                break;
            case 7 :
                // JavaScript.g:1:46: T__35
                {
                	mT__35(); if (state.failed) return ;

                }
                break;
            case 8 :
                // JavaScript.g:1:52: T__36
                {
                	mT__36(); if (state.failed) return ;

                }
                break;
            case 9 :
                // JavaScript.g:1:58: T__37
                {
                	mT__37(); if (state.failed) return ;

                }
                break;
            case 10 :
                // JavaScript.g:1:64: T__38
                {
                	mT__38(); if (state.failed) return ;

                }
                break;
            case 11 :
                // JavaScript.g:1:70: T__39
                {
                	mT__39(); if (state.failed) return ;

                }
                break;
            case 12 :
                // JavaScript.g:1:76: T__40
                {
                	mT__40(); if (state.failed) return ;

                }
                break;
            case 13 :
                // JavaScript.g:1:82: T__41
                {
                	mT__41(); if (state.failed) return ;

                }
                break;
            case 14 :
                // JavaScript.g:1:88: T__42
                {
                	mT__42(); if (state.failed) return ;

                }
                break;
            case 15 :
                // JavaScript.g:1:94: T__43
                {
                	mT__43(); if (state.failed) return ;

                }
                break;
            case 16 :
                // JavaScript.g:1:100: T__44
                {
                	mT__44(); if (state.failed) return ;

                }
                break;
            case 17 :
                // JavaScript.g:1:106: T__45
                {
                	mT__45(); if (state.failed) return ;

                }
                break;
            case 18 :
                // JavaScript.g:1:112: T__46
                {
                	mT__46(); if (state.failed) return ;

                }
                break;
            case 19 :
                // JavaScript.g:1:118: T__47
                {
                	mT__47(); if (state.failed) return ;

                }
                break;
            case 20 :
                // JavaScript.g:1:124: T__48
                {
                	mT__48(); if (state.failed) return ;

                }
                break;
            case 21 :
                // JavaScript.g:1:130: T__49
                {
                	mT__49(); if (state.failed) return ;

                }
                break;
            case 22 :
                // JavaScript.g:1:136: T__50
                {
                	mT__50(); if (state.failed) return ;

                }
                break;
            case 23 :
                // JavaScript.g:1:142: T__51
                {
                	mT__51(); if (state.failed) return ;

                }
                break;
            case 24 :
                // JavaScript.g:1:148: T__52
                {
                	mT__52(); if (state.failed) return ;

                }
                break;
            case 25 :
                // JavaScript.g:1:154: T__53
                {
                	mT__53(); if (state.failed) return ;

                }
                break;
            case 26 :
                // JavaScript.g:1:160: T__54
                {
                	mT__54(); if (state.failed) return ;

                }
                break;
            case 27 :
                // JavaScript.g:1:166: T__55
                {
                	mT__55(); if (state.failed) return ;

                }
                break;
            case 28 :
                // JavaScript.g:1:172: T__56
                {
                	mT__56(); if (state.failed) return ;

                }
                break;
            case 29 :
                // JavaScript.g:1:178: T__57
                {
                	mT__57(); if (state.failed) return ;

                }
                break;
            case 30 :
                // JavaScript.g:1:184: T__58
                {
                	mT__58(); if (state.failed) return ;

                }
                break;
            case 31 :
                // JavaScript.g:1:190: T__59
                {
                	mT__59(); if (state.failed) return ;

                }
                break;
            case 32 :
                // JavaScript.g:1:196: T__60
                {
                	mT__60(); if (state.failed) return ;

                }
                break;
            case 33 :
                // JavaScript.g:1:202: T__61
                {
                	mT__61(); if (state.failed) return ;

                }
                break;
            case 34 :
                // JavaScript.g:1:208: T__62
                {
                	mT__62(); if (state.failed) return ;

                }
                break;
            case 35 :
                // JavaScript.g:1:214: T__63
                {
                	mT__63(); if (state.failed) return ;

                }
                break;
            case 36 :
                // JavaScript.g:1:220: T__64
                {
                	mT__64(); if (state.failed) return ;

                }
                break;
            case 37 :
                // JavaScript.g:1:226: T__65
                {
                	mT__65(); if (state.failed) return ;

                }
                break;
            case 38 :
                // JavaScript.g:1:232: T__66
                {
                	mT__66(); if (state.failed) return ;

                }
                break;
            case 39 :
                // JavaScript.g:1:238: T__67
                {
                	mT__67(); if (state.failed) return ;

                }
                break;
            case 40 :
                // JavaScript.g:1:244: T__68
                {
                	mT__68(); if (state.failed) return ;

                }
                break;
            case 41 :
                // JavaScript.g:1:250: T__69
                {
                	mT__69(); if (state.failed) return ;

                }
                break;
            case 42 :
                // JavaScript.g:1:256: T__70
                {
                	mT__70(); if (state.failed) return ;

                }
                break;
            case 43 :
                // JavaScript.g:1:262: T__71
                {
                	mT__71(); if (state.failed) return ;

                }
                break;
            case 44 :
                // JavaScript.g:1:268: T__72
                {
                	mT__72(); if (state.failed) return ;

                }
                break;
            case 45 :
                // JavaScript.g:1:274: T__73
                {
                	mT__73(); if (state.failed) return ;

                }
                break;
            case 46 :
                // JavaScript.g:1:280: T__74
                {
                	mT__74(); if (state.failed) return ;

                }
                break;
            case 47 :
                // JavaScript.g:1:286: T__75
                {
                	mT__75(); if (state.failed) return ;

                }
                break;
            case 48 :
                // JavaScript.g:1:292: T__76
                {
                	mT__76(); if (state.failed) return ;

                }
                break;
            case 49 :
                // JavaScript.g:1:298: T__77
                {
                	mT__77(); if (state.failed) return ;

                }
                break;
            case 50 :
                // JavaScript.g:1:304: T__78
                {
                	mT__78(); if (state.failed) return ;

                }
                break;
            case 51 :
                // JavaScript.g:1:310: T__79
                {
                	mT__79(); if (state.failed) return ;

                }
                break;
            case 52 :
                // JavaScript.g:1:316: T__80
                {
                	mT__80(); if (state.failed) return ;

                }
                break;
            case 53 :
                // JavaScript.g:1:322: T__81
                {
                	mT__81(); if (state.failed) return ;

                }
                break;
            case 54 :
                // JavaScript.g:1:328: T__82
                {
                	mT__82(); if (state.failed) return ;

                }
                break;
            case 55 :
                // JavaScript.g:1:334: T__83
                {
                	mT__83(); if (state.failed) return ;

                }
                break;
            case 56 :
                // JavaScript.g:1:340: T__84
                {
                	mT__84(); if (state.failed) return ;

                }
                break;
            case 57 :
                // JavaScript.g:1:346: T__85
                {
                	mT__85(); if (state.failed) return ;

                }
                break;
            case 58 :
                // JavaScript.g:1:352: T__86
                {
                	mT__86(); if (state.failed) return ;

                }
                break;
            case 59 :
                // JavaScript.g:1:358: T__87
                {
                	mT__87(); if (state.failed) return ;

                }
                break;
            case 60 :
                // JavaScript.g:1:364: T__88
                {
                	mT__88(); if (state.failed) return ;

                }
                break;
            case 61 :
                // JavaScript.g:1:370: T__89
                {
                	mT__89(); if (state.failed) return ;

                }
                break;
            case 62 :
                // JavaScript.g:1:376: T__90
                {
                	mT__90(); if (state.failed) return ;

                }
                break;
            case 63 :
                // JavaScript.g:1:382: T__91
                {
                	mT__91(); if (state.failed) return ;

                }
                break;
            case 64 :
                // JavaScript.g:1:388: T__92
                {
                	mT__92(); if (state.failed) return ;

                }
                break;
            case 65 :
                // JavaScript.g:1:394: T__93
                {
                	mT__93(); if (state.failed) return ;

                }
                break;
            case 66 :
                // JavaScript.g:1:400: T__94
                {
                	mT__94(); if (state.failed) return ;

                }
                break;
            case 67 :
                // JavaScript.g:1:406: T__95
                {
                	mT__95(); if (state.failed) return ;

                }
                break;
            case 68 :
                // JavaScript.g:1:412: T__96
                {
                	mT__96(); if (state.failed) return ;

                }
                break;
            case 69 :
                // JavaScript.g:1:418: T__97
                {
                	mT__97(); if (state.failed) return ;

                }
                break;
            case 70 :
                // JavaScript.g:1:424: T__98
                {
                	mT__98(); if (state.failed) return ;

                }
                break;
            case 71 :
                // JavaScript.g:1:430: T__99
                {
                	mT__99(); if (state.failed) return ;

                }
                break;
            case 72 :
                // JavaScript.g:1:436: T__100
                {
                	mT__100(); if (state.failed) return ;

                }
                break;
            case 73 :
                // JavaScript.g:1:443: T__101
                {
                	mT__101(); if (state.failed) return ;

                }
                break;
            case 74 :
                // JavaScript.g:1:450: T__102
                {
                	mT__102(); if (state.failed) return ;

                }
                break;
            case 75 :
                // JavaScript.g:1:457: T__103
                {
                	mT__103(); if (state.failed) return ;

                }
                break;
            case 76 :
                // JavaScript.g:1:464: T__104
                {
                	mT__104(); if (state.failed) return ;

                }
                break;
            case 77 :
                // JavaScript.g:1:471: StringLiteral
                {
                	mStringLiteral(); if (state.failed) return ;

                }
                break;
            case 78 :
                // JavaScript.g:1:485: NumericLiteral
                {
                	mNumericLiteral(); if (state.failed) return ;

                }
                break;
            case 79 :
                // JavaScript.g:1:500: Identifier
                {
                	mIdentifier(); if (state.failed) return ;

                }
                break;
            case 80 :
                // JavaScript.g:1:511: Comment
                {
                	mComment(); if (state.failed) return ;

                }
                break;
            case 81 :
                // JavaScript.g:1:519: LineComment
                {
                	mLineComment(); if (state.failed) return ;

                }
                break;
            case 82 :
                // JavaScript.g:1:531: LT
                {
                	mLT(); if (state.failed) return ;

                }
                break;
            case 83 :
                // JavaScript.g:1:534: WhiteSpace
                {
                	mWhiteSpace(); if (state.failed) return ;

                }
                break;

        }

    }

    // $ANTLR start "synpred1_JavaScript"
    public void synpred1_JavaScript_fragment() {
        // JavaScript.g:575:4: ( IdentifierStart )
        // JavaScript.g:575:5: IdentifierStart
        {
        	mIdentifierStart(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_JavaScript"

   	public bool synpred1_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_JavaScript_fragment(); // can never throw exception
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


    protected DFA18 dfa18;
    protected DFA25 dfa25;
	private void InitializeCyclicDFAs()
	{
	    this.dfa18 = new DFA18(this);
	    this.dfa25 = new DFA25(this);


	}

    const string DFA18_eotS =
        "\x01\uffff\x01\x02\x02\uffff";
    const string DFA18_eofS =
        "\x04\uffff";
    const string DFA18_minS =
        "\x02\x2e\x02\uffff";
    const string DFA18_maxS =
        "\x02\x39\x02\uffff";
    const string DFA18_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA18_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x03\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "551:10: fragment DecimalLiteral : ( ( DecimalDigit )+ '.' ( DecimalDigit )* ( ExponentPart )? | ( '.' )? ( DecimalDigit )+ ( ExponentPart )? );"; }
        }

    }

    const string DFA25_eotS =
        "\x01\uffff\x01\x27\x05\uffff\x01\x27\x01\uffff\x01\x31\x07\x27"+
        "\x01\uffff\x03\x27\x02\uffff\x01\x43\x01\x45\x01\x49\x01\x4b\x01"+
        "\x4e\x01\x51\x01\x54\x01\x57\x01\x5a\x01\x5c\x01\x5f\x01\uffff\x01"+
        "\x61\x06\uffff\x06\x27\x01\x69\x01\uffff\x01\x6a\x01\x6c\x01\x27"+
        "\x01\x6e\x0d\x27\x0f\uffff\x01\u0081\x02\uffff\x01\u0084\x0a\uffff"+
        "\x01\u0086\x01\uffff\x01\x27\x01\u0088\x02\x27\x01\u008b\x01\x27"+
        "\x03\uffff\x01\x27\x01\uffff\x01\x27\x01\uffff\x0c\x27\x01\u009b"+
        "\x02\x27\x01\u009e\x01\x27\x03\uffff\x01\u00a1\x03\uffff\x01\x27"+
        "\x01\uffff\x02\x27\x01\uffff\x01\u00a5\x01\x27\x01\u00a7\x03\x27"+
        "\x01\u00ab\x01\x27\x01\u00ad\x05\x27\x01\u00b3\x01\uffff\x01\u00b4"+
        "\x01\x27\x01\uffff\x01\u00b6\x02\uffff\x02\x27\x01\u00b9\x01\uffff"+
        "\x01\x27\x01\uffff\x02\x27\x01\u00bd\x01\uffff\x01\x27\x01\uffff"+
        "\x01\u00bf\x01\u00c0\x02\x27\x01\u00c3\x02\uffff\x01\x27\x01\uffff"+
        "\x02\x27\x01\uffff\x02\x27\x01\u00c9\x01\uffff\x01\x27\x02\uffff"+
        "\x01\u00cb\x01\u00cc\x01\uffff\x01\u00cd\x01\x27\x01\u00cf\x01\x27"+
        "\x01\u00d1\x01\uffff\x01\x27\x03\uffff\x01\u00d3\x01\uffff\x01\x27"+
        "\x01\uffff\x01\u00d5\x01\uffff\x01\x27\x01\uffff\x01\u00d7\x01\uffff";
    const string DFA25_eofS =
        "\u00d8\uffff";
    const string DFA25_minS =
        "\x01\x09\x01\x61\x05\uffff\x01\x61\x01\uffff\x01\x3d\x01\x66\x01"+
        "\x6c\x01\x65\x01\x68\x01\x61\x01\x72\x01\x65\x01\uffff\x01\x77\x01"+
        "\x68\x01\x65\x02\uffff\x01\x30\x01\x3d\x01\x2a\x01\x3d\x01\x2b\x01"+
        "\x2d\x01\x3c\x01\x3d\x01\x26\x02\x3d\x01\uffff\x01\x3d\x06\uffff"+
        "\x01\x6e\x01\x72\x01\x6e\x01\x6c\x01\x72\x01\x69\x01\x3d\x01\uffff"+
        "\x02\x24\x01\x73\x01\x24\x01\x66\x01\x69\x01\x74\x01\x6e\x01\x73"+
        "\x01\x65\x01\x74\x02\x69\x01\x75\x01\x70\x01\x77\x01\x6c\x0f\uffff"+
        "\x01\x3d\x02\uffff\x01\x3d\x0a\uffff\x01\x3d\x01\uffff\x01\x63\x01"+
        "\x24\x01\x61\x01\x73\x01\x24\x01\x64\x03\uffff\x01\x74\x01\uffff"+
        "\x01\x65\x01\uffff\x01\x61\x01\x65\x01\x6c\x01\x68\x01\x74\x01\x65"+
        "\x01\x63\x01\x61\x01\x75\x01\x74\x01\x6f\x01\x73\x01\x24\x02\x65"+
        "\x01\x24\x01\x6c\x03\uffff\x01\x3d\x03\uffff\x01\x74\x01\uffff\x01"+
        "\x6c\x01\x65\x01\uffff\x01\x24\x01\x61\x01\x24\x01\x75\x01\x74\x01"+
        "\x65\x01\x24\x01\x69\x01\x24\x01\x68\x01\x6b\x01\x72\x01\x63\x01"+
        "\x77\x01\x24\x01\uffff\x01\x24\x01\x6f\x01\uffff\x01\x24\x02\uffff"+
        "\x01\x69\x01\x6c\x01\x24\x01\uffff\x01\x6e\x01\uffff\x01\x6c\x01"+
        "\x65\x01\x24\x01\uffff\x01\x6e\x01\uffff\x02\x24\x01\x6e\x01\x68"+
        "\x01\x24\x02\uffff\x01\x66\x01\uffff\x01\x6f\x01\x79\x01\uffff\x01"+
        "\x63\x01\x74\x01\x24\x01\uffff\x01\x75\x02\uffff\x02\x24\x01\uffff"+
        "\x01\x24\x01\x6e\x01\x24\x01\x65\x01\x24\x01\uffff\x01\x65\x03\uffff"+
        "\x01\x24\x01\uffff\x01\x6f\x01\uffff\x01\x24\x01\uffff\x01\x66\x01"+
        "\uffff\x01\x24\x01\uffff";
    const string DFA25_maxS =
        "\x01\u2029\x01\x75\x05\uffff\x01\x6f\x01\uffff\x01\x3d\x01\x6e"+
        "\x01\x6c\x01\x6f\x01\x69\x01\x6f\x01\x72\x01\x65\x01\uffff\x01\x77"+
        "\x01\x79\x01\x75\x02\uffff\x01\x39\x06\x3d\x01\x3e\x02\x3d\x01\x7c"+
        "\x01\uffff\x01\x3d\x06\uffff\x01\x6e\x01\x72\x01\x6e\x01\x6c\x01"+
        "\x72\x01\x69\x01\x3d\x01\uffff\x02\x7a\x01\x73\x01\x7a\x01\x6c\x01"+
        "\x69\x01\x74\x01\x6e\x01\x74\x01\x65\x01\x74\x01\x69\x01\x72\x01"+
        "\x79\x01\x70\x01\x77\x01\x6c\x0f\uffff\x01\x3d\x02\uffff\x01\x3e"+
        "\x0a\uffff\x01\x3d\x01\uffff\x01\x63\x01\x7a\x01\x61\x01\x73\x01"+
        "\x7a\x01\x64\x03\uffff\x01\x74\x01\uffff\x01\x65\x01\uffff\x01\x61"+
        "\x01\x65\x01\x6c\x01\x68\x01\x74\x01\x65\x01\x63\x01\x61\x01\x75"+
        "\x01\x74\x01\x6f\x01\x73\x01\x7a\x02\x65\x01\x7a\x01\x6c\x03\uffff"+
        "\x01\x3d\x03\uffff\x01\x74\x01\uffff\x01\x6c\x01\x65\x01\uffff\x01"+
        "\x7a\x01\x61\x01\x7a\x01\x75\x01\x74\x01\x65\x01\x7a\x01\x69\x01"+
        "\x7a\x01\x68\x01\x6b\x01\x72\x01\x63\x01\x77\x01\x7a\x01\uffff\x01"+
        "\x7a\x01\x6f\x01\uffff\x01\x7a\x02\uffff\x01\x69\x01\x6c\x01\x7a"+
        "\x01\uffff\x01\x6e\x01\uffff\x01\x6c\x01\x65\x01\x7a\x01\uffff\x01"+
        "\x6e\x01\uffff\x02\x7a\x01\x6e\x01\x68\x01\x7a\x02\uffff\x01\x66"+
        "\x01\uffff\x01\x6f\x01\x79\x01\uffff\x01\x63\x01\x74\x01\x7a\x01"+
        "\uffff\x01\x75\x02\uffff\x02\x7a\x01\uffff\x01\x7a\x01\x6e\x01\x7a"+
        "\x01\x65\x01\x7a\x01\uffff\x01\x65\x03\uffff\x01\x7a\x01\uffff\x01"+
        "\x6f\x01\uffff\x01\x7a\x01\uffff\x01\x66\x01\uffff\x01\x7a\x01\uffff";
    const string DFA25_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\uffff\x01"+
        "\x08\x08\uffff\x01\x14\x03\uffff\x01\x1d\x01\x1e\x0b\uffff\x01\x2b"+
        "\x01\uffff\x01\x47\x01\x4d\x01\x4e\x01\x4f\x01\x52\x01\x53\x07\uffff"+
        "\x01\x09\x11\uffff\x01\x1f\x01\x20\x01\x3f\x01\x21\x01\x50\x01\x51"+
        "\x01\x40\x01\x22\x01\x41\x01\x23\x01\x45\x01\x3d\x01\x24\x01\x46"+
        "\x01\x3e\x01\uffff\x01\x37\x01\x35\x01\uffff\x01\x38\x01\x36\x01"+
        "\x28\x01\x2d\x01\x30\x01\x29\x01\x2f\x01\x2a\x01\x2c\x01\x2e\x01"+
        "\uffff\x01\x48\x06\uffff\x01\x33\x01\x31\x01\x0a\x01\uffff\x01\x0f"+
        "\x01\uffff\x01\x0c\x11\uffff\x01\x25\x01\x3a\x01\x26\x01\uffff\x01"+
        "\x3b\x01\x34\x01\x32\x01\uffff\x01\x0e\x02\uffff\x01\x07\x0f\uffff"+
        "\x01\x19\x02\uffff\x01\x1c\x01\uffff\x01\x27\x01\x3c\x03\uffff\x01"+
        "\x43\x01\uffff\x01\x0b\x03\uffff\x01\x13\x01\uffff\x01\x16\x05\uffff"+
        "\x01\x49\x01\x4b\x01\uffff\x01\x4a\x02\uffff\x01\x4c\x03\uffff\x01"+
        "\x0d\x01\uffff\x01\x1a\x01\x11\x02\uffff\x01\x18\x05\uffff\x01\x42"+
        "\x01\uffff\x01\x12\x01\x15\x01\x44\x01\uffff\x01\x1b\x01\uffff\x01"+
        "\x17\x01\uffff\x01\x01\x01\uffff\x01\x10\x01\uffff\x01\x39";
    const string DFA25_specialS =
        "\u00d8\uffff}>";
    static readonly string[] DFA25_transitionS = {
            "\x01\x29\x01\x28\x01\uffff\x01\x29\x01\x28\x12\uffff\x01\x29"+
            "\x01\x23\x01\x25\x01\uffff\x01\x27\x01\x1a\x01\x1f\x01\x25\x01"+
            "\x02\x01\x04\x01\x18\x01\x1b\x01\x03\x01\x1c\x01\x17\x01\x19"+
            "\x0a\x26\x01\x11\x01\x08\x01\x1d\x01\x09\x01\x1e\x01\x22\x01"+
            "\uffff\x1a\x27\x01\x15\x01\uffff\x01\x16\x01\x20\x01\x27\x01"+
            "\uffff\x01\x27\x01\x0f\x01\x0e\x01\x0c\x01\x0b\x01\x01\x02\x27"+
            "\x01\x0a\x04\x27\x01\x14\x03\x27\x01\x10\x01\x12\x01\x13\x01"+
            "\x27\x01\x07\x01\x0d\x03\x27\x01\x05\x01\x21\x01\x06\x01\x24"+
            "\x21\uffff\x01\x29\u1f87\uffff\x02\x28",
            "\x01\x2d\x07\uffff\x01\x2c\x05\uffff\x01\x2b\x05\uffff\x01"+
            "\x2a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2e\x0d\uffff\x01\x2f",
            "",
            "\x01\x30",
            "\x01\x32\x07\uffff\x01\x33",
            "\x01\x34",
            "\x01\x36\x09\uffff\x01\x35",
            "\x01\x37\x01\x38",
            "\x01\x3a\x0d\uffff\x01\x39",
            "\x01\x3b",
            "\x01\x3c",
            "",
            "\x01\x3d",
            "\x01\x3e\x09\uffff\x01\x3f\x06\uffff\x01\x40",
            "\x01\x41\x0f\uffff\x01\x42",
            "",
            "",
            "\x0a\x26",
            "\x01\x44",
            "\x01\x47\x04\uffff\x01\x48\x0d\uffff\x01\x46",
            "\x01\x4a",
            "\x01\x4d\x11\uffff\x01\x4c",
            "\x01\x50\x0f\uffff\x01\x4f",
            "\x01\x52\x01\x53",
            "\x01\x56\x01\x55",
            "\x01\x59\x16\uffff\x01\x58",
            "\x01\x5b",
            "\x01\x5d\x3e\uffff\x01\x5e",
            "",
            "\x01\x60",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x12\x27\x01\x6b\x07\x27",
            "\x01\x6d",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\x6f\x05\uffff\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x7a\x08\uffff\x01\x79",
            "\x01\x7c\x03\uffff\x01\x7b",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
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
            "\x01\u0080",
            "",
            "",
            "\x01\u0082\x01\u0083",
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
            "\x01\u0085",
            "",
            "\x01\u0087",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u008c",
            "",
            "",
            "",
            "\x01\u008d",
            "",
            "\x01\u008e",
            "",
            "\x01\u008f",
            "\x01\u0090",
            "\x01\u0091",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u009c",
            "\x01\u009d",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u009f",
            "",
            "",
            "",
            "\x01\u00a0",
            "",
            "",
            "",
            "\x01\u00a2",
            "",
            "\x01\u00a3",
            "\x01\u00a4",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00a6",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00ac",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00ae",
            "\x01\u00af",
            "\x01\u00b0",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00b5",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "",
            "\x01\u00b7",
            "\x01\u00b8",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00ba",
            "",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00be",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00c1",
            "\x01\u00c2",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "",
            "\x01\u00c4",
            "",
            "\x01\u00c5",
            "\x01\u00c6",
            "",
            "\x01\u00c7",
            "\x01\u00c8",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00ca",
            "",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00ce",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "\x01\u00d0",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00d2",
            "",
            "",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00d4",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            "",
            "\x01\u00d6",
            "",
            "\x01\x27\x0b\uffff\x0a\x27\x07\uffff\x1a\x27\x04\uffff\x01"+
            "\x27\x01\uffff\x1a\x27",
            ""
    };

    static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
    static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
    static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
    static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
    static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
    static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
    static readonly short[][] DFA25_transition = DFA.UnpackEncodedStringArray(DFA25_transitionS);

    protected class DFA25 : DFA
    {
        public DFA25(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | T__90 | T__91 | T__92 | T__93 | T__94 | T__95 | T__96 | T__97 | T__98 | T__99 | T__100 | T__101 | T__102 | T__103 | T__104 | StringLiteral | NumericLiteral | Identifier | Comment | LineComment | LT | WhiteSpace );"; }
        }

    }

 
    
}
