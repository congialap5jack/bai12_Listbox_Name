﻿namespace bai12_Listbox_Name
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnREMOVE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnADD.Location = new System.Drawing.Point(349, 35);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(113, 71);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(38, 79);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(240, 173);
            this.lstName.TabIndex = 2;
            this.lstName.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.Red;
            this.btnEDIT.Location = new System.Drawing.Point(349, 121);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(113, 71);
            this.btnEDIT.TabIndex = 1;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.BackColor = System.Drawing.Color.Cyan;
            this.btnREMOVE.Location = new System.Drawing.Point(349, 210);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.Size = new System.Drawing.Size(113, 71);
            this.btnREMOVE.TabIndex = 1;
            this.btnREMOVE.Text = "REMOVE";
            this.btnREMOVE.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "THÊM VÀO LIST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "THÊM VÀO LISTBOX";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.btnREMOVE);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnREMOVE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
