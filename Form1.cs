using System;
using System.Windows.Forms;

namespace PGenV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // I intentionnally put letters and digits in random order to more randomize the result
        const string LOWERCASE = "nbvcxwmlkjhgfdsqpoiuytreza";
        const string UPPERCASE = "AZERTYUIOPQSDFGHJKLMWXCVBN";
        const string DIGITS = "9638052741";
        const string SPECIALS = "$%!}?@#)&*{/=+(";
        Random random = new Random();
        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length, int pwdNums)
        {
            char[] password = new char[length];
            string charSet = "";

            if (lowerCase)
                charSet += LOWERCASE;
            if (upperCase)
                charSet += UPPERCASE;
            if (mumberic)
                charSet += DIGITS;
            if (specialCharacter)
                charSet += SPECIALS;
            for (int i = 0; i < length; i++)
                password[i] = charSet[random.Next(charSet.Length - 1)];

            return string.Join(null, password);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < int.Parse(txtPasswordNum.Text); i++)
                {
                    string thetext = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecial.Checked, int.Parse(txtPasswordLength.Text), int.Parse(txtPasswordNum.Text));
                    txtPassword.AppendText(thetext + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearInputs_Click(object sender, EventArgs e)
        {
            chkLowerCase.Checked = false;
            chkUpperCase.Checked = false;
            chkNumeric.Checked = false;
            chkSpecial.Checked = false;
            txtPasswordLength.Clear();
            txtPassword.Clear();
            txtPasswordNum.Clear();
            MessageBox.Show("All inputs are cleared!");
        }
        private void copyPassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Password Copied!");
            }
            else
            {
                MessageBox.Show("There is no password to copy!");
            }
        }
    }
}

