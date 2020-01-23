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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUnsorted = new System.Windows.Forms.RadioButton();
            this.radSorted = new System.Windows.Forms.RadioButton();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.radLinear = new System.Windows.Forms.RadioButton();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblProbeLabel = new System.Windows.Forms.Label();
            this.lblPostionLabel = new System.Windows.Forms.Label();
            this.lblFoundLabel = new System.Windows.Forms.Label();
            this.lblProbes = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.ColumnWidth = 30;
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(289, 167);
            this.lstNumbers.MultiColumn = true;
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(364, 134);
            this.lstNumbers.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUnsorted);
            this.groupBox1.Controls.Add(this.radSorted);
            this.groupBox1.Location = new System.Drawing.Point(83, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.radBinary);
            this.grpSearch.Controls.Add(this.radLinear);
            this.grpSearch.Location = new System.Drawing.Point(83, 269);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(200, 100);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Location = new System.Drawing.Point(20, 58);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(54, 17);
            this.radBinary.TabIndex = 1;
            this.radBinary.Text = "Binary";
            this.radBinary.UseVisualStyleBackColor = true;
            // 
            // radLinear
            // 
            this.radLinear.AutoSize = true;
            this.radLinear.Checked = true;
            this.radLinear.Location = new System.Drawing.Point(20, 34);
            this.radLinear.Name = "radLinear";
            this.radLinear.Size = new System.Drawing.Size(54, 17);
            this.radLinear.TabIndex = 0;
            this.radLinear.TabStop = true;
            this.radLinear.Text = "Linear";
            this.radLinear.UseVisualStyleBackColor = true;
            // 
            // btnInitialise
            // 
            this.btnInitialise.Location = new System.Drawing.Point(103, 228);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnInitialise.TabIndex = 2;
            this.btnInitialise.Text = "Initialise";
            this.btnInitialise.UseVisualStyleBackColor = true;
            this.btnInitialise.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(380, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(461, 346);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 6;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(470, 125);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(347, 127);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 20);
            this.txtInsert.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(55, 377);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(178, 375);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblProbeLabel
            // 
            this.lblProbeLabel.AutoSize = true;
            this.lblProbeLabel.Location = new System.Drawing.Point(80, 452);
            this.lblProbeLabel.Name = "lblProbeLabel";
            this.lblProbeLabel.Size = new System.Drawing.Size(43, 13);
            this.lblProbeLabel.TabIndex = 11;
            this.lblProbeLabel.Text = "Probes:";
            // 
            // lblPostionLabel
            // 
            this.lblPostionLabel.AutoSize = true;
            this.lblPostionLabel.Location = new System.Drawing.Point(80, 478);
            this.lblPostionLabel.Name = "lblPostionLabel";
            this.lblPostionLabel.Size = new System.Drawing.Size(47, 13);
            this.lblPostionLabel.TabIndex = 12;
            this.lblPostionLabel.Text = "Position:";
            // 
            // lblFoundLabel
            // 
            this.lblFoundLabel.AutoSize = true;
            this.lblFoundLabel.Location = new System.Drawing.Point(80, 465);
            this.lblFoundLabel.Name = "lblFoundLabel";
            this.lblFoundLabel.Size = new System.Drawing.Size(43, 13);
            this.lblFoundLabel.TabIndex = 13;
            this.lblFoundLabel.Text = "Found?";
            // 
            // lblProbes
            // 
            this.lblProbes.AutoSize = true;
            this.lblProbes.Location = new System.Drawing.Point(136, 452);
            this.lblProbes.Name = "lblProbes";
            this.lblProbes.Size = new System.Drawing.Size(0, 13);
            this.lblProbes.TabIndex = 14;
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(136, 465);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(0, 13);
            this.lblFound.TabIndex = 15;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(136, 478);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 13);
            this.lblPosition.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(809, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Shuffle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.lblProbes);
            this.Controls.Add(this.lblFoundLabel);
            this.Controls.Add(this.lblPostionLabel);
            this.Controls.Add(this.lblProbeLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInitialise);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}

