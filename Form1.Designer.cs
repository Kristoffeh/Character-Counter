namespace Character_counter
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
            this.text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.popup_txt = new System.Windows.Forms.Label();
            this.lbl_charCount = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(12, 24);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(540, 200);
            this.text.TabIndex = 0;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy to clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // popup_txt
            // 
            this.popup_txt.AutoSize = true;
            this.popup_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.popup_txt.Location = new System.Drawing.Point(123, 235);
            this.popup_txt.Name = "popup_txt";
            this.popup_txt.Size = new System.Drawing.Size(101, 13);
            this.popup_txt.TabIndex = 4;
            this.popup_txt.Text = "Copied to clipboard!";
            this.popup_txt.Visible = false;
            // 
            // lbl_charCount
            // 
            this.lbl_charCount.AutoSize = true;
            this.lbl_charCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_charCount.Location = new System.Drawing.Point(483, 235);
            this.lbl_charCount.Name = "lbl_charCount";
            this.lbl_charCount.Size = new System.Drawing.Size(66, 13);
            this.lbl_charCount.TabIndex = 6;
            this.lbl_charCount.Text = "0 characters";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_version.Location = new System.Drawing.Point(16, 6);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(57, 13);
            this.lbl_version.TabIndex = 7;
            this.lbl_version.Text = "lbl_version";
            this.lbl_version.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(564, 260);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_charCount);
            this.Controls.Add(this.popup_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Character Counter (string counter)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label popup_txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_charCount;
        private System.Windows.Forms.Label lbl_version;
    }
}

