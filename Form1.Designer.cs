namespace PGenV1
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
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkNumeric = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.clearInputs = new System.Windows.Forms.Button();
            this.copyPassword = new System.Windows.Forms.Button();
            this.txtPasswordNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Location = new System.Drawing.Point(37, 147);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(78, 17);
            this.chkUpperCase.TabIndex = 0;
            this.chkUpperCase.Text = "Uppercase";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Location = new System.Drawing.Point(37, 86);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(78, 17);
            this.chkLowerCase.TabIndex = 1;
            this.chkLowerCase.Text = "Lowercase";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(37, 211);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(52, 17);
            this.chkNumeric.TabIndex = 2;
            this.chkNumeric.Text = "Digits";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(37, 279);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(66, 17);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Specials";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(534, 90);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(223, 20);
            this.txtPasswordLength.TabIndex = 4;
            this.txtPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(534, 175);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(223, 151);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generated Passwords";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(534, 345);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(223, 34);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // clearInputs
            // 
            this.clearInputs.Location = new System.Drawing.Point(534, 396);
            this.clearInputs.Name = "clearInputs";
            this.clearInputs.Size = new System.Drawing.Size(223, 33);
            this.clearInputs.TabIndex = 9;
            this.clearInputs.Text = "Clear";
            this.clearInputs.UseVisualStyleBackColor = true;
            this.clearInputs.Click += new System.EventHandler(this.clearInputs_Click);
            // 
            // copyPassword
            // 
            this.copyPassword.Location = new System.Drawing.Point(534, 446);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(223, 32);
            this.copyPassword.TabIndex = 10;
            this.copyPassword.Text = "Copy";
            this.copyPassword.UseVisualStyleBackColor = true;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // txtPasswordNum
            // 
            this.txtPasswordNum.Location = new System.Drawing.Point(534, 132);
            this.txtPasswordNum.Name = "txtPasswordNum";
            this.txtPasswordNum.Size = new System.Drawing.Size(223, 20);
            this.txtPasswordNum.TabIndex = 11;
            this.txtPasswordNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswordNum);
            this.Controls.Add(this.copyPassword);
            this.Controls.Add(this.clearInputs);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.chkSpecial);
            this.Controls.Add(this.chkNumeric);
            this.Controls.Add(this.chkLowerCase);
            this.Controls.Add(this.chkUpperCase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkNumeric;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button clearInputs;
        private System.Windows.Forms.Button copyPassword;
        private System.Windows.Forms.TextBox txtPasswordNum;
        private System.Windows.Forms.Label label3;
    }
}

