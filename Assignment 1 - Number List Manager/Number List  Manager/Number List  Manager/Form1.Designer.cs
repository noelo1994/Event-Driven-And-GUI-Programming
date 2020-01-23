namespace Number_List__Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUnsorted = new System.Windows.Forms.RadioButton();
            this.radSorted = new System.Windows.Forms.RadioButton();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.radLinear = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.lblProbeLabel = new System.Windows.Forms.Label();
            this.lblPostionLabel = new System.Windows.Forms.Label();
            this.lblFoundLabel = new System.Windows.Forms.Label();
            this.lblProbes = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCountLabel = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFirstLabel = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLastLabel = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblMinLabel = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMaxEntries = new System.Windows.Forms.Label();
            this.lblMaxLabel = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMaxEntriesLabel = new System.Windows.Forms.Label();
            this.pboxTrash = new System.Windows.Forms.PictureBox();
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTrash)).BeginInit();
            this.grpInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.ColumnWidth = 30;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(334, 172);
            this.lstNumbers.MultiColumn = true;
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(219, 134);
            this.lstNumbers.TabIndex = 4;
            this.lstNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNumbers_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUnsorted);
            this.groupBox1.Controls.Add(this.radSorted);
            this.groupBox1.Controls.Add(this.btnInitialise);
            this.groupBox1.Location = new System.Drawing.Point(83, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorted / Unsorted";
            // 
            // radUnsorted
            // 
            this.radUnsorted.AutoSize = true;
            this.radUnsorted.Checked = true;
            this.radUnsorted.Location = new System.Drawing.Point(20, 62);
            this.radUnsorted.Name = "radUnsorted";
            this.radUnsorted.Size = new System.Drawing.Size(68, 17);
            this.radUnsorted.TabIndex = 1;
            this.radUnsorted.TabStop = true;
            this.radUnsorted.Text = "Unsorted";
            this.radUnsorted.UseVisualStyleBackColor = true;
            this.radUnsorted.CheckedChanged += new System.EventHandler(this.radUnsorted_CheckedChanged);
            // 
            // radSorted
            // 
            this.radSorted.AutoSize = true;
            this.radSorted.Location = new System.Drawing.Point(20, 38);
            this.radSorted.Name = "radSorted";
            this.radSorted.Size = new System.Drawing.Size(56, 17);
            this.radSorted.TabIndex = 0;
            this.radSorted.Text = "Sorted";
            this.radSorted.UseVisualStyleBackColor = true;
            this.radSorted.CheckedChanged += new System.EventHandler(this.radSorted_CheckedChanged);
            // 
            // btnInitialise
            // 
            this.btnInitialise.Location = new System.Drawing.Point(20, 90);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnInitialise.TabIndex = 2;
            this.btnInitialise.Text = "Initialise";
            this.btnInitialise.UseVisualStyleBackColor = true;
            this.btnInitialise.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radBinary);
            this.grpSearch.Controls.Add(this.radLinear);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Location = new System.Drawing.Point(83, 209);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(108, 152);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Enabled = false;
            this.radBinary.Location = new System.Drawing.Point(20, 58);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(54, 17);
            this.radBinary.TabIndex = 1;
            this.radBinary.Text = "Binary";
            this.radBinary.UseVisualStyleBackColor = true;
            this.radBinary.CheckedChanged += new System.EventHandler(this.radBinary_CheckedChanged);
            // 
            // radLinear
            // 
            this.radLinear.AutoSize = true;
            this.radLinear.Checked = true;
            this.radLinear.Enabled = false;
            this.radLinear.Location = new System.Drawing.Point(20, 34);
            this.radLinear.Name = "radLinear";
            this.radLinear.Size = new System.Drawing.Size(54, 17);
            this.radLinear.TabIndex = 0;
            this.radLinear.TabStop = true;
            this.radLinear.Text = "Linear";
            this.radLinear.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(24, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(64, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(20, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(344, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(457, 312);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 6;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(20, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(20, 35);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 20);
            this.txtInsert.TabIndex = 8;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // lblProbeLabel
            // 
            this.lblProbeLabel.AutoSize = true;
            this.lblProbeLabel.Location = new System.Drawing.Point(239, 265);
            this.lblProbeLabel.Name = "lblProbeLabel";
            this.lblProbeLabel.Size = new System.Drawing.Size(43, 13);
            this.lblProbeLabel.TabIndex = 11;
            this.lblProbeLabel.Text = "Probes:";
            // 
            // lblPostionLabel
            // 
            this.lblPostionLabel.AutoSize = true;
            this.lblPostionLabel.Location = new System.Drawing.Point(239, 291);
            this.lblPostionLabel.Name = "lblPostionLabel";
            this.lblPostionLabel.Size = new System.Drawing.Size(47, 13);
            this.lblPostionLabel.TabIndex = 12;
            this.lblPostionLabel.Text = "Position:";
            // 
            // lblFoundLabel
            // 
            this.lblFoundLabel.AutoSize = true;
            this.lblFoundLabel.Location = new System.Drawing.Point(239, 278);
            this.lblFoundLabel.Name = "lblFoundLabel";
            this.lblFoundLabel.Size = new System.Drawing.Size(43, 13);
            this.lblFoundLabel.TabIndex = 13;
            this.lblFoundLabel.Text = "Found?";
            // 
            // lblProbes
            // 
            this.lblProbes.AutoSize = true;
            this.lblProbes.Location = new System.Drawing.Point(295, 265);
            this.lblProbes.Name = "lblProbes";
            this.lblProbes.Size = new System.Drawing.Size(0, 13);
            this.lblProbes.TabIndex = 14;
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(295, 278);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(0, 13);
            this.lblFound.TabIndex = 15;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(295, 291);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 13);
            this.lblPosition.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(575, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCountLabel
            // 
            this.lblCountLabel.AutoSize = true;
            this.lblCountLabel.Location = new System.Drawing.Point(559, 180);
            this.lblCountLabel.Name = "lblCountLabel";
            this.lblCountLabel.Size = new System.Drawing.Size(95, 13);
            this.lblCountLabel.TabIndex = 19;
            this.lblCountLabel.Text = "Count of Numbers:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(660, 180);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "0";
            // 
            // lblFirstLabel
            // 
            this.lblFirstLabel.AutoSize = true;
            this.lblFirstLabel.Location = new System.Drawing.Point(599, 193);
            this.lblFirstLabel.Name = "lblFirstLabel";
            this.lblFirstLabel.Size = new System.Drawing.Size(55, 13);
            this.lblFirstLabel.TabIndex = 21;
            this.lblFirstLabel.Text = "First in list:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(660, 193);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 13);
            this.lblFirst.TabIndex = 22;
            // 
            // lblLastLabel
            // 
            this.lblLastLabel.AutoSize = true;
            this.lblLastLabel.Location = new System.Drawing.Point(598, 206);
            this.lblLastLabel.Name = "lblLastLabel";
            this.lblLastLabel.Size = new System.Drawing.Size(56, 13);
            this.lblLastLabel.TabIndex = 23;
            this.lblLastLabel.Text = "Last in list:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(660, 206);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(0, 13);
            this.lblLast.TabIndex = 24;
            // 
            // lblMinLabel
            // 
            this.lblMinLabel.AutoSize = true;
            this.lblMinLabel.Location = new System.Drawing.Point(598, 219);
            this.lblMinLabel.Name = "lblMinLabel";
            this.lblMinLabel.Size = new System.Drawing.Size(56, 13);
            this.lblMinLabel.TabIndex = 25;
            this.lblMinLabel.Text = "Min value:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(660, 219);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 13);
            this.lblMin.TabIndex = 26;
            // 
            // lblMaxEntries
            // 
            this.lblMaxEntries.AutoSize = true;
            this.lblMaxEntries.Location = new System.Drawing.Point(660, 244);
            this.lblMaxEntries.Name = "lblMaxEntries";
            this.lblMaxEntries.Size = new System.Drawing.Size(0, 13);
            this.lblMaxEntries.TabIndex = 28;
            // 
            // lblMaxLabel
            // 
            this.lblMaxLabel.AutoSize = true;
            this.lblMaxLabel.Location = new System.Drawing.Point(595, 231);
            this.lblMaxLabel.Name = "lblMaxLabel";
            this.lblMaxLabel.Size = new System.Drawing.Size(59, 13);
            this.lblMaxLabel.TabIndex = 27;
            this.lblMaxLabel.Text = "Max value:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(660, 231);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 13);
            this.lblMax.TabIndex = 30;
            // 
            // lblMaxEntriesLabel
            // 
            this.lblMaxEntriesLabel.AutoSize = true;
            this.lblMaxEntriesLabel.Location = new System.Drawing.Point(590, 244);
            this.lblMaxEntriesLabel.Name = "lblMaxEntriesLabel";
            this.lblMaxEntriesLabel.Size = new System.Drawing.Size(64, 13);
            this.lblMaxEntriesLabel.TabIndex = 29;
            this.lblMaxEntriesLabel.Text = "Max entries:";
            // 
            // pboxTrash
            // 
            this.pboxTrash.Image = ((System.Drawing.Image)(resources.GetObject("pboxTrash.Image")));
            this.pboxTrash.Location = new System.Drawing.Point(368, 52);
            this.pboxTrash.Name = "pboxTrash";
            this.pboxTrash.Size = new System.Drawing.Size(61, 65);
            this.pboxTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTrash.TabIndex = 31;
            this.pboxTrash.TabStop = false;
            this.pboxTrash.DragDrop += new System.Windows.Forms.DragEventHandler(this.pboxTrash_DragDrop);
            this.pboxTrash.DragEnter += new System.Windows.Forms.DragEventHandler(this.pboxTrash_DragEnter);
            // 
            // grpInsert
            // 
            this.grpInsert.Controls.Add(this.txtInsert);
            this.grpInsert.Controls.Add(this.btnInsert);
            this.grpInsert.Location = new System.Drawing.Point(222, 52);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Size = new System.Drawing.Size(113, 100);
            this.grpInsert.TabIndex = 32;
            this.grpInsert.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnInitialise;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 519);
            this.Controls.Add(this.grpInsert);
            this.Controls.Add(this.pboxTrash);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMaxEntriesLabel);
            this.Controls.Add(this.lblMaxEntries);
            this.Controls.Add(this.lblMaxLabel);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMinLabel);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblLastLabel);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblFirstLabel);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCountLabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.lblProbes);
            this.Controls.Add(this.lblFoundLabel);
            this.Controls.Add(this.lblPostionLabel);
            this.Controls.Add(this.lblProbeLabel);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstNumbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Number List Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTrash)).EndInit();
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUnsorted;
        private System.Windows.Forms.RadioButton radSorted;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton radBinary;
        private System.Windows.Forms.RadioButton radLinear;
        private System.Windows.Forms.Button btnInitialise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProbeLabel;
        private System.Windows.Forms.Label lblPostionLabel;
        private System.Windows.Forms.Label lblFoundLabel;
        private System.Windows.Forms.Label lblProbes;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCountLabel;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFirstLabel;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLastLabel;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblMinLabel;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMaxEntries;
        private System.Windows.Forms.Label lblMaxLabel;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMaxEntriesLabel;
        private System.Windows.Forms.PictureBox pboxTrash;
        private System.Windows.Forms.GroupBox grpInsert;
    }
}

