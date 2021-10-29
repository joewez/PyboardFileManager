namespace PyboardFileManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnREPL = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMkdir = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.mainSplitter = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstDirectory = new System.Windows.Forms.ListBox();
            this.pnlPath = new System.Windows.Forms.Panel();
            this.lblPath = new System.Windows.Forms.Label();
            this.pnlPathSummary = new System.Windows.Forms.Panel();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFolderCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlSaveMessage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.pnlFileStatus = new System.Windows.Forms.Panel();
            this.pnlEditToolbar = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHelp = new System.Windows.Forms.ComboBox();
            this.btnEditRedo = new System.Windows.Forms.Button();
            this.btnEditUndo = new System.Windows.Forms.Button();
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.btnEditPaste = new System.Windows.Forms.Button();
            this.btnEditCopy = new System.Windows.Forms.Button();
            this.btnEditCut = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFileToolbar = new System.Windows.Forms.Panel();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tmrMessage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).BeginInit();
            this.mainSplitter.Panel1.SuspendLayout();
            this.mainSplitter.Panel2.SuspendLayout();
            this.mainSplitter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPath.SuspendLayout();
            this.pnlPathSummary.SuspendLayout();
            this.pnlCommands.SuspendLayout();
            this.pnlSaveMessage.SuspendLayout();
            this.pnlFileStatus.SuspendLayout();
            this.pnlEditToolbar.SuspendLayout();
            this.pnlFileToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnREPL
            // 
            this.btnREPL.BackColor = System.Drawing.SystemColors.Control;
            this.btnREPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREPL.ForeColor = System.Drawing.Color.Black;
            this.btnREPL.Image = ((System.Drawing.Image)(resources.GetObject("btnREPL.Image")));
            this.btnREPL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnREPL.Location = new System.Drawing.Point(3, 396);
            this.btnREPL.Name = "btnREPL";
            this.btnREPL.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnREPL.Size = new System.Drawing.Size(73, 31);
            this.btnREPL.TabIndex = 10;
            this.btnREPL.Text = "REPL";
            this.btnREPL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnREPL.UseVisualStyleBackColor = false;
            this.btnREPL.Click += new System.EventHandler(this.btnREPL_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(3, 214);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExport.Size = new System.Drawing.Size(73, 30);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.SystemColors.Control;
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMove.Location = new System.Drawing.Point(3, 282);
            this.btnMove.Name = "btnMove";
            this.btnMove.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMove.Size = new System.Drawing.Size(73, 30);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "Move";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(3, 350);
            this.btnRun.Name = "btnRun";
            this.btnRun.Padding = new System.Windows.Forms.Padding(8, 0, 6, 0);
            this.btnRun.Size = new System.Drawing.Size(73, 30);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(3, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRefresh.Size = new System.Drawing.Size(73, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMkdir
            // 
            this.btnMkdir.BackColor = System.Drawing.SystemColors.Control;
            this.btnMkdir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMkdir.Image = ((System.Drawing.Image)(resources.GetObject("btnMkdir.Image")));
            this.btnMkdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMkdir.Location = new System.Drawing.Point(3, 67);
            this.btnMkdir.Name = "btnMkdir";
            this.btnMkdir.Padding = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.btnMkdir.Size = new System.Drawing.Size(73, 30);
            this.btnMkdir.TabIndex = 1;
            this.btnMkdir.Text = "MkDir";
            this.btnMkdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMkdir.UseVisualStyleBackColor = false;
            this.btnMkdir.Click += new System.EventHandler(this.btnMkdir_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(3, 180);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.btnLoad.Size = new System.Drawing.Size(73, 30);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(3, 112);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(6, 0, 2, 0);
            this.btnNew.Size = new System.Drawing.Size(73, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(3, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.btnDelete.Size = new System.Drawing.Size(73, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(3, 146);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.btnOpen.Size = new System.Drawing.Size(73, 30);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter.Location = new System.Drawing.Point(0, 0);
            this.mainSplitter.Name = "mainSplitter";
            // 
            // mainSplitter.Panel1
            // 
            this.mainSplitter.Panel1.Controls.Add(this.panel1);
            this.mainSplitter.Panel1.Controls.Add(this.pnlCommands);
            this.mainSplitter.Panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // mainSplitter.Panel2
            // 
            this.mainSplitter.Panel2.Controls.Add(this.pnlSaveMessage);
            this.mainSplitter.Panel2.Controls.Add(this.scintilla1);
            this.mainSplitter.Panel2.Controls.Add(this.pnlFileStatus);
            this.mainSplitter.Panel2.Controls.Add(this.pnlFileToolbar);
            this.mainSplitter.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.mainSplitter.Size = new System.Drawing.Size(1046, 637);
            this.mainSplitter.SplitterDistance = 344;
            this.mainSplitter.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstDirectory);
            this.panel1.Controls.Add(this.pnlPath);
            this.panel1.Controls.Add(this.pnlPathSummary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(79, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 634);
            this.panel1.TabIndex = 21;
            // 
            // lstDirectory
            // 
            this.lstDirectory.BackColor = System.Drawing.Color.Moccasin;
            this.lstDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDirectory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDirectory.ForeColor = System.Drawing.Color.Black;
            this.lstDirectory.FormattingEnabled = true;
            this.lstDirectory.IntegralHeight = false;
            this.lstDirectory.ItemHeight = 21;
            this.lstDirectory.Location = new System.Drawing.Point(0, 31);
            this.lstDirectory.Name = "lstDirectory";
            this.lstDirectory.Size = new System.Drawing.Size(265, 563);
            this.lstDirectory.TabIndex = 18;
            this.lstDirectory.DoubleClick += new System.EventHandler(this.lstDirectory_DoubleClick);
            // 
            // pnlPath
            // 
            this.pnlPath.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPath.Controls.Add(this.lblPath);
            this.pnlPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPath.Location = new System.Drawing.Point(0, 0);
            this.pnlPath.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.pnlPath.Name = "pnlPath";
            this.pnlPath.Size = new System.Drawing.Size(265, 31);
            this.pnlPath.TabIndex = 15;
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(4, 7);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(254, 16);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "/";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlPathSummary
            // 
            this.pnlPathSummary.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPathSummary.Controls.Add(this.lblFileCount);
            this.pnlPathSummary.Controls.Add(this.label7);
            this.pnlPathSummary.Controls.Add(this.lblFolderCount);
            this.pnlPathSummary.Controls.Add(this.label9);
            this.pnlPathSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPathSummary.Location = new System.Drawing.Point(0, 594);
            this.pnlPathSummary.Name = "pnlPathSummary";
            this.pnlPathSummary.Size = new System.Drawing.Size(265, 40);
            this.pnlPathSummary.TabIndex = 17;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCount.Location = new System.Drawing.Point(136, 12);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(32, 16);
            this.lblFileCount.TabIndex = 3;
            this.lblFileCount.Text = "999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Files:";
            // 
            // lblFolderCount
            // 
            this.lblFolderCount.AutoSize = true;
            this.lblFolderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderCount.Location = new System.Drawing.Point(67, 12);
            this.lblFolderCount.Name = "lblFolderCount";
            this.lblFolderCount.Size = new System.Drawing.Size(32, 16);
            this.lblFolderCount.TabIndex = 1;
            this.lblFolderCount.Text = "999";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sub-Folders:";
            // 
            // pnlCommands
            // 
            this.pnlCommands.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCommands.Controls.Add(this.btnView);
            this.pnlCommands.Controls.Add(this.btnREPL);
            this.pnlCommands.Controls.Add(this.label11);
            this.pnlCommands.Controls.Add(this.btnNew);
            this.pnlCommands.Controls.Add(this.btnDelete);
            this.pnlCommands.Controls.Add(this.btnRun);
            this.pnlCommands.Controls.Add(this.btnLoad);
            this.pnlCommands.Controls.Add(this.btnMove);
            this.pnlCommands.Controls.Add(this.btnOpen);
            this.pnlCommands.Controls.Add(this.btnRefresh);
            this.pnlCommands.Controls.Add(this.btnMkdir);
            this.pnlCommands.Controls.Add(this.btnExport);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCommands.Location = new System.Drawing.Point(0, 3);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(79, 634);
            this.pnlCommands.TabIndex = 20;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.Control;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(3, 316);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(8, 0, 6, 0);
            this.btnView.Size = new System.Drawing.Size(73, 30);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "Current Directory:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSaveMessage
            // 
            this.pnlSaveMessage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSaveMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSaveMessage.Controls.Add(this.label5);
            this.pnlSaveMessage.Location = new System.Drawing.Point(220, 295);
            this.pnlSaveMessage.Name = "pnlSaveMessage";
            this.pnlSaveMessage.Size = new System.Drawing.Size(295, 49);
            this.pnlSaveMessage.TabIndex = 20;
            this.pnlSaveMessage.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "File Saved And Uploaded Successfully.";
            // 
            // scintilla1
            // 
            this.scintilla1.AutoCMaxHeight = 9;
            this.scintilla1.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.EolMode = ScintillaNET.Eol.Lf;
            this.scintilla1.IndentationGuides = ScintillaNET.IndentView.Real;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Python;
            this.scintilla1.Location = new System.Drawing.Point(3, 34);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.ScrollWidth = 1;
            this.scintilla1.Size = new System.Drawing.Size(692, 563);
            this.scintilla1.TabIndents = true;
            this.scintilla1.TabIndex = 12;
            this.scintilla1.UseRightToLeftReadingLayout = false;
            this.scintilla1.WrapMode = ScintillaNET.WrapMode.None;
            this.scintilla1.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            // 
            // pnlFileStatus
            // 
            this.pnlFileStatus.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFileStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFileStatus.Controls.Add(this.pnlEditToolbar);
            this.pnlFileStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFileStatus.Location = new System.Drawing.Point(3, 597);
            this.pnlFileStatus.Name = "pnlFileStatus";
            this.pnlFileStatus.Size = new System.Drawing.Size(692, 37);
            this.pnlFileStatus.TabIndex = 18;
            this.pnlFileStatus.Resize += new System.EventHandler(this.pnlFileStatus_Resize);
            // 
            // pnlEditToolbar
            // 
            this.pnlEditToolbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEditToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEditToolbar.Controls.Add(this.btnFind);
            this.pnlEditToolbar.Controls.Add(this.label2);
            this.pnlEditToolbar.Controls.Add(this.cboHelp);
            this.pnlEditToolbar.Controls.Add(this.btnEditRedo);
            this.pnlEditToolbar.Controls.Add(this.btnEditUndo);
            this.pnlEditToolbar.Controls.Add(this.btnEditDelete);
            this.pnlEditToolbar.Controls.Add(this.btnEditPaste);
            this.pnlEditToolbar.Controls.Add(this.btnEditCopy);
            this.pnlEditToolbar.Controls.Add(this.btnEditCut);
            this.pnlEditToolbar.Controls.Add(this.btnReplaceAll);
            this.pnlEditToolbar.Controls.Add(this.btnSaveAs);
            this.pnlEditToolbar.Controls.Add(this.btnSave);
            this.pnlEditToolbar.Location = new System.Drawing.Point(13, -2);
            this.pnlEditToolbar.Name = "pnlEditToolbar";
            this.pnlEditToolbar.Size = new System.Drawing.Size(661, 37);
            this.pnlEditToolbar.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(407, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(55, 27);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Help:";
            // 
            // cboHelp
            // 
            this.cboHelp.FormattingEnabled = true;
            this.cboHelp.Location = new System.Drawing.Point(45, 10);
            this.cboHelp.Name = "cboHelp";
            this.cboHelp.Size = new System.Drawing.Size(164, 21);
            this.cboHelp.TabIndex = 13;
            this.cboHelp.SelectedIndexChanged += new System.EventHandler(this.cboHelp_SelectedIndexChanged);
            // 
            // btnEditRedo
            // 
            this.btnEditRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRedo.Image")));
            this.btnEditRedo.Location = new System.Drawing.Point(245, 7);
            this.btnEditRedo.Name = "btnEditRedo";
            this.btnEditRedo.Size = new System.Drawing.Size(28, 27);
            this.btnEditRedo.TabIndex = 15;
            this.btnEditRedo.UseVisualStyleBackColor = false;
            this.btnEditRedo.Click += new System.EventHandler(this.btnEditRedo_Click);
            // 
            // btnEditUndo
            // 
            this.btnEditUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUndo.Image")));
            this.btnEditUndo.Location = new System.Drawing.Point(216, 7);
            this.btnEditUndo.Name = "btnEditUndo";
            this.btnEditUndo.Size = new System.Drawing.Size(28, 27);
            this.btnEditUndo.TabIndex = 14;
            this.btnEditUndo.UseVisualStyleBackColor = false;
            this.btnEditUndo.Click += new System.EventHandler(this.btnEditUndo_Click);
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDelete.Image")));
            this.btnEditDelete.Location = new System.Drawing.Point(369, 7);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Size = new System.Drawing.Size(28, 27);
            this.btnEditDelete.TabIndex = 19;
            this.btnEditDelete.UseVisualStyleBackColor = false;
            this.btnEditDelete.Click += new System.EventHandler(this.btnEditDelete_Click);
            // 
            // btnEditPaste
            // 
            this.btnEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPaste.Image")));
            this.btnEditPaste.Location = new System.Drawing.Point(340, 7);
            this.btnEditPaste.Name = "btnEditPaste";
            this.btnEditPaste.Size = new System.Drawing.Size(28, 27);
            this.btnEditPaste.TabIndex = 18;
            this.btnEditPaste.UseVisualStyleBackColor = false;
            this.btnEditPaste.Click += new System.EventHandler(this.btnEditPaste_Click);
            // 
            // btnEditCopy
            // 
            this.btnEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCopy.Image")));
            this.btnEditCopy.Location = new System.Drawing.Point(311, 7);
            this.btnEditCopy.Name = "btnEditCopy";
            this.btnEditCopy.Size = new System.Drawing.Size(28, 27);
            this.btnEditCopy.TabIndex = 17;
            this.btnEditCopy.UseVisualStyleBackColor = false;
            this.btnEditCopy.Click += new System.EventHandler(this.btnEditCopy_Click);
            // 
            // btnEditCut
            // 
            this.btnEditCut.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCut.Image")));
            this.btnEditCut.Location = new System.Drawing.Point(282, 7);
            this.btnEditCut.Name = "btnEditCut";
            this.btnEditCut.Size = new System.Drawing.Size(28, 27);
            this.btnEditCut.TabIndex = 16;
            this.btnEditCut.UseVisualStyleBackColor = false;
            this.btnEditCut.Click += new System.EventHandler(this.btnEditCut_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(463, 7);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(58, 27);
            this.btnReplaceAll.TabIndex = 21;
            this.btnReplaceAll.Text = "Replace";
            this.btnReplaceAll.UseVisualStyleBackColor = false;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(530, 7);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(70, 27);
            this.btnSaveAs.TabIndex = 22;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(601, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 27);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFileToolbar
            // 
            this.pnlFileToolbar.Controls.Add(this.lblCurrentFile);
            this.pnlFileToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFileToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlFileToolbar.Name = "pnlFileToolbar";
            this.pnlFileToolbar.Size = new System.Drawing.Size(692, 31);
            this.pnlFileToolbar.TabIndex = 0;
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(692, 31);
            this.lblCurrentFile.TabIndex = 9;
            this.lblCurrentFile.Text = "<current file>";
            this.lblCurrentFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentFile.Click += new System.EventHandler(this.lblCurrentFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "py";
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|Python Files (*.py)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Export File";
            // 
            // tmrMessage
            // 
            this.tmrMessage.Interval = 800;
            this.tmrMessage.Tick += new System.EventHandler(this.tmrMessage_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 637);
            this.Controls.Add(this.mainSplitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Pyboard File Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.mainSplitter.Panel1.ResumeLayout(false);
            this.mainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).EndInit();
            this.mainSplitter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlPath.ResumeLayout(false);
            this.pnlPathSummary.ResumeLayout(false);
            this.pnlPathSummary.PerformLayout();
            this.pnlCommands.ResumeLayout(false);
            this.pnlSaveMessage.ResumeLayout(false);
            this.pnlSaveMessage.PerformLayout();
            this.pnlFileStatus.ResumeLayout(false);
            this.pnlEditToolbar.ResumeLayout(false);
            this.pnlEditToolbar.PerformLayout();
            this.pnlFileToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainSplitter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMkdir;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnREPL;
        private System.Windows.Forms.Panel pnlFileToolbar;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.Panel pnlFileStatus;
        private System.Windows.Forms.Panel pnlSaveMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrMessage;
        private System.Windows.Forms.Panel pnlEditToolbar;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditCut;
        private System.Windows.Forms.Button btnEditPaste;
        private System.Windows.Forms.Button btnEditCopy;
        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Button btnEditRedo;
        private System.Windows.Forms.Button btnEditUndo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHelp;
        private System.Windows.Forms.Panel pnlPathSummary;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFolderCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstDirectory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCommands;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnView;
    }
}