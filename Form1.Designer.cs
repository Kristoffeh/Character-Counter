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
            this.lblversion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.text.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(12, 24);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(540, 200);
            this.text.TabIndex = 0;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy to clipboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // popup_txt
            // 
            this.popup_txt.AutoSize = true;
            this.popup_txt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popup_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.popup_txt.Location = new System.Drawing.Point(123, 235);
            this.popup_txt.Name = "popup_txt";
            this.popup_txt.Size = new System.Drawing.Size(118, 14);
            this.popup_txt.TabIndex = 4;
            this.popup_txt.Text = "Copied to clipboard!";
            this.popup_txt.Visible = false;
            // 
            // lbl_charCount
            // 
            this.lbl_charCount.AutoSize = true;
            this.lbl_charCount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_charCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_charCount.Location = new System.Drawing.Point(483, 235);
            this.lbl_charCount.Name = "lbl_charCount";
            this.lbl_charCount.Size = new System.Drawing.Size(72, 14);
            this.lbl_charCount.TabIndex = 6;
            this.lbl_charCount.Text = "0 characters";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblversion.Location = new System.Drawing.Point(12, 5);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(151, 14);
            this.lblversion.TabIndex = 7;
            this.lblversion.Text = "Version 0.0 - Built 1/1/1970";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(564, 261);
            this.Controls.Add(this.lblversion);
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
        private System.Windows.Forms.Label lblversion;
    }
}

