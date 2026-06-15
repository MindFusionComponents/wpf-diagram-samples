/*
  Copyright 2008 Chris Lambrou.
  All rights reserved.
*/

grammar JavaScript;

options
{
	backtrack=true;
	memoize=true;
	language=CSharp2;
}

@header {
using System.Diagnostics;
}

@members {
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
}

program
	: LT* sourceElements LT* EOF
	;
	
sourceElements
	: sourceElement (LT* sourceElement)*
	;
	
sourceElement
	: functionDeclaration
	| statement
	;
	
// functions
functionDeclaration
	: 'function' LT* Identifier { RaiseEnterFunctionDeclaration($Identifier.Text); } LT* formalParameterList LT* functionBody { RaiseLeaveFunctionDeclaration(); }
	;
	
functionExpression
	: 'function' LT* Identifier? LT* formalParameterList LT* functionBody
	;
	
formalParameterList
	: '(' (LT* Identifier (LT* ',' LT* Identifier)*)? LT* ')'
	;

functionBody
	: '{' LT* { RaiseEnterFunctionBody(); } sourceElements { RaiseLeaveFunctionBody(); } LT* '}'
	;

// statements
statement
	: statementBlock
	| variableStatement
	| emptyStatement
	| { RaiseEnterExpressionStatement(); } s=expressionStatement { RaiseLeaveExpressionStatement($s.text); }
	| { RaiseEnterIfStatement(); } ifStatement { RaiseLeaveIfStatement(); }
	| { RaiseEnterIterationStatement(); } iterationStatement { RaiseLeaveIterationStatement(); }
	| continueStatement
	| breakStatement
	| { RaiseEnterReturnStatement(); } w=returnStatement { RaiseLeaveReturnStatement($w.text); }
	| withStatement
	| labelledStatement
	| { RaiseEnterSwitchStatement(); } switchStatement { RaiseLeaveSwitchStatement(); }
	| throwStatement
	| tryStatement
	;
	
statementBlock
	: '{' LT* statementList? LT* '}'
	;
	
statementList
	: statement (LT* statement)*
	;
	
variableStatement
	: 'var' LT* variableDeclarationList (LT | ';')
	;
	
variableDeclarationList
	: variableDeclaration (LT* ',' LT* variableDeclaration)*
	;
	
variableDeclarationListNoIn
	: variableDeclarationNoIn (LT* ',' LT* variableDeclarationNoIn)*
	;
	
variableDeclaration
	: Identifier LT* initialiser?
	;
	
variableDeclarationNoIn
	: Identifier LT* initialiserNoIn?
	;
	
initialiser
	: '=' LT* assignmentExpression
	;
	
initialiserNoIn
	: '=' LT* assignmentExpressionNoIn
	;
	
emptyStatement
	: ';'
	;
	
expressionStatement
	: expression (LT | ';')
	;
	
ifStatement
	: 'if' LT* '(' LT* expression LT* ')' LT* { RaiseEnterBranch(); } statement { RaiseLeaveBranch(); } (LT* 'else' LT* { RaiseEnterBranch(); } statement { RaiseLeaveBranch(); })?
	;
	
iterationStatement
	: doWhileStatement
	| whileStatement
	| forStatement
	| forInStatement
	;
	
doWhileStatement
	: 'do' LT* statement LT* 'while' LT* '(' expression ')' (LT | ';')
	;
	
whileStatement
	: 'while' LT* '(' LT* expression LT* ')' LT* statement
	;
	
forStatement
	: 'for' LT* '(' (LT* forStatementInitialiserPart)? LT* ';' (LT* expression)? LT* ';' (LT* expression)? LT* ')' LT* statement
	;
	
forStatementInitialiserPart
	: expressionNoIn
	| 'var' LT* variableDeclarationListNoIn
	;
	
forInStatement
	: 'for' LT* '(' LT* forInStatementInitialiserPart LT* 'in' LT* expression LT* ')' LT* statement
	;
	
forInStatementInitialiserPart
	: leftHandSideExpression
	| 'var' LT* variableDeclarationNoIn
	;

continueStatement
	: 'continue' Identifier? (LT | ';')
	;

breakStatement
	: 'break' Identifier? (LT | ';')
	;

returnStatement
	: 'return' expression? (LT | ';')
	;
	
withStatement
	: 'with' LT* '(' LT* expression LT* ')' LT* statement
	;

labelledStatement
	: Identifier LT* ':' LT* statement
	;
	
switchStatement
	: 'switch' LT* '(' LT* expression LT* ')' LT* caseBlock
	;
	
caseBlock
	: '{' (LT* caseClause)* (LT* defaultClause (LT* caseClause)*)? LT* '}'
	;

caseClause
	: 'case' LT* expression LT* ':' LT* { RaiseEnterBranch(); } statementList? { RaiseLeaveBranch(); }
	;
	
defaultClause
	: 'default' LT* ':' LT* { RaiseEnterBranch(); } statementList? { RaiseLeaveBranch(); }
	;
	
throwStatement
	: 'throw' expression (LT | ';')
	;

tryStatement
	: 'try' LT* statementBlock LT* (finallyClause | catchClause (LT* finallyClause)?)
	;
       
catchClause
	: 'catch' LT* '(' LT* Identifier LT* ')' LT* statementBlock
	;
	
finallyClause
	: 'finally' LT* statementBlock
	;

// expressions
expression
	: assignmentExpression (LT* ',' LT* assignmentExpression)*
	;
	
expressionNoIn
	: assignmentExpressionNoIn (LT* ',' LT* assignmentExpressionNoIn)*
	;
	
assignmentExpression
	: conditionalExpression
	| leftHandSideExpression LT* assignmentOperator LT* assignmentExpression
	;
	
assignmentExpressionNoIn
	: conditionalExpressionNoIn
	| leftHandSideExpression LT* assignmentOperator LT* assignmentExpressionNoIn
	;
	
leftHandSideExpression
	: callExpression
	| newExpression
	;
	
newExpression
	: memberExpression
	| 'new' LT* newExpression
	;
	
memberExpression
	: (primaryExpression | functionExpression | 'new' LT* memberExpression LT* arguments) (LT* memberExpressionSuffix)*
	;
	
memberExpressionSuffix
	: indexSuffix
	| propertyReferenceSuffix
	;

callExpression
	: memberExpression LT* arguments (LT* callExpressionSuffix)*
	;
	
callExpressionSuffix
	: arguments
	| indexSuffix
	| propertyReferenceSuffix
	;

arguments
	: '(' (LT* assignmentExpression (LT* ',' LT* assignmentExpression)*)? LT* ')'
	;
	
indexSuffix
	: '[' LT* expression LT* ']'
	;	
	
propertyReferenceSuffix
	: '.' LT* Identifier
	;
	
assignmentOperator
	: '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|='
	;

conditionalExpression
	: logicalORExpression (LT* '?' LT* assignmentExpression LT* ':' LT* assignmentExpression)?
	;

conditionalExpressionNoIn
	: logicalORExpressionNoIn (LT* '?' LT* assignmentExpressionNoIn LT* ':' LT* assignmentExpressionNoIn)?
	;

logicalORExpression
	: logicalANDExpression (LT* '||' LT* logicalANDExpression)*
	;
	
logicalORExpressionNoIn
	: logicalANDExpressionNoIn (LT* '||' LT* logicalANDExpressionNoIn)*
	;
	
logicalANDExpression
	: bitwiseORExpression (LT* '&&' LT* bitwiseORExpression)*
	;
	
logicalANDExpressionNoIn
	: bitwiseORExpressionNoIn (LT* '&&' LT* bitwiseORExpressionNoIn)*
	;
	
bitwiseORExpression
	: bitwiseXORExpression (LT* '|' LT* bitwiseXORExpression)*
	;
	
bitwiseORExpressionNoIn
	: bitwiseXORExpressionNoIn (LT* '|' LT* bitwiseXORExpressionNoIn)*
	;
	
bitwiseXORExpression
	: bitwiseANDExpression (LT* '^' LT* bitwiseANDExpression)*
	;
	
bitwiseXORExpressionNoIn
	: bitwiseANDExpressionNoIn (LT* '^' LT* bitwiseANDExpressionNoIn)*
	;
	
bitwiseANDExpression
	: equalityExpression (LT* '&' LT* equalityExpression)*
	;
	
bitwiseANDExpressionNoIn
	: equalityExpressionNoIn (LT* '&' LT* equalityExpressionNoIn)*
	;
	
equalityExpression
	: relationalExpression (LT* ('==' | '!=' | '===' | '!==') LT* relationalExpression)*
	;

equalityExpressionNoIn
	: relationalExpressionNoIn (LT* ('==' | '!=' | '===' | '!==') LT* relationalExpressionNoIn)*
	;
	
relationalExpression
	: shiftExpression (LT* ('<' | '>' | '<=' | '>=' | 'instanceof' | 'in') LT* shiftExpression)*
	;

relationalExpressionNoIn
	: shiftExpression (LT* ('<' | '>' | '<=' | '>=' | 'instanceof') LT* shiftExpression)*
	;

shiftExpression
	: additiveExpression (LT* ('<<' | '>>' | '>>>') LT* additiveExpression)*
	;

additiveExpression
	: multiplicativeExpression (LT* ('+' | '-') LT* multiplicativeExpression)*
	;

multiplicativeExpression
	: unaryExpression (LT* ('*' | '/' | '%') LT* unaryExpression)*
	;

unaryExpression
	: postfixExpression
	| ('delete' | 'void' | 'typeof' | '++' | '--' | '+' | '-' | '~' | '!') unaryExpression
	;
	
postfixExpression
	: leftHandSideExpression ('++' | '--')?
	;

primaryExpression
	: 'this'
	| Identifier
	| literal
	| arrayLiteral
	| objectLiteral
	| '(' LT* expression LT* ')'
	;
	
// arrayLiteral definition.
arrayLiteral
	: '[' LT* assignmentExpression? (LT* ',' (LT* assignmentExpression)?)* LT* ']'
	;
       
// objectLiteral definition.
objectLiteral
	: '{' LT* propertyNameAndValue (LT* ',' LT* propertyNameAndValue)* LT* '}'
	;
	
propertyNameAndValue
	: propertyName LT* ':' LT* assignmentExpression
	;

propertyName
	: Identifier
	| StringLiteral
	| NumericLiteral
	;

// primitive literal definition.
literal
	: 'null'
	| 'true'
	| 'false'
	| StringLiteral
	| NumericLiteral
	;
	
// lexer rules.
StringLiteral
	: '"' DoubleStringCharacter* '"'
	| '\'' SingleStringCharacter* '\''
	;
	
fragment DoubleStringCharacter
	: ~('"' | '\\' | LT)	
	| '\\' EscapeSequence
	;

fragment SingleStringCharacter
	: ~('\'' | '\\' | LT)	
	| '\\' EscapeSequence
	;

fragment EscapeSequence
	: CharacterEscapeSequence
	| '0'
	| HexEscapeSequence
	| UnicodeEscapeSequence
	;
	
fragment CharacterEscapeSequence
	: SingleEscapeCharacter
	| NonEscapeCharacter
	;

fragment NonEscapeCharacter
	: ~(EscapeCharacter | LT)
	;

fragment SingleEscapeCharacter
	: '\'' | '"' | '\\' | 'b' | 'f' | 'n' | 'r' | 't' | 'v'
	;

fragment EscapeCharacter
	: SingleEscapeCharacter
	| DecimalDigit
	| 'x'
	| 'u'
	;
	
fragment HexEscapeSequence
	: 'x' HexDigit HexDigit
	;
	
fragment UnicodeEscapeSequence
	: 'u' HexDigit HexDigit HexDigit HexDigit
	;
	
NumericLiteral
	: DecimalLiteral
	| HexIntegerLiteral
	;
	
fragment HexIntegerLiteral
	: '0' ('x' | 'X') HexDigit+
	;
	
fragment HexDigit
	: DecimalDigit | ('a'..'f') | ('A'..'F')
	;
	
fragment DecimalLiteral
	: DecimalDigit+ '.' DecimalDigit* ExponentPart?
	| '.'? DecimalDigit+ ExponentPart?
	;
	
fragment DecimalDigit
	: ('0'..'9')
	;

fragment ExponentPart
	: ('e' | 'E') ('+' | '-') ? DecimalDigit+
	;

Identifier
	: IdentifierStart IdentifierPart*
	;
	
fragment IdentifierStart
	: UnicodeLetter
	| '$'
	| '_'
        ;
        
fragment IdentifierPart
	: (IdentifierStart) => IdentifierStart // Avoids ambiguity, as some IdentifierStart chars also match following alternatives.
	| UnicodeDigit
	;
	
fragment UnicodeLetter		
	: ('a'..'z' |'A'..'Z' );

fragment UnicodeDigit		
	: '0'..'9';
		
Comment
	: '/*' (options {greedy=false;} : .)* '*/' {$channel=HIDDEN;}
	;

LineComment
	: '//' ~(LT)* {$channel=HIDDEN;}
	;

LT
	: '\n'		// Line feed.
	| '\r'		// Carriage return.
	| '\u2028'	// Line separator.
	| '\u2029'	// Paragraph separator.
	;

WhiteSpace // Tab, vertical tab, form feed, space, non-breaking space and any other unicode "space separator".
	: ('\t' | '\v' | '\f' | ' ' | '\u00A0')	{$channel=HIDDEN;}
	;
