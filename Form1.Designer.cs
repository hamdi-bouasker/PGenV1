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
            this.chkUpperCase.Location = new System.Drawing.Point(49, 119);
            this.chkUpperCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(94, 20);
            this.chkUpperCase.TabIndex = 0;
            this.chkUpperCase.Text = "Uppercase";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Location = new System.Drawing.Point(49, 44);
            this.chkLowerCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(92, 20);
            this.chkLowerCase.TabIndex = 1;
            this.chkLowerCase.Text = "Lowercase";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            this.chkNumeric.AutoSize = true;
            this.chkNumeric.Location = new System.Drawing.Point(49, 199);
            this.chkNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Size = new System.Drawing.Size(60, 20);
            this.chkNumeric.TabIndex = 2;
            this.chkNumeric.Text = "Digits";
            this.chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(49, 283);
            this.chkSpecial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(79, 20);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Specials";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.BackColor = System.Drawing.SystemColors.Info;
            this.txtPasswordLength.Location = new System.Drawing.Point(591, 50);
            this.txtPasswordLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(296, 22);
            this.txtPasswordLength.TabIndex = 4;
            this.txtPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.Location = new System.Drawing.Point(591, 155);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(296, 184);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generated Passwords";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Ivory;
            this.btnGenerate.Location = new System.Drawing.Point(591, 363);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(297, 41);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // clearInputs
            // 
            this.clearInputs.BackColor = System.Drawing.Color.Ivory;
            this.clearInputs.Location = new System.Drawing.Point(591, 427);
            this.clearInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearInputs.Name = "clearInputs";
            this.clearInputs.Size = new System.Drawing.Size(297, 40);
            this.clearInputs.TabIndex = 9;
            this.clearInputs.Text = "Clear";
            this.clearInputs.UseVisualStyleBackColor = false;
            this.clearInputs.Click += new System.EventHandler(this.clearInputs_Click);
            // 
            // copyPassword
            // 
            this.copyPassword.BackColor = System.Drawing.Color.Ivory;
            this.copyPassword.Location = new System.Drawing.Point(591, 487);
            this.copyPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(297, 40);
            this.copyPassword.TabIndex = 10;
            this.copyPassword.Text = "Copy";
            this.copyPassword.UseVisualStyleBackColor = false;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // txtPasswordNum
            // 
            this.txtPasswordNum.BackColor = System.Drawing.SystemColors.Info;
            this.txtPasswordNum.Location = new System.Drawing.Point(591, 102);
            this.txtPasswordNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordNum.Name = "txtPasswordNum";
            this.txtPasswordNum.Size = new System.Drawing.Size(296, 22);
            this.txtPasswordNum.TabIndex = 11;
            this.txtPasswordNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(921, 551);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

