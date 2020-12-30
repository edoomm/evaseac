using Evaseac.Properties;
using System;
using System.Windows.Forms;

namespace Evaseac
{
    public partial class frmDatabase : Form
    {
        private string route;

        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            btnChangeRoute.Visible = false;
            txtFileName.Visible = false;
            this.txtFile.Size = new System.Drawing.Size(450, 18);

            btnOpen.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //if (!txtFile.Text.Equals(""))
            //{
            //    if (txtFileName.Visible)
            //    {
            //        //Create
            //        Settings.Default.dbRouteSource = txtFile.Text;
            //        Settings.Default.Save();
            //        new DB();
            //        DB.CreateDatabase();
            //    }
            //    else
            //    {
            //        //Open
            //        Settings.Default.dbRouteSource = txtFile.Text;
            //        Settings.Default.Save();
            //    }
            //}
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDB = new OpenFileDialog();
            fileDB.Title = "Seleccione una base de datos";
            fileDB.Filter = "Archivos access(*.accdb)|*.accdb";

            if (fileDB.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = fileDB.FileName.Replace("\\", "/");
            }

            this.txtFile.Size = new System.Drawing.Size(450, 18);
            txtFileName.Visible = btnChangeRoute.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog rte = new FolderBrowserDialog())
            {
                rte.SelectedPath = @"" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();

                if (rte.ShowDialog() == DialogResult.OK)
                {
                    route = txtFile.Text = rte.SelectedPath.Replace("\\", "/");

                    this.txtFile.Size = new System.Drawing.Size(362, 18);
                    txtFileName.Visible = btnChangeRoute.Visible = true;

                    if (txtFileName.Text.Equals(""))
                        txtFileName.Text = "Evaseac";
                    else
                        txtFileName_TextChanged(null, null);
                }
            }
        }

        private void txtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/' || e.KeyChar == '\\' || e.KeyChar == '.')
                e.Handled = true;
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            txtFile.Text = route + "/" + txtFileName.Text + ".accdb";
        }

        private void txtFileName_Leave(object sender, EventArgs e)
        {
            if (txtFileName.Text.Equals(""))
                txtFileName.Text = "Evaseac";
        }

    }
}
