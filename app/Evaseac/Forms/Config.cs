using Evaseac.Properties;
using System;
using System.Windows.Forms;

namespace Evaseac
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void EnablePanel(Panel pnl)
        {
            pnlAdmin.Visible = pnlPreferences.Visible = false;
            pnlAdmin.Enabled = pnlPreferences.Enabled = false;

            pnl.Visible = pnl.Enabled = true;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtCurrentPass.Text = DB.getData(column: "password", table: "Usuario", condition: "WHERE usuario = 'admin'");
            btnAdmin.PerformClick();

            //Preferences
            chkAskParams.Checked = Settings.Default.askEdtParams;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            EnablePanel(pnl: pnlAdmin);
        }

        private void btnPreference_Click(object sender, EventArgs e)
        {
            EnablePanel(pnl: pnlPreferences);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtConfPass.Text)
            {
                DB.Insert("UPDATE Usuario SET password = '" + txtNewPass.Text + "' WHERE usuario = 'admin'");
                Settings.Default.Save();
                MessageBox.Show("Contraseña modificada correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCurrentPass.Text = DB.getData(column: "password", table: "Usuario", condition: "WHERE usuario = 'admin'");
                txtNewPass.Text = txtConfPass.Text = null;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPass.Text = txtConfPass.Text = null;
                txtNewPass.Focus();
            }
        }

        private void chkAskParams_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.askEdtParams = chkAskParams.Checked;
            Settings.Default.Save();
        }
    }
}
