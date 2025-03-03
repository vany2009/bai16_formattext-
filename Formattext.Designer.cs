namespace bai16_formattext__
{
    partial class Formattext
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
            System.Windows.Forms.RadioButton radred;
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.ListBox();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.Font = new System.Windows.Forms.ListBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkgachchan = new System.Windows.Forms.CheckBox();
            this.lbllaptrinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            radred = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên ";
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(140, 45);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(117, 20);
            this.txtNhapten.TabIndex = 1;
            this.txtNhapten.TextChanged += new System.EventHandler(this.txtNhapten_TextChanged);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Chocolate;
            this.color.ForeColor = System.Drawing.SystemColors.MenuText;
            this.color.FormattingEnabled = true;
            this.color.Location = new System.Drawing.Point(80, 113);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(160, 199);
            this.color.TabIndex = 2;
            // 
            // radred
            // 
            radred.AutoSize = true;
            radred.ForeColor = System.Drawing.Color.Red;
            radred.Location = new System.Drawing.Point(89, 152);
            radred.Name = "radred";
            radred.Size = new System.Drawing.Size(45, 17);
            radred.TabIndex = 3;
            radred.TabStop = true;
            radred.Text = "Red";
            radred.UseVisualStyleBackColor = true;
            radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(89, 186);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radBlue.Location = new System.Drawing.Point(89, 224);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 3;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.radblack.Location = new System.Drawing.Point(89, 258);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(52, 17);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // Font
            // 
            this.Font.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Font.FormattingEnabled = true;
            this.Font.Location = new System.Drawing.Point(487, 113);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(170, 199);
            this.Font.TabIndex = 4;
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.ForeColor = System.Drawing.Color.Blue;
            this.chkBold.Location = new System.Drawing.Point(501, 153);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(72, 17);
            this.chkBold.TabIndex = 5;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.ForeColor = System.Drawing.Color.Blue;
            this.chkitalic.Location = new System.Drawing.Point(501, 187);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(91, 17);
            this.chkitalic.TabIndex = 5;
            this.chkitalic.Text = "Nghiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.chkitalic_CheckedChanged);
            // 
            // chkgachchan
            // 
            this.chkgachchan.AutoSize = true;
            this.chkgachchan.BackColor = System.Drawing.Color.Lavender;
            this.chkgachchan.ForeColor = System.Drawing.Color.MediumBlue;
            this.chkgachchan.Location = new System.Drawing.Point(501, 225);
            this.chkgachchan.Name = "chkgachchan";
            this.chkgachchan.Size = new System.Drawing.Size(79, 17);
            this.chkgachchan.TabIndex = 5;
            this.chkgachchan.Text = "Gạch chân";
            this.chkgachchan.UseVisualStyleBackColor = false;
            this.chkgachchan.CheckedChanged += new System.EventHandler(this.chkgachchan_CheckedChanged);
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.Location = new System.Drawing.Point(195, 348);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(117, 20);
            this.lbllaptrinh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(95, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập trình bởi ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formattext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkgachchan);
            this.Controls.Add(this.chkitalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.Font);
            this.Controls.Add(this.radblack);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radGreen);
            this.Controls.Add(radred);
            this.Controls.Add(this.color);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formattext";
            this.Text = "Formattext";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.ListBox color;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.ListBox Font;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkgachchan;
        private System.Windows.Forms.TextBox lbllaptrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}