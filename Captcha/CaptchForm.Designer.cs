﻿namespace Captcha
{
    partial class CaptchForm
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelCaptch = new System.Windows.Forms.Label();
            this.textBoxCaptch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(263, 186);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(223, 57);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обновить капчу";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelCaptch
            // 
            this.labelCaptch.AutoSize = true;
            this.labelCaptch.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaptch.Location = new System.Drawing.Point(313, 109);
            this.labelCaptch.Name = "labelCaptch";
            this.labelCaptch.Size = new System.Drawing.Size(117, 48);
            this.labelCaptch.TabIndex = 1;
            this.labelCaptch.Text = "label1";
            this.labelCaptch.Click += new System.EventHandler(this.labelCaptch_Click);
            // 
            // textBoxCaptch
            // 
            this.textBoxCaptch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCaptch.Location = new System.Drawing.Point(263, 281);
            this.textBoxCaptch.Name = "textBoxCaptch";
            this.textBoxCaptch.Size = new System.Drawing.Size(223, 24);
            this.textBoxCaptch.TabIndex = 2;
            this.textBoxCaptch.TextChanged += new System.EventHandler(this.textBoxCaptch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCaptch);
            this.Controls.Add(this.labelCaptch);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelCaptch;
        private System.Windows.Forms.TextBox textBoxCaptch;
        private System.Windows.Forms.Timer timer1;
    }
}