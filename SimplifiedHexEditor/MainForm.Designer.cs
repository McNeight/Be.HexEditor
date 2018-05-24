namespace SimplifiedHexEditor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.btnShadowSelectionColor = new System.Windows.Forms.Button();
            this.btnSelectionForeColor = new System.Windows.Forms.Button();
            this.btnSelectionBackColor = new System.Windows.Forms.Button();
            this.btnInfoForeColor = new System.Windows.Forms.Button();
            this.btnBackColorDisabled = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.gbIntegers = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGroupSize = new System.Windows.Forms.NumericUpDown();
            this.nudBytesPerLine = new System.Windows.Forms.NumericUpDown();
            this.gbBooleans = new System.Windows.Forms.GroupBox();
            this.cbShadowSelection = new System.Windows.Forms.CheckBox();
            this.cbStringView = new System.Windows.Forms.CheckBox();
            this.cbLineInfo = new System.Windows.Forms.CheckBox();
            this.cbColumnInfo = new System.Windows.Forms.CheckBox();
            this.cbVerticalScrollBar = new System.Windows.Forms.CheckBox();
            this.cbFixedBytesPerLine = new System.Windows.Forms.CheckBox();
            this.cbGroupSeparator = new System.Windows.Forms.CheckBox();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.btnLoadRandomData = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nudLineInfoOffset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHexCasing = new System.Windows.Forms.ComboBox();
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.hexBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnForeColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbColors.SuspendLayout();
            this.gbIntegers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBytesPerLine)).BeginInit();
            this.gbBooleans.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineInfoOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hexBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.btnFont);
            this.splitContainer1.Panel2.Controls.Add(this.gbColors);
            this.splitContainer1.Panel2.Controls.Add(this.gbIntegers);
            this.splitContainer1.Panel2.Controls.Add(this.gbBooleans);
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadRandomData);
            this.splitContainer1.Size = new System.Drawing.Size(800, 465);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbColors
            // 
            this.gbColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbColors.Controls.Add(this.btnForeColor);
            this.gbColors.Controls.Add(this.btnShadowSelectionColor);
            this.gbColors.Controls.Add(this.btnBackColor);
            this.gbColors.Controls.Add(this.btnSelectionForeColor);
            this.gbColors.Controls.Add(this.btnSelectionBackColor);
            this.gbColors.Controls.Add(this.btnInfoForeColor);
            this.gbColors.Controls.Add(this.btnBackColorDisabled);
            this.gbColors.Location = new System.Drawing.Point(143, 32);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(136, 262);
            this.gbColors.TabIndex = 6;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "HexBox Colors";
            // 
            // btnShadowSelectionColor
            // 
            this.btnShadowSelectionColor.AutoSize = true;
            this.btnShadowSelectionColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShadowSelectionColor.Location = new System.Drawing.Point(6, 193);
            this.btnShadowSelectionColor.Name = "btnShadowSelectionColor";
            this.btnShadowSelectionColor.Size = new System.Drawing.Size(124, 23);
            this.btnShadowSelectionColor.TabIndex = 4;
            this.btnShadowSelectionColor.Text = "ShadowSelectionColor";
            this.btnShadowSelectionColor.UseVisualStyleBackColor = true;
            this.btnShadowSelectionColor.Click += new System.EventHandler(this.btnShadowSelectionColor_Click);
            // 
            // btnSelectionForeColor
            // 
            this.btnSelectionForeColor.AutoSize = true;
            this.btnSelectionForeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectionForeColor.Location = new System.Drawing.Point(6, 164);
            this.btnSelectionForeColor.Name = "btnSelectionForeColor";
            this.btnSelectionForeColor.Size = new System.Drawing.Size(106, 23);
            this.btnSelectionForeColor.TabIndex = 3;
            this.btnSelectionForeColor.Text = "SelectionForeColor";
            this.btnSelectionForeColor.UseVisualStyleBackColor = true;
            this.btnSelectionForeColor.Click += new System.EventHandler(this.btnSelectionForeColor_Click);
            // 
            // btnSelectionBackColor
            // 
            this.btnSelectionBackColor.AutoSize = true;
            this.btnSelectionBackColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectionBackColor.Location = new System.Drawing.Point(6, 135);
            this.btnSelectionBackColor.Name = "btnSelectionBackColor";
            this.btnSelectionBackColor.Size = new System.Drawing.Size(110, 23);
            this.btnSelectionBackColor.TabIndex = 2;
            this.btnSelectionBackColor.Text = "SelectionBackColor";
            this.btnSelectionBackColor.UseVisualStyleBackColor = true;
            this.btnSelectionBackColor.Click += new System.EventHandler(this.btnSelectionBackColor_Click);
            // 
            // btnInfoForeColor
            // 
            this.btnInfoForeColor.AutoSize = true;
            this.btnInfoForeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInfoForeColor.Location = new System.Drawing.Point(6, 106);
            this.btnInfoForeColor.Name = "btnInfoForeColor";
            this.btnInfoForeColor.Size = new System.Drawing.Size(80, 23);
            this.btnInfoForeColor.TabIndex = 1;
            this.btnInfoForeColor.Text = "InfoForeColor";
            this.btnInfoForeColor.UseVisualStyleBackColor = true;
            this.btnInfoForeColor.Click += new System.EventHandler(this.btnInfoForeColor_Click);
            // 
            // btnBackColorDisabled
            // 
            this.btnBackColorDisabled.AutoSize = true;
            this.btnBackColorDisabled.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackColorDisabled.Location = new System.Drawing.Point(6, 77);
            this.btnBackColorDisabled.Name = "btnBackColorDisabled";
            this.btnBackColorDisabled.Size = new System.Drawing.Size(107, 23);
            this.btnBackColorDisabled.TabIndex = 0;
            this.btnBackColorDisabled.Text = "BackColorDisabled";
            this.btnBackColorDisabled.UseVisualStyleBackColor = true;
            this.btnBackColorDisabled.Click += new System.EventHandler(this.btnBackColorDisabled_Click);
            // 
            // btnFont
            // 
            this.btnFont.AutoSize = true;
            this.btnFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFont.Location = new System.Drawing.Point(176, 3);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(98, 23);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Font && Text Color";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.AutoSize = true;
            this.btnBackColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackColor.Location = new System.Drawing.Point(6, 48);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(66, 23);
            this.btnBackColor.TabIndex = 1;
            this.btnBackColor.Text = "BackColor";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // gbIntegers
            // 
            this.gbIntegers.AutoSize = true;
            this.gbIntegers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbIntegers.Controls.Add(this.label4);
            this.gbIntegers.Controls.Add(this.cbHexCasing);
            this.gbIntegers.Controls.Add(this.label3);
            this.gbIntegers.Controls.Add(this.nudLineInfoOffset);
            this.gbIntegers.Controls.Add(this.label2);
            this.gbIntegers.Controls.Add(this.label1);
            this.gbIntegers.Controls.Add(this.nudGroupSize);
            this.gbIntegers.Controls.Add(this.nudBytesPerLine);
            this.gbIntegers.Location = new System.Drawing.Point(3, 300);
            this.gbIntegers.Name = "gbIntegers";
            this.gbIntegers.Size = new System.Drawing.Size(152, 132);
            this.gbIntegers.TabIndex = 4;
            this.gbIntegers.TabStop = false;
            this.gbIntegers.Text = "HexBox Integers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bytes Per Line";
            // 
            // nudGroupSize
            // 
            this.nudGroupSize.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hexBoxBindingSource, "GroupSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudGroupSize.Location = new System.Drawing.Point(88, 40);
            this.nudGroupSize.Name = "nudGroupSize";
            this.nudGroupSize.Size = new System.Drawing.Size(58, 20);
            this.nudGroupSize.TabIndex = 3;
            // 
            // nudBytesPerLine
            // 
            this.nudBytesPerLine.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hexBoxBindingSource, "BytesPerLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.nudBytesPerLine.Location = new System.Drawing.Point(88, 14);
            this.nudBytesPerLine.Name = "nudBytesPerLine";
            this.nudBytesPerLine.Size = new System.Drawing.Size(58, 20);
            this.nudBytesPerLine.TabIndex = 0;
            // 
            // gbBooleans
            // 
            this.gbBooleans.AutoSize = true;
            this.gbBooleans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbBooleans.Controls.Add(this.cbShadowSelection);
            this.gbBooleans.Controls.Add(this.cbStringView);
            this.gbBooleans.Controls.Add(this.cbLineInfo);
            this.gbBooleans.Controls.Add(this.cbColumnInfo);
            this.gbBooleans.Controls.Add(this.cbVerticalScrollBar);
            this.gbBooleans.Controls.Add(this.cbFixedBytesPerLine);
            this.gbBooleans.Controls.Add(this.cbGroupSeparator);
            this.gbBooleans.Controls.Add(this.cbReadOnly);
            this.gbBooleans.Location = new System.Drawing.Point(3, 32);
            this.gbBooleans.Name = "gbBooleans";
            this.gbBooleans.Size = new System.Drawing.Size(134, 262);
            this.gbBooleans.TabIndex = 3;
            this.gbBooleans.TabStop = false;
            this.gbBooleans.Text = "HexBox Booleans";
            // 
            // cbShadowSelection
            // 
            this.cbShadowSelection.AutoSize = true;
            this.cbShadowSelection.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "ShadowSelectionVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShadowSelection.Location = new System.Drawing.Point(6, 226);
            this.cbShadowSelection.Name = "cbShadowSelection";
            this.cbShadowSelection.Size = new System.Drawing.Size(112, 17);
            this.cbShadowSelection.TabIndex = 8;
            this.cbShadowSelection.Text = "Shadow Selection";
            this.cbShadowSelection.UseVisualStyleBackColor = true;
            // 
            // cbStringView
            // 
            this.cbStringView.AutoSize = true;
            this.cbStringView.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "StringViewVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbStringView.Location = new System.Drawing.Point(6, 197);
            this.cbStringView.Name = "cbStringView";
            this.cbStringView.Size = new System.Drawing.Size(79, 17);
            this.cbStringView.TabIndex = 7;
            this.cbStringView.Text = "String View";
            this.cbStringView.UseVisualStyleBackColor = true;
            // 
            // cbLineInfo
            // 
            this.cbLineInfo.AutoSize = true;
            this.cbLineInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "LineInfoVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbLineInfo.Location = new System.Drawing.Point(6, 168);
            this.cbLineInfo.Name = "cbLineInfo";
            this.cbLineInfo.Size = new System.Drawing.Size(101, 17);
            this.cbLineInfo.TabIndex = 6;
            this.cbLineInfo.Text = "Line Information";
            this.cbLineInfo.UseVisualStyleBackColor = true;
            // 
            // cbColumnInfo
            // 
            this.cbColumnInfo.AutoSize = true;
            this.cbColumnInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "ColumnInfoVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbColumnInfo.Location = new System.Drawing.Point(6, 139);
            this.cbColumnInfo.Name = "cbColumnInfo";
            this.cbColumnInfo.Size = new System.Drawing.Size(116, 17);
            this.cbColumnInfo.TabIndex = 5;
            this.cbColumnInfo.Text = "Column Information";
            this.cbColumnInfo.UseVisualStyleBackColor = true;
            // 
            // cbVerticalScrollBar
            // 
            this.cbVerticalScrollBar.AutoSize = true;
            this.cbVerticalScrollBar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "VScrollBarVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbVerticalScrollBar.Location = new System.Drawing.Point(6, 81);
            this.cbVerticalScrollBar.Name = "cbVerticalScrollBar";
            this.cbVerticalScrollBar.Size = new System.Drawing.Size(109, 17);
            this.cbVerticalScrollBar.TabIndex = 4;
            this.cbVerticalScrollBar.Text = "Vertical Scroll Bar";
            this.cbVerticalScrollBar.UseVisualStyleBackColor = true;
            // 
            // cbFixedBytesPerLine
            // 
            this.cbFixedBytesPerLine.AutoSize = true;
            this.cbFixedBytesPerLine.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "UseFixedBytesPerLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFixedBytesPerLine.Location = new System.Drawing.Point(6, 52);
            this.cbFixedBytesPerLine.Name = "cbFixedBytesPerLine";
            this.cbFixedBytesPerLine.Size = new System.Drawing.Size(122, 17);
            this.cbFixedBytesPerLine.TabIndex = 3;
            this.cbFixedBytesPerLine.Text = "Fixed Bytes Per Line";
            this.cbFixedBytesPerLine.UseVisualStyleBackColor = true;
            // 
            // cbGroupSeparator
            // 
            this.cbGroupSeparator.AutoSize = true;
            this.cbGroupSeparator.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "GroupSeparatorVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbGroupSeparator.Location = new System.Drawing.Point(6, 110);
            this.cbGroupSeparator.Name = "cbGroupSeparator";
            this.cbGroupSeparator.Size = new System.Drawing.Size(104, 17);
            this.cbGroupSeparator.TabIndex = 2;
            this.cbGroupSeparator.Text = "Group Separator";
            this.cbGroupSeparator.UseVisualStyleBackColor = true;
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.hexBoxBindingSource, "ReadOnly", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbReadOnly.Location = new System.Drawing.Point(6, 23);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(76, 17);
            this.cbReadOnly.TabIndex = 1;
            this.cbReadOnly.Text = "Read Only";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            // 
            // btnLoadRandomData
            // 
            this.btnLoadRandomData.Location = new System.Drawing.Point(3, 3);
            this.btnLoadRandomData.Name = "btnLoadRandomData";
            this.btnLoadRandomData.Size = new System.Drawing.Size(167, 23);
            this.btnLoadRandomData.TabIndex = 2;
            this.btnLoadRandomData.Text = "Load Random Data";
            this.btnLoadRandomData.UseVisualStyleBackColor = true;
            this.btnLoadRandomData.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // nudLineInfoOffset
            // 
            this.nudLineInfoOffset.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hexBoxBindingSource, "LineInfoOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudLineInfoOffset.Hexadecimal = true;
            this.nudLineInfoOffset.Location = new System.Drawing.Point(88, 66);
            this.nudLineInfoOffset.Name = "nudLineInfoOffset";
            this.nudLineInfoOffset.Size = new System.Drawing.Size(58, 20);
            this.nudLineInfoOffset.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Line Info Offset";
            // 
            // cbHexCasing
            // 
            this.cbHexCasing.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hexBoxBindingSource, "HexCasing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbHexCasing.FormattingEnabled = true;
            this.cbHexCasing.Location = new System.Drawing.Point(88, 92);
            this.cbHexCasing.Name = "cbHexCasing";
            this.cbHexCasing.Size = new System.Drawing.Size(58, 21);
            this.cbHexCasing.TabIndex = 0;
            this.cbHexCasing.Text = "Upper";
            // 
            // hexBox1
            // 
            this.hexBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexBox1.Location = new System.Drawing.Point(0, 0);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox1.Size = new System.Drawing.Size(492, 465);
            this.hexBox1.TabIndex = 1;
            this.hexBox1.SelectionStartChanged += new System.EventHandler(this.hexBox1_SelectionStartChanged);
            this.hexBox1.SelectionLengthChanged += new System.EventHandler(this.hexBox1_SelectionLengthChanged);
            this.hexBox1.CurrentLineChanged += new System.EventHandler(this.hexBox1_CurrentLineChanged);
            this.hexBox1.CurrentPositionInLineChanged += new System.EventHandler(this.hexBox1_CurrentPositionInLineChanged);
            // 
            // hexBoxBindingSource
            // 
            this.hexBoxBindingSource.DataSource = typeof(Be.Windows.Forms.HexBox);
            // 
            // btnForeColor
            // 
            this.btnForeColor.AutoSize = true;
            this.btnForeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForeColor.Location = new System.Drawing.Point(6, 19);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(62, 23);
            this.btnForeColor.TabIndex = 5;
            this.btnForeColor.Text = "ForeColor";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hex Casing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Simplified Hex Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.gbIntegers.ResumeLayout(false);
            this.gbIntegers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGroupSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBytesPerLine)).EndInit();
            this.gbBooleans.ResumeLayout(false);
            this.gbBooleans.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineInfoOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hexBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Be.Windows.Forms.HexBox hexBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnLoadRandomData;
        private System.Windows.Forms.GroupBox gbBooleans;
        private System.Windows.Forms.NumericUpDown nudBytesPerLine;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hexBoxBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGroupSize;
        private System.Windows.Forms.GroupBox gbIntegers;
        private System.Windows.Forms.CheckBox cbGroupSeparator;
        private System.Windows.Forms.CheckBox cbFixedBytesPerLine;
        private System.Windows.Forms.CheckBox cbVerticalScrollBar;
        private System.Windows.Forms.CheckBox cbColumnInfo;
        private System.Windows.Forms.CheckBox cbLineInfo;
        private System.Windows.Forms.CheckBox cbStringView;
        private System.Windows.Forms.CheckBox cbShadowSelection;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.Button btnBackColorDisabled;
        private System.Windows.Forms.Button btnInfoForeColor;
        private System.Windows.Forms.Button btnSelectionBackColor;
        private System.Windows.Forms.Button btnSelectionForeColor;
        private System.Windows.Forms.Button btnShadowSelectionColor;
        private System.Windows.Forms.NumericUpDown nudLineInfoOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHexCasing;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label4;
    }
}

