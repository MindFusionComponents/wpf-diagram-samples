
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;

using MindFusion.CodeColoring;


namespace MindFusion.Diagramming.Wpf.Samples.CS.Demo
{
	[ContentProperty("SourceCode")]
	[TemplatePart(Name = "PART_Viewer", Type = typeof(FlowDocumentScrollViewer))]
	public class SourceCodeViewer : Control
	{
		static SourceCodeViewer()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SourceCodeViewer),
				new FrameworkPropertyMetadata(typeof(SourceCodeViewer)));
		}

		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			viewer = GetTemplateChild("PART_Viewer") as FlowDocumentScrollViewer;
			SetSourceCode(SourceCode, CodeLanguage);
		}

		public void SetSourceCode(string code)
		{
			SetSourceCode(code, CodeLanguage);
		}

		public void SetSourceCode(string code, CodeLanguage language)
		{
			if (viewer == null)
				return;

			if (string.IsNullOrEmpty(code))
			{
				viewer.Document = null;
				return;
			}

			ITokenizer tokenizer = null;

			switch (language)
			{

				case CodeLanguage.Aspx:
					tokenizer = new AspxTokenizer();
					break;

				case CodeLanguage.CSharp:
					tokenizer = new CSharpTokenizer();
					break;

				case CodeLanguage.VisualBasic:
					tokenizer = new VisualBasicTokenizer();
					break;

				case CodeLanguage.Xaml:
					tokenizer = new XamlTokenizer();
					break;

				case CodeLanguage.Css:
					tokenizer = new CssTokenizer();
					break;

				case CodeLanguage.JavaScript:
					tokenizer = new JavaScriptTokenizer();
					break;

				case CodeLanguage.CPlusPlus:
					tokenizer = new CPlusPlusTokenizer();
					break;

				case CodeLanguage.Delphi:
					tokenizer = new DelphiTokenizer();
					break;

			}

			FlowDocument document = new FlowDocument()
			{
				FontFamily = FontFamily,
				FontSize = FontSize,
			};
			if (tokenizer == null)
			{
				document.Blocks.Add(new Paragraph(new Run(code)));
			}
			else
			{
				Paragraph paragraph = new Paragraph();
				List<Token> codeTokens = tokenizer.Tokenize(code);

				foreach (Token codeToken in codeTokens)
				{
					Brush foreground = null;
					Brush background = null;
					FontWeight? fontWeight = null;

					switch (codeToken.Type)
					{

						case TokenType.Comment:
							background = CommentBackground;
							foreground = CommentForeground;
							fontWeight = CommentFontWeight;
							break;

						case TokenType.String:
							background = StringBackground;
							foreground = StringForeground;
							fontWeight = StringFontWeight;
							break;

						case TokenType.Number:
							background = NumberBackground;
							foreground = NumberForeground;
							fontWeight = NumberFontWeight;
							break;

						case TokenType.Keyword:
							background = KeywordBackground;
							foreground = KeywordForeground;
							fontWeight = KeywordFontWeight;
							break;

						case TokenType.XamlBracket:
							background = XamlBracketBackground;
							foreground = XamlBracketForeground;
							fontWeight = XamlBracketFontWeight;
							break;

						case TokenType.XamlNsSeparator:
							background = XamlNsSeparatorBackground;
							foreground = XamlNsSeparatorForeground;
							fontWeight = XamlNsSeparatorFontWeight;
							break;

						case TokenType.XamlAttributeAssignment:
							background = XamlAttributeAssignmentBackground;
							foreground = XamlAttributeAssignmentForeground;
							fontWeight = XamlAttributeAssignmentFontWeight;
							break;

						case TokenType.XamlTag:
							background = XamlTagBackground;
							foreground = XamlTagForeground;
							fontWeight = XamlTagFontWeight;
							break;

						case TokenType.XamlAttributeName:
							background = XamlAttributeNameBackground;
							foreground = XamlAttributeNameForeground;
							fontWeight = XamlAttributeNameFontWeight;
							break;

						case TokenType.XamlAttributeValue:
							background = XamlAttributeValueBackground;
							foreground = XamlAttributeValueForeground;
							fontWeight = XamlAttributeValueFontWeight;
							break;

						case TokenType.AspxInlineCode:
							background = AspxInlineCodeBackground;
							foreground = AspxInlineCodeForeground;
							fontWeight = AspxInlineCodeFontWeight;
							break;

					}

					Run run = new Run(codeToken.Value);
					if (foreground != null)
						run.Foreground = foreground;
					if (background != null)
						run.Background = background;
					if (fontWeight.HasValue)
						run.FontWeight = fontWeight.Value;
					paragraph.Inlines.Add(run);
				}

				document.Blocks.Add(paragraph);
			}

			viewer.Document = document;
		}

		private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SourceCodeViewer viewer = d as SourceCodeViewer;
			viewer.SetSourceCode(viewer.SourceCode, viewer.CodeLanguage);
		}


		public string SourceCode
		{
			get { return (string)GetValue(SourceCodeProperty); }
			set { SetValue(SourceCodeProperty, value); }
		}

		public static readonly DependencyProperty SourceCodeProperty =
			DependencyProperty.Register("SourceCode", typeof(string), typeof(SourceCodeViewer),
			new PropertyMetadata(OnSourceCodeChanged));

		private static void OnSourceCodeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SourceCodeViewer viewer = d as SourceCodeViewer;
			viewer.SetSourceCode(e.NewValue as string, viewer.CodeLanguage);
		}

		public CodeLanguage CodeLanguage
		{
			get { return (CodeLanguage)GetValue(CodeLanguageProperty); }
			set { SetValue(CodeLanguageProperty, value); }
		}

		public static readonly DependencyProperty CodeLanguageProperty =
			DependencyProperty.Register("CodeLanguage", typeof(CodeLanguage), typeof(SourceCodeViewer),
			new PropertyMetadata(CodeLanguage.CSharp, OnCodeLanguageChanged));

		private static void OnCodeLanguageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			SourceCodeViewer viewer = d as SourceCodeViewer;
			viewer.SetSourceCode(viewer.SourceCode, (CodeLanguage)e.NewValue);
		}

		public Brush XamlBracketForeground
		{
			get { return (Brush)GetValue(XamlBracketForegroundProperty); }
			set { SetValue(XamlBracketForegroundProperty, value); }
		}

		public static readonly DependencyProperty XamlBracketForegroundProperty =
			DependencyProperty.Register("XamlBracketForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xFF)), OnPropertyChanged));

		public Brush XamlTagForeground
		{
			get { return (Brush)GetValue(XamlTagForegroundProperty); }
			set { SetValue(XamlTagForegroundProperty, value); }
		}

		public static readonly DependencyProperty XamlTagForegroundProperty =
			DependencyProperty.Register("XamlTagForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0xA3, 0x15, 0x15)), OnPropertyChanged));

		public Brush XamlNsSeparatorForeground
		{
			get { return (Brush)GetValue(XamlNsSeparatorForegroundProperty); }
			set { SetValue(XamlNsSeparatorForegroundProperty, value); }
		}

		public static readonly DependencyProperty XamlNsSeparatorForegroundProperty =
			DependencyProperty.Register("XamlNsSeparatorForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xFF)), OnPropertyChanged));

		public Brush XamlAttributeNameForeground
		{
			get { return (Brush)GetValue(XamlAttributeNameForegroundProperty); }
			set { SetValue(XamlAttributeNameForegroundProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeNameForegroundProperty =
			DependencyProperty.Register("XamlAttributeNameForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0x00, 0x00)), OnPropertyChanged));

		public Brush XamlAttributeValueForeground
		{
			get { return (Brush)GetValue(XamlAttributeValueForegroundProperty); }
			set { SetValue(XamlAttributeValueForegroundProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeValueForegroundProperty =
			DependencyProperty.Register("XamlAttributeValueForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xFF)), OnPropertyChanged));

		public Brush XamlAttributeAssignmentForeground
		{
			get { return (Brush)GetValue(XamlAttributeAssignmentForegroundProperty); }
			set { SetValue(XamlAttributeAssignmentForegroundProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeAssignmentForegroundProperty =
			DependencyProperty.Register("XamlAttributeAssignmentForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xFF)), OnPropertyChanged));

		public Brush KeywordForeground
		{
			get { return (Brush)GetValue(KeywordForegroundProperty); }
			set { SetValue(KeywordForegroundProperty, value); }
		}

		public static readonly DependencyProperty KeywordForegroundProperty =
			DependencyProperty.Register("KeywordForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xFF)), OnPropertyChanged));

		public Brush NumberForeground
		{
			get { return (Brush)GetValue(NumberForegroundProperty); }
			set { SetValue(NumberForegroundProperty, value); }
		}

		public static readonly DependencyProperty NumberForegroundProperty =
			DependencyProperty.Register("NumberForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x80, 0x00, 0x00)), OnPropertyChanged));

		public Brush StringForeground
		{
			get { return (Brush)GetValue(StringForegroundProperty); }
			set { SetValue(StringForegroundProperty, value); }
		}

		public static readonly DependencyProperty StringForegroundProperty =
			DependencyProperty.Register("StringForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0xA3, 0x15, 0x15)), OnPropertyChanged));

		public Brush CommentForeground
		{
			get { return (Brush)GetValue(CommentForegroundProperty); }
			set { SetValue(CommentForegroundProperty, value); }
		}

		public static readonly DependencyProperty CommentForegroundProperty =
			DependencyProperty.Register("CommentForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x80, 0x00)), OnPropertyChanged));

		public Brush NormalForeground
		{
			get { return (Brush)GetValue(NormalForegroundProperty); }
			set { SetValue(NormalForegroundProperty, value); }
		}

		public static readonly DependencyProperty NormalForegroundProperty =
			DependencyProperty.Register("NormalForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(Brushes.Black, OnPropertyChanged));

		public Brush AspxInlineCodeForeground
		{
			get { return (Brush)GetValue(AspxInlineCodeForegroundProperty); }
			set { SetValue(AspxInlineCodeForegroundProperty, value); }
		}

		public static readonly DependencyProperty AspxInlineCodeForegroundProperty =
			DependencyProperty.Register("AspxInlineCodeForeground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(Brushes.Black, OnPropertyChanged));

		public Brush XamlBracketBackground
		{
			get { return (Brush)GetValue(XamlBracketBackgroundProperty); }
			set { SetValue(XamlBracketBackgroundProperty, value); }
		}

		public static readonly DependencyProperty XamlBracketBackgroundProperty =
			DependencyProperty.Register("XamlBracketBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush XamlTagBackground
		{
			get { return (Brush)GetValue(XamlTagBackgroundProperty); }
			set { SetValue(XamlTagBackgroundProperty, value); }
		}

		public static readonly DependencyProperty XamlTagBackgroundProperty =
			DependencyProperty.Register("XamlTagBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush XamlNsSeparatorBackground
		{
			get { return (Brush)GetValue(XamlNsSeparatorBackgroundProperty); }
			set { SetValue(XamlNsSeparatorBackgroundProperty, value); }
		}

		public static readonly DependencyProperty XamlNsSeparatorBackgroundProperty =
			DependencyProperty.Register("XamlNsSeparatorBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush XamlAttributeNameBackground
		{
			get { return (Brush)GetValue(XamlAttributeNameBackgroundProperty); }
			set { SetValue(XamlAttributeNameBackgroundProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeNameBackgroundProperty =
			DependencyProperty.Register("XamlAttributeNameBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush XamlAttributeValueBackground
		{
			get { return (Brush)GetValue(XamlAttributeValueBackgroundProperty); }
			set { SetValue(XamlAttributeValueBackgroundProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeValueBackgroundProperty =
			DependencyProperty.Register("XamlAttributeValueBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush XamlAttributeAssignmentBackground
		{
			get { return (Brush)GetValue(XamlAttributeAssignmentBackgroundProperty); }
			set { SetValue(XamlAttributeAssignmentBackgroundProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeAssignmentBackgroundProperty =
			DependencyProperty.Register("XamlAttributeAssignmentBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush KeywordBackground
		{
			get { return (Brush)GetValue(KeywordBackgroundProperty); }
			set { SetValue(KeywordBackgroundProperty, value); }
		}

		public static readonly DependencyProperty KeywordBackgroundProperty =
			DependencyProperty.Register("KeywordBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush NumberBackground
		{
			get { return (Brush)GetValue(NumberBackgroundProperty); }
			set { SetValue(NumberBackgroundProperty, value); }
		}

		public static readonly DependencyProperty NumberBackgroundProperty =
			DependencyProperty.Register("NumberBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush StringBackground
		{
			get { return (Brush)GetValue(StringBackgroundProperty); }
			set { SetValue(StringBackgroundProperty, value); }
		}

		public static readonly DependencyProperty StringBackgroundProperty =
			DependencyProperty.Register("StringBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush CommentBackground
		{
			get { return (Brush)GetValue(CommentBackgroundProperty); }
			set { SetValue(CommentBackgroundProperty, value); }
		}

		public static readonly DependencyProperty CommentBackgroundProperty =
			DependencyProperty.Register("CommentBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush NormalBackground
		{
			get { return (Brush)GetValue(NormalBackgroundProperty); }
			set { SetValue(NormalBackgroundProperty, value); }
		}

		public static readonly DependencyProperty NormalBackgroundProperty =
			DependencyProperty.Register("NormalBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public Brush AspxInlineCodeBackground
		{
			get { return (Brush)GetValue(AspxInlineCodeBackgroundProperty); }
			set { SetValue(AspxInlineCodeBackgroundProperty, value); }
		}

		public static readonly DependencyProperty AspxInlineCodeBackgroundProperty =
			DependencyProperty.Register("AspxInlineCodeBackground", typeof(Brush), typeof(SourceCodeViewer),
			new PropertyMetadata(new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0x4C)), OnPropertyChanged));

		public FontWeight? XamlBracketFontWeight
		{
			get { return (FontWeight?)GetValue(XamlBracketFontWeightProperty); }
			set { SetValue(XamlBracketFontWeightProperty, value); }
		}

		public static readonly DependencyProperty XamlBracketFontWeightProperty =
			DependencyProperty.Register("XamlBracketFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? XamlTagFontWeight
		{
			get { return (FontWeight?)GetValue(XamlTagFontWeightProperty); }
			set { SetValue(XamlTagFontWeightProperty, value); }
		}

		public static readonly DependencyProperty XamlTagFontWeightProperty =
			DependencyProperty.Register("XamlTagFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? XamlNsSeparatorFontWeight
		{
			get { return (FontWeight?)GetValue(XamlNsSeparatorFontWeightProperty); }
			set { SetValue(XamlNsSeparatorFontWeightProperty, value); }
		}

		public static readonly DependencyProperty XamlNsSeparatorFontWeightProperty =
			DependencyProperty.Register("XamlNsSeparatorFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? XamlAttributeNameFontWeight
		{
			get { return (FontWeight?)GetValue(XamlAttributeNameFontWeightProperty); }
			set { SetValue(XamlAttributeNameFontWeightProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeNameFontWeightProperty =
			DependencyProperty.Register("XamlAttributeNameFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? XamlAttributeValueFontWeight
		{
			get { return (FontWeight?)GetValue(XamlAttributeValueFontWeightProperty); }
			set { SetValue(XamlAttributeValueFontWeightProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeValueFontWeightProperty =
			DependencyProperty.Register("XamlAttributeValueFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? XamlAttributeAssignmentFontWeight
		{
			get { return (FontWeight?)GetValue(XamlAttributeAssignmentFontWeightProperty); }
			set { SetValue(XamlAttributeAssignmentFontWeightProperty, value); }
		}

		public static readonly DependencyProperty XamlAttributeAssignmentFontWeightProperty =
			DependencyProperty.Register("XamlAttributeAssignmentFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? KeywordFontWeight
		{
			get { return (FontWeight?)GetValue(KeywordFontWeightProperty); }
			set { SetValue(KeywordFontWeightProperty, value); }
		}

		public static readonly DependencyProperty KeywordFontWeightProperty =
			DependencyProperty.Register("KeywordFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? NumberFontWeight
		{
			get { return (FontWeight?)GetValue(NumberFontWeightProperty); }
			set { SetValue(NumberFontWeightProperty, value); }
		}

		public static readonly DependencyProperty NumberFontWeightProperty =
			DependencyProperty.Register("NumberFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? StringFontWeight
		{
			get { return (FontWeight?)GetValue(StringFontWeightProperty); }
			set { SetValue(StringFontWeightProperty, value); }
		}

		public static readonly DependencyProperty StringFontWeightProperty =
			DependencyProperty.Register("StringFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? CommentFontWeight
		{
			get { return (FontWeight?)GetValue(CommentFontWeightProperty); }
			set { SetValue(CommentFontWeightProperty, value); }
		}

		public static readonly DependencyProperty CommentFontWeightProperty =
			DependencyProperty.Register("CommentFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? NormalFontWeight
		{
			get { return (FontWeight?)GetValue(NormalFontWeightProperty); }
			set { SetValue(NormalFontWeightProperty, value); }
		}

		public static readonly DependencyProperty NormalFontWeightProperty =
			DependencyProperty.Register("NormalFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));

		public FontWeight? AspxInlineCodeFontWeight
		{
			get { return (FontWeight?)GetValue(AspxInlineCodeFontWeightProperty); }
			set { SetValue(AspxInlineCodeFontWeightProperty, value); }
		}

		public static readonly DependencyProperty AspxInlineCodeFontWeightProperty =
			DependencyProperty.Register("AspxInlineCodeFontWeight", typeof(FontWeight?), typeof(SourceCodeViewer),
			new PropertyMetadata(OnPropertyChanged));


		private FlowDocumentScrollViewer viewer;
	}

	public enum CodeLanguage
	{
		None,
		Aspx,
		CSharp,
		VisualBasic,
		Xaml,
		Css,
		JavaScript,
		CPlusPlus,
		Delphi,
	}
}
