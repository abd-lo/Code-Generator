namespace CodeGenCrud
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tpInputs = new System.Windows.Forms.TabPage();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFuncName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBusClassName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDataAccessClassName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkConstructors = new System.Windows.Forms.CheckBox();
			this.btnUnCheckAll = new System.Windows.Forms.Button();
			this.chkSave = new System.Windows.Forms.CheckBox();
			this.btnCheckAll = new System.Windows.Forms.Button();
			this.chkFind = new System.Windows.Forms.CheckBox();
			this.chkDelete = new System.Windows.Forms.CheckBox();
			this.chkUpdate = new System.Windows.Forms.CheckBox();
			this.chkAddNew = new System.Windows.Forms.CheckBox();
			this.chkGetAll = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpOutputs = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtBus = new FastColoredTextBoxNS.FastColoredTextBox();
			this.txtData = new FastColoredTextBoxNS.FastColoredTextBox();
			this.rdNormalVars = new System.Windows.Forms.RadioButton();
			this.rdSetGetVars = new System.Windows.Forms.RadioButton();
			this.rtxtVars = new FastColoredTextBoxNS.FastColoredTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tpInputs.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpOutputs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rtxtVars)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tpInputs
			// 
			this.tpInputs.BackColor = System.Drawing.Color.Black;
			this.tpInputs.Controls.Add(this.rdSetGetVars);
			this.tpInputs.Controls.Add(this.textBox1);
			this.tpInputs.Controls.Add(this.rdNormalVars);
			this.tpInputs.Controls.Add(this.rtxtVars);
			this.tpInputs.Controls.Add(this.btnGenerate);
			this.tpInputs.Controls.Add(this.groupBox2);
			this.tpInputs.Location = new System.Drawing.Point(4, 33);
			this.tpInputs.Name = "tpInputs";
			this.tpInputs.Padding = new System.Windows.Forms.Padding(3);
			this.tpInputs.Size = new System.Drawing.Size(1562, 907);
			this.tpInputs.TabIndex = 0;
			this.tpInputs.Text = "Inputs";
			// 
			// btnGenerate
			// 
			this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 30F);
			this.btnGenerate.Location = new System.Drawing.Point(493, 646);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(379, 185);
			this.btnGenerate.TabIndex = 6;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = false;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtFuncName);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtBusClassName);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtDataAccessClassName);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtTableName);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 17F);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(465, 852);
			this.groupBox2.TabIndex = 79;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Inputs";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(185, 324);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 22);
			this.label3.TabIndex = 82;
			this.label3.Text = "Vars";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 13F);
			this.label8.ForeColor = System.Drawing.Color.DarkOrange;
			this.label8.Location = new System.Drawing.Point(33, 261);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(244, 22);
			this.label8.TabIndex = 85;
			this.label8.Text = "FuncName(AddNew*Person*)";
			// 
			// txtFuncName
			// 
			this.txtFuncName.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtFuncName.ForeColor = System.Drawing.SystemColors.Info;
			this.txtFuncName.Location = new System.Drawing.Point(37, 286);
			this.txtFuncName.Name = "txtFuncName";
			this.txtFuncName.Size = new System.Drawing.Size(397, 35);
			this.txtFuncName.TabIndex = 4;
			this.txtFuncName.Text = "Person";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 13F);
			this.label7.ForeColor = System.Drawing.Color.DarkOrange;
			this.label7.Location = new System.Drawing.Point(33, 188);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 22);
			this.label7.TabIndex = 70;
			this.label7.Text = "BusClassName";
			// 
			// txtBusClassName
			// 
			this.txtBusClassName.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtBusClassName.ForeColor = System.Drawing.SystemColors.Info;
			this.txtBusClassName.Location = new System.Drawing.Point(37, 213);
			this.txtBusClassName.Name = "txtBusClassName";
			this.txtBusClassName.Size = new System.Drawing.Size(402, 35);
			this.txtBusClassName.TabIndex = 3;
			this.txtBusClassName.Text = "clsPerson";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 13F);
			this.label6.ForeColor = System.Drawing.Color.DarkOrange;
			this.label6.Location = new System.Drawing.Point(33, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(183, 22);
			this.label6.TabIndex = 68;
			this.label6.Text = "DataAccessClassName";
			// 
			// txtDataAccessClassName
			// 
			this.txtDataAccessClassName.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtDataAccessClassName.ForeColor = System.Drawing.SystemColors.Info;
			this.txtDataAccessClassName.Location = new System.Drawing.Point(37, 138);
			this.txtDataAccessClassName.Name = "txtDataAccessClassName";
			this.txtDataAccessClassName.Size = new System.Drawing.Size(402, 35);
			this.txtDataAccessClassName.TabIndex = 2;
			this.txtDataAccessClassName.Text = "clsPersonData";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
			this.label5.ForeColor = System.Drawing.Color.DarkOrange;
			this.label5.Location = new System.Drawing.Point(33, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 22);
			this.label5.TabIndex = 66;
			this.label5.Text = "TableName";
			// 
			// txtTableName
			// 
			this.txtTableName.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtTableName.ForeColor = System.Drawing.SystemColors.Info;
			this.txtTableName.Location = new System.Drawing.Point(37, 65);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(402, 35);
			this.txtTableName.TabIndex = 1;
			this.txtTableName.Text = "People";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkConstructors);
			this.groupBox1.Controls.Add(this.btnUnCheckAll);
			this.groupBox1.Controls.Add(this.chkSave);
			this.groupBox1.Controls.Add(this.btnCheckAll);
			this.groupBox1.Controls.Add(this.chkFind);
			this.groupBox1.Controls.Add(this.chkDelete);
			this.groupBox1.Controls.Add(this.chkUpdate);
			this.groupBox1.Controls.Add(this.chkAddNew);
			this.groupBox1.Controls.Add(this.chkGetAll);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 17F);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Location = new System.Drawing.Point(12, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 405);
			this.groupBox1.TabIndex = 86;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Functions";
			// 
			// chkConstructors
			// 
			this.chkConstructors.AutoSize = true;
			this.chkConstructors.Checked = true;
			this.chkConstructors.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConstructors.Location = new System.Drawing.Point(54, 49);
			this.chkConstructors.Name = "chkConstructors";
			this.chkConstructors.Size = new System.Drawing.Size(158, 32);
			this.chkConstructors.TabIndex = 89;
			this.chkConstructors.Text = "Constructors";
			this.chkConstructors.UseVisualStyleBackColor = true;
			// 
			// btnUnCheckAll
			// 
			this.btnUnCheckAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnUnCheckAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnUnCheckAll.Font = new System.Drawing.Font("Tahoma", 10F);
			this.btnUnCheckAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnUnCheckAll.Location = new System.Drawing.Point(6, 343);
			this.btnUnCheckAll.Name = "btnUnCheckAll";
			this.btnUnCheckAll.Size = new System.Drawing.Size(154, 45);
			this.btnUnCheckAll.TabIndex = 88;
			this.btnUnCheckAll.Text = "UnCheckAll";
			this.btnUnCheckAll.UseVisualStyleBackColor = false;
			this.btnUnCheckAll.Click += new System.EventHandler(this.btnUnCheckAll_Click);
			// 
			// chkSave
			// 
			this.chkSave.AutoSize = true;
			this.chkSave.Checked = true;
			this.chkSave.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSave.Location = new System.Drawing.Point(54, 277);
			this.chkSave.Name = "chkSave";
			this.chkSave.Size = new System.Drawing.Size(79, 32);
			this.chkSave.TabIndex = 72;
			this.chkSave.Text = "Save";
			this.chkSave.UseVisualStyleBackColor = true;
			// 
			// btnCheckAll
			// 
			this.btnCheckAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnCheckAll.Font = new System.Drawing.Font("Tahoma", 10F);
			this.btnCheckAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCheckAll.Location = new System.Drawing.Point(200, 343);
			this.btnCheckAll.Name = "btnCheckAll";
			this.btnCheckAll.Size = new System.Drawing.Size(154, 45);
			this.btnCheckAll.TabIndex = 87;
			this.btnCheckAll.Text = "CheckAll";
			this.btnCheckAll.UseVisualStyleBackColor = false;
			this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
			// 
			// chkFind
			// 
			this.chkFind.AutoSize = true;
			this.chkFind.Checked = true;
			this.chkFind.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFind.Location = new System.Drawing.Point(54, 239);
			this.chkFind.Name = "chkFind";
			this.chkFind.Size = new System.Drawing.Size(74, 32);
			this.chkFind.TabIndex = 71;
			this.chkFind.Text = "Find";
			this.chkFind.UseVisualStyleBackColor = true;
			// 
			// chkDelete
			// 
			this.chkDelete.AutoSize = true;
			this.chkDelete.Checked = true;
			this.chkDelete.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDelete.Location = new System.Drawing.Point(54, 201);
			this.chkDelete.Name = "chkDelete";
			this.chkDelete.Size = new System.Drawing.Size(96, 32);
			this.chkDelete.TabIndex = 70;
			this.chkDelete.Text = "Delete";
			this.chkDelete.UseVisualStyleBackColor = true;
			// 
			// chkUpdate
			// 
			this.chkUpdate.AutoSize = true;
			this.chkUpdate.Checked = true;
			this.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkUpdate.Location = new System.Drawing.Point(54, 163);
			this.chkUpdate.Name = "chkUpdate";
			this.chkUpdate.Size = new System.Drawing.Size(104, 32);
			this.chkUpdate.TabIndex = 69;
			this.chkUpdate.Text = "Update";
			this.chkUpdate.UseVisualStyleBackColor = true;
			// 
			// chkAddNew
			// 
			this.chkAddNew.AutoSize = true;
			this.chkAddNew.Checked = true;
			this.chkAddNew.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAddNew.Location = new System.Drawing.Point(54, 125);
			this.chkAddNew.Name = "chkAddNew";
			this.chkAddNew.Size = new System.Drawing.Size(115, 32);
			this.chkAddNew.TabIndex = 68;
			this.chkAddNew.Text = "AddNew";
			this.chkAddNew.UseVisualStyleBackColor = true;
			// 
			// chkGetAll
			// 
			this.chkGetAll.AutoSize = true;
			this.chkGetAll.Checked = true;
			this.chkGetAll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkGetAll.Location = new System.Drawing.Point(54, 87);
			this.chkGetAll.Name = "chkGetAll";
			this.chkGetAll.Size = new System.Drawing.Size(90, 32);
			this.chkGetAll.TabIndex = 67;
			this.chkGetAll.Text = "GetAll";
			this.chkGetAll.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpInputs);
			this.tabControl1.Controls.Add(this.tpOutputs);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 15F);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1570, 944);
			this.tabControl1.TabIndex = 88;
			// 
			// tpOutputs
			// 
			this.tpOutputs.Controls.Add(this.splitContainer1);
			this.tpOutputs.Location = new System.Drawing.Point(4, 33);
			this.tpOutputs.Name = "tpOutputs";
			this.tpOutputs.Padding = new System.Windows.Forms.Padding(3);
			this.tpOutputs.Size = new System.Drawing.Size(1137, 732);
			this.tpOutputs.TabIndex = 2;
			this.tpOutputs.Text = "Outputs";
			this.tpOutputs.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtBus);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtData);
			this.splitContainer1.Size = new System.Drawing.Size(1131, 726);
			this.splitContainer1.SplitterDistance = 564;
			this.splitContainer1.TabIndex = 0;
			// 
			// txtBus
			// 
			this.txtBus.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.txtBus.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
			this.txtBus.AutoScrollMinSize = new System.Drawing.Size(0, 21);
			this.txtBus.BackBrush = null;
			this.txtBus.BackColor = System.Drawing.Color.Black;
			this.txtBus.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.txtBus.CharHeight = 21;
			this.txtBus.CharWidth = 11;
			this.txtBus.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBus.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtBus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBus.Font = new System.Drawing.Font("Courier New", 14F);
			this.txtBus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtBus.IndentBackColor = System.Drawing.Color.DimGray;
			this.txtBus.IsReplaceMode = false;
			this.txtBus.Language = FastColoredTextBoxNS.Language.CSharp;
			this.txtBus.LeftBracket = '(';
			this.txtBus.LeftBracket2 = '{';
			this.txtBus.LineNumberColor = System.Drawing.Color.Gold;
			this.txtBus.Location = new System.Drawing.Point(0, 0);
			this.txtBus.Name = "txtBus";
			this.txtBus.Paddings = new System.Windows.Forms.Padding(0);
			this.txtBus.RightBracket = ')';
			this.txtBus.RightBracket2 = '}';
			this.txtBus.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.txtBus.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtBus.ServiceColors")));
			this.txtBus.ServiceLinesColor = System.Drawing.Color.SeaGreen;
			this.txtBus.Size = new System.Drawing.Size(564, 726);
			this.txtBus.TabIndex = 83;
			this.txtBus.Text = "//Bus Code";
			this.txtBus.WordWrap = true;
			this.txtBus.Zoom = 100;
			// 
			// txtData
			// 
			this.txtData.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.txtData.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
			this.txtData.AutoScrollMinSize = new System.Drawing.Size(0, 21);
			this.txtData.BackBrush = null;
			this.txtData.BackColor = System.Drawing.Color.Black;
			this.txtData.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.txtData.CharHeight = 21;
			this.txtData.CharWidth = 11;
			this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtData.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtData.Font = new System.Drawing.Font("Courier New", 14F);
			this.txtData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtData.IndentBackColor = System.Drawing.Color.DimGray;
			this.txtData.IsReplaceMode = false;
			this.txtData.Language = FastColoredTextBoxNS.Language.CSharp;
			this.txtData.LeftBracket = '(';
			this.txtData.LeftBracket2 = '{';
			this.txtData.LineNumberColor = System.Drawing.Color.DarkOrange;
			this.txtData.Location = new System.Drawing.Point(0, 0);
			this.txtData.Name = "txtData";
			this.txtData.Paddings = new System.Windows.Forms.Padding(0);
			this.txtData.RightBracket = ')';
			this.txtData.RightBracket2 = '}';
			this.txtData.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.txtData.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtData.ServiceColors")));
			this.txtData.ServiceLinesColor = System.Drawing.Color.SeaGreen;
			this.txtData.Size = new System.Drawing.Size(563, 726);
			this.txtData.TabIndex = 84;
			this.txtData.Text = "//DataCode";
			this.txtData.WordWrap = true;
			this.txtData.Zoom = 100;
			// 
			// rdNormalVars
			// 
			this.rdNormalVars.AutoSize = true;
			this.rdNormalVars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rdNormalVars.Location = new System.Drawing.Point(493, 21);
			this.rdNormalVars.Name = "rdNormalVars";
			this.rdNormalVars.Size = new System.Drawing.Size(131, 28);
			this.rdNormalVars.TabIndex = 86;
			this.rdNormalVars.Text = "NormalVars";
			this.rdNormalVars.UseVisualStyleBackColor = true;
			// 
			// rdSetGetVars
			// 
			this.rdSetGetVars.AutoSize = true;
			this.rdSetGetVars.Checked = true;
			this.rdSetGetVars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rdSetGetVars.Location = new System.Drawing.Point(647, 21);
			this.rdSetGetVars.Name = "rdSetGetVars";
			this.rdSetGetVars.Size = new System.Drawing.Size(127, 28);
			this.rdSetGetVars.TabIndex = 87;
			this.rdSetGetVars.TabStop = true;
			this.rdSetGetVars.Text = "SetGetVars";
			this.rdSetGetVars.UseVisualStyleBackColor = true;
			// 
			// rtxtVars
			// 
			this.rtxtVars.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.rtxtVars.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
			this.rtxtVars.AutoScrollMinSize = new System.Drawing.Size(0, 21);
			this.rtxtVars.BackBrush = null;
			this.rtxtVars.BackColor = System.Drawing.Color.Black;
			this.rtxtVars.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.rtxtVars.CharHeight = 21;
			this.rtxtVars.CharWidth = 11;
			this.rtxtVars.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.rtxtVars.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.rtxtVars.Dock = System.Windows.Forms.DockStyle.Right;
			this.rtxtVars.Font = new System.Drawing.Font("Courier New", 14F);
			this.rtxtVars.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rtxtVars.IndentBackColor = System.Drawing.Color.DimGray;
			this.rtxtVars.IsReplaceMode = false;
			this.rtxtVars.Language = FastColoredTextBoxNS.Language.CSharp;
			this.rtxtVars.LeftBracket = '(';
			this.rtxtVars.LeftBracket2 = '{';
			this.rtxtVars.LineNumberColor = System.Drawing.Color.Gold;
			this.rtxtVars.Location = new System.Drawing.Point(878, 3);
			this.rtxtVars.Name = "rtxtVars";
			this.rtxtVars.Paddings = new System.Windows.Forms.Padding(0);
			this.rtxtVars.RightBracket = ')';
			this.rtxtVars.RightBracket2 = '}';
			this.rtxtVars.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.rtxtVars.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("rtxtVars.ServiceColors")));
			this.rtxtVars.ServiceLinesColor = System.Drawing.Color.SeaGreen;
			this.rtxtVars.Size = new System.Drawing.Size(681, 901);
			this.rtxtVars.TabIndex = 90;
			this.rtxtVars.Text = "int PersonID,string FirstName,float Fees";
			this.rtxtVars.WordWrap = true;
			this.rtxtVars.Zoom = 100;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(5, 333);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(454, 507);
			this.panel1.TabIndex = 88;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
			this.textBox1.Location = new System.Drawing.Point(477, 147);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(395, 303);
			this.textBox1.TabIndex = 89;
			this.textBox1.Text = "People";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnGenerate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.CancelButton = this.btnUnCheckAll;
			this.ClientSize = new System.Drawing.Size(1570, 944);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tpInputs.ResumeLayout(false);
			this.tpInputs.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tpOutputs.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtBus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rtxtVars)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tpInputs;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFuncName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBusClassName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDataAccessClassName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnUnCheckAll;
		private System.Windows.Forms.CheckBox chkSave;
		private System.Windows.Forms.Button btnCheckAll;
		private System.Windows.Forms.CheckBox chkFind;
		private System.Windows.Forms.CheckBox chkDelete;
		private System.Windows.Forms.CheckBox chkUpdate;
		private System.Windows.Forms.CheckBox chkAddNew;
		private System.Windows.Forms.CheckBox chkGetAll;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpOutputs;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private FastColoredTextBoxNS.FastColoredTextBox txtBus;
		private FastColoredTextBoxNS.FastColoredTextBox txtData;
		private System.Windows.Forms.CheckBox chkConstructors;
		private System.Windows.Forms.Panel panel1;
		private FastColoredTextBoxNS.FastColoredTextBox rtxtVars;
		private System.Windows.Forms.RadioButton rdSetGetVars;
		private System.Windows.Forms.RadioButton rdNormalVars;
		private System.Windows.Forms.TextBox textBox1;
	}
}

