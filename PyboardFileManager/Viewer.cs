using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyboardFileManager
{
    public partial class Viewer : Form
    {
        private string _micropython_keywords = string.Empty;
        private string _micropython_modules = string.Empty;

        public Viewer(string filename, PyboardRoutines pyb)
        {
            InitializeComponent();

            _micropython_keywords = ConfigurationManager.AppSettings["Python.Keywords"];
            string[] mk = _micropython_keywords.Split(' ');
            Array.Sort(mk);
            string smk = string.Empty;
            foreach (string k in mk)
                smk += " " + k;
            _micropython_keywords = smk.Trim();

            string modules = pyb.pyboardModules();
            string[] mm = modules.Split(' ');
            Array.Sort(mm);
            string smm = string.Empty;
            foreach (string m in mm)
                smm += " " + m;
            _micropython_modules = smm.Trim();

            ConfigureForPython(scintilla1, _micropython_keywords, _micropython_modules);

            string LF = "\n";
            string CRLF = "\r\n";
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string contents = sr.ReadToEnd();
                    scintilla1.Text = contents.Replace(CRLF, LF);
                    scintilla1.ReadOnly = true;
                }
                this.Text = Path.GetFileName(filename);
            }
        }

        private void ConfigureForPython(Scintilla scintilla, string keywords, string modules)
        {
            // Reset the styles
            scintilla.StyleResetDefault();
            string EditorFont = ConfigurationManager.AppSettings["EditorFont"];
            if (!String.IsNullOrEmpty(EditorFont))
                scintilla.Styles[Style.Default].Font = EditorFont;
            else
                scintilla.Styles[Style.Default].Font = "Consolas";
            string EditorFontSize = ConfigurationManager.AppSettings["EditorFontSize"];
            if (!String.IsNullOrEmpty(EditorFontSize))
                scintilla.Styles[Style.Default].Size = Convert.ToInt32(EditorFontSize);
            else
                scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll(); // i.e. Apply to all

            // Set the lexer
            scintilla.Lexer = Lexer.Python;

            // Known lexer properties:
            // "tab.timmy.whinge.level",
            // "lexer.python.literals.binary",
            // "lexer.python.strings.u",
            // "lexer.python.strings.b",
            // "lexer.python.strings.over.newline",
            // "lexer.python.keywords2.no.sub.identifiers",
            // "fold.quotes.python",
            // "fold.compact",
            // "fold"

            // Some properties we like
            scintilla.SetProperty("tab.timmy.whinge.level", "1");
            scintilla.SetProperty("fold", "1");

            scintilla1.Margins[0].Width = 35;
            scintilla1.Margins[0].Type = MarginType.Number;

            // Use margin 2 for fold markers
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 30;

            // Reset folder markers
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Style the folder markers
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            // Set the styles
            scintilla.Styles[Style.Python.Default].ForeColor = Utils.DecodeColor("Python.Default.ForeColor");
            scintilla.Styles[Style.Python.CommentLine].ForeColor = Utils.DecodeColor("Python.CommentLine.ForeColor");
            scintilla.Styles[Style.Python.CommentLine].Italic = Utils.DecodeBoolean("Python.CommentLine.Italic");
            scintilla.Styles[Style.Python.Number].ForeColor = Utils.DecodeColor("Python.Number.ForeColor");
            scintilla.Styles[Style.Python.String].ForeColor = Utils.DecodeColor("Python.String.ForeColor");
            scintilla.Styles[Style.Python.Character].ForeColor = Utils.DecodeColor("Python.Character.ForeColor");
            scintilla.Styles[Style.Python.Word].ForeColor = Utils.DecodeColor("Python.Word.ForeColor");
            scintilla.Styles[Style.Python.Word].Bold = Utils.DecodeBoolean("Python.Word.Bold");
            scintilla.Styles[Style.Python.Triple].ForeColor = Utils.DecodeColor("Python.Triple.ForeColor");
            scintilla.Styles[Style.Python.TripleDouble].ForeColor = Utils.DecodeColor("Python.TripleDouble.ForeColor");
            scintilla.Styles[Style.Python.ClassName].ForeColor = Utils.DecodeColor("Python.ClassName.ForeColor");
            scintilla.Styles[Style.Python.ClassName].Bold = Utils.DecodeBoolean("Python.ClassName.Bold");
            scintilla.Styles[Style.Python.DefName].ForeColor = Utils.DecodeColor("Python.DefName.ForeColor");
            scintilla.Styles[Style.Python.DefName].Bold = Utils.DecodeBoolean("Python.DefName.Bold");
            scintilla.Styles[Style.Python.Operator].Bold = Utils.DecodeBoolean("Python.Operator.Bold");
            scintilla.Styles[Style.Python.Identifier].ForeColor = Utils.DecodeColor("Python.Identifier.ForeColor");
            scintilla.Styles[Style.Python.CommentBlock].ForeColor = Utils.DecodeColor("Python.CommentBlock.ForeColor");
            scintilla.Styles[Style.Python.CommentBlock].Italic = Utils.DecodeBoolean("Python.CommentBlock.Italic");
            scintilla.Styles[Style.Python.StringEol].ForeColor = Utils.DecodeColor("Python.StringEol.ForeColor");
            scintilla.Styles[Style.Python.StringEol].BackColor = Utils.DecodeColor("Python.StringEol.BackColor");
            scintilla.Styles[Style.Python.StringEol].Bold = Utils.DecodeBoolean("Python.StringEol.Bold");
            scintilla.Styles[Style.Python.StringEol].FillLine = Utils.DecodeBoolean("Python.StringEol.FillLine");
            scintilla.Styles[Style.Python.Word2].ForeColor = Utils.DecodeColor("Python.Word2.ForeColor");
            scintilla.Styles[Style.Python.Decorator].ForeColor = Utils.DecodeColor("Python.Decorator.ForeColor");

            // Important for Python
            scintilla.ViewWhitespace = WhitespaceMode.VisibleAlways;

            // Keyword lists:
            // 0 "Keywords",
            // 1 "Highlighted identifiers"

            scintilla.SetKeywords(0, keywords);
            scintilla.SetKeywords(1, modules);
        }

    }
}
