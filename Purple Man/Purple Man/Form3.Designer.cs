namespace Purple_Man
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.flatButton1 = new FlatUI.FlatButton();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton6 = new FlatUI.FlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flatButton4 = new FlatUI.FlatButton();
            this.flatButton13 = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatCheckBox1 = new FlatUI.FlatCheckBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(12, 242);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Execute";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(219, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 12);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(567, 224);
            this.fastColoredTextBox1.TabIndex = 1;
            this.fastColoredTextBox1.Text = "--paste your script here";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(124, 242);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Clear";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.FlatButton2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(473, 242);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(106, 32);
            this.flatButton3.TabIndex = 3;
            this.flatButton3.Text = "Inject";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.FlatButton3_Click);
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton6.Location = new System.Drawing.Point(604, 132);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(106, 32);
            this.flatButton6.TabIndex = 14;
            this.flatButton6.Text = "Infinite Jump";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton6.Click += new System.EventHandler(this.FlatButton6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(604, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 24);
            this.textBox1.TabIndex = 13;
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(604, 35);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(106, 32);
            this.flatButton4.TabIndex = 12;
            this.flatButton4.Text = "Walk Speed";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.FlatButton4_Click);
            // 
            // flatButton13
            // 
            this.flatButton13.BackColor = System.Drawing.Color.Transparent;
            this.flatButton13.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton13.Location = new System.Drawing.Point(604, 242);
            this.flatButton13.Name = "flatButton13";
            this.flatButton13.Rounded = false;
            this.flatButton13.Size = new System.Drawing.Size(106, 32);
            this.flatButton13.TabIndex = 15;
            this.flatButton13.Text = "Inf Gems";
            this.flatButton13.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton13.Click += new System.EventHandler(this.FlatButton13_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(585, 210);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(134, 17);
            this.flatLabel1.TabIndex = 16;
            this.flatLabel1.Text = "Clone Tycoon 2 Script";
            // 
            // flatCheckBox1
            // 
            this.flatCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBox1.Checked = false;
            this.flatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBox1.Location = new System.Drawing.Point(604, 7);
            this.flatCheckBox1.Name = "flatCheckBox1";
            this.flatCheckBox1.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBox1.Size = new System.Drawing.Size(112, 22);
            this.flatCheckBox1.TabIndex = 17;
            this.flatCheckBox1.Text = "TopMost";
            this.flatCheckBox1.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBox1_CheckedChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(333, 260);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(119, 17);
            this.flatLabel2.TabIndex = 18;
            this.flatLabel2.Text = "Owner: godlykillzzz";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(236, 242);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(169, 17);
            this.flatLabel3.TabIndex = 19;
            this.flatLabel3.Text = "Created By: TomerGamerTV";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(722, 286);
            this.Controls.Add(this.flatLabel3);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this.flatCheckBox1);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.flatButton13);
            this.Controls.Add(this.flatButton6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flatButton4);
            this.Controls.Add(this.flatButton3);
            this.Controls.Add(this.flatButton2);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.flatButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Purple Man";
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatButton flatButton1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton6;
        private System.Windows.Forms.TextBox textBox1;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatButton flatButton13;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatCheckBox flatCheckBox1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel3;
    }
}