namespace bai12_Listbox_Name
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
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnREMOVE = new System.Windows.Forms.Button();
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
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(38, 79);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(240, 173);
            this.lstNames.TabIndex = 2;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNames);
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
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnREMOVE;
    }
}
