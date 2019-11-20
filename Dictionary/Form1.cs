using System;

using System.Windows.Forms;

namespace Dictionary
{
    public partial class frmMain : Form
    {
        FileHelper fileHelper;
        public frmMain()
        {
            InitializeComponent();
            fileHelper = new FileHelper();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] languages = fileHelper.GetLanguagesFromFile();
            cmbLanguage1.Items.AddRange(languages);
            cmbLanguage2.Items.AddRange(languages);
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (cmbLanguage1.Text == cmbLanguage2.Text)
                txtLanguage2.Text = txtLanguage1.Text;
            else
            {
                txtLanguage2.Text = fileHelper.Translate(cmbLanguage1.Text.Trim(), cmbLanguage2.Text.Trim(), txtLanguage1.Text.Trim());

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fileHelper.WriteWordToFile(cmbLanguage1.Text.Trim(), cmbLanguage2.Text.Trim(), txtLanguage1.Text.Trim(), txtLanguage2.Text.Trim());
        }

        private void cmbLanguage1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbLanguage2.SelectedIndex!=-1 && cmbLanguage1.SelectedIndex!=-1)
                btnTranslate.Enabled = true;
        }

        private void txtLanguage1_TextChanged(object sender, EventArgs e)
        {
        //    if (cmbLanguage1.Text == cmbLanguage2.Text)
        //        txtLanguage2.Text = txtLanguage1.Text;
        //    else
        //    {
        //        txtLanguage2.Text = fileHelper.Translate(cmbLanguage1.Text.Trim(), cmbLanguage2.Text.Trim(), txtLanguage1.Text.Trim());

        //    }
        }

        private void cmbLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage1.SelectedIndex!=-1 && cmbLanguage2.SelectedIndex!=-1)
                btnTranslate.Enabled = true;
        }
    }
}
