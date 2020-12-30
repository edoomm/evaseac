using Evaseac.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Evaseac
{
    public partial class frmMain : Form
    {
        private bool btnParamClicked, btnMacroClicked, btnTstsClicked;
        public int stsChanged = 0;

        public frmMain()
        {
            new DB();

            InitializeComponent();          

            ucpSites.setMain(this);
        }

        //Methods

        private void UcpBringToFront(UserControl ucp)
        {
            ucpProjects.Enabled = false;
            ucpProjects.Visible = false;
            ucpSites.Enabled = false;
            ucpSites.Visible = false;
            ucpParameters.Enabled = false;
            ucpParameters.Visible = false;
            ucpWorkgroups.Enabled = false;
            ucpWorkgroups.Visible = false;

            ucp.Enabled = true;
            ucp.Visible = true;
            ucp.BringToFront();
        }

        public void btnParamEnabled(bool state)
        {
            btnParam.Enabled = state;
        }
        
        //Events

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (DB.Select("SELECT ID FROM Clase").Rows.Count == 0 && DB.Select("SELECT ID FROM Orden").Rows.Count == 0)
            {
                DialogResult conf = MessageBox.Show("No se han encontrado taxones en la base de datos\n¿Desea agregar los taxones por defecto?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conf == DialogResult.Yes)
                    DB.InsertDefaultTaxons();
            }

            ucpSites.idTemps = new List<string>();
            btnSites.PerformClick();

            ucpProjects.setUcpSites(ucpSites);
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btnProjects.BackColor = Color.Transparent;
            btnSites.BackColor = Color.Transparent;
            btnParam.BackColor = Color.Transparent;
            btnMacro.BackColor = Color.Transparent;
            btnTests.BackColor = Color.Transparent;
            btnWorkgroup.BackColor = Color.Transparent;

            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(203)))));
            btn.ForeColor = Color.White;

            stsChanged = ucpSites.idTemps.Count;

            if (btn == btnProjects)
            {
                UcpBringToFront(ucpProjects);
                ucpProjects.LoadProjects();
            }
            else if (btn == btnSites)
            {
                UcpBringToFront(ucpSites);

                if (ucpSites.idTemps.Count == 0)
                    ucpSites.LoadSites();
                else
                    ucpSites.edt = true;
            }
            else if (btn == btnParam)
            {
                UcpBringToFront(ucpParameters);

                if (!btnParamClicked)
                {
                    ucpParameters.LoadField();
                    btnParamClicked = true;
                }
            }
            else if (btn == btnMacro)
            {
                if (ucpMacroinvertebrados.idTemps.Count == 0)
                    ucpMacroinvertebrados.setTabPageIndex(1);
                else
                    ucpMacroinvertebrados.setTabPageIndex(0);

                UcpBringToFront(ucpMacroinvertebrados);

                if (!btnMacroClicked)
                {
                    ucpMacroinvertebrados.LoadThis();
                    btnMacroClicked = true;
                }
            }
            else if (btn == btnTests)
            {
                if (ucpTests.idTemps.Count == 0)
                    ucpTests.setTabIndex(1);
                else
                    ucpTests.setTabIndex(0);

                UcpBringToFront(ucpTests);

                if (!btnTstsClicked)
                {
                    ucpTests.LoadThis();
                    btnTstsClicked = true;
                }
            }
            else if (btn == btnWorkgroup)
            {
                UcpBringToFront(ucpWorkgroups);
                ucpWorkgroups.tabWorkgroup_SelectedIndexChanged(null, null);
            }
        }

        private void btnParam_EnabledChanged(object sender, EventArgs e) //Determintes if sites have changed 
        {
            if (btnParam.Enabled)
            {
                ucpTests.idTemps = ucpMacroinvertebrados.idTemps = ucpParameters.idTemps = ucpSites.idTemps;
                btnParamClicked = btnMacroClicked = btnTstsClicked = false;
            }
            else
            {
                ucpParameters.idTemps.Clear();
                ucpMacroinvertebrados.idTemps.Clear();
                ucpTests.idTemps.Clear();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (DB.getData("password", "Usuario", "WHERE usuario = 'admin'") != "")
            {
                using (frmPassword frm = new frmPassword())
                {
                    frm.ShowDialog();
                    if (frm.password == DB.getData("password", "Usuario", "WHERE usuario = 'admin'"))
                        new frmConfig().Show();
                }
            }
            else
                new frmConfig().Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            bool exist = false;
            for (int i = 0; i < ucpSites.idTemps.Count; i++)
                if (DB.Select("SELECT OD FROM Parametros WHERE IdTemporada = " + ucpSites.idTemps[i]).Rows.Count != 0
                   || DB.Select("SELECT Valor FROM ParametrosPSitios WHERE IdTemporada = " + ucpSites.idTemps[i]).Rows.Count != 0
                   || DB.Select("SELECT Numero FROM FamiliasSitios WHERE IdTemporada = " + ucpSites.idTemps[i]).Rows.Count != 0
                   || DB.Select("SELECT Numero FROM GenerosSitios WHERE IdTemporada = " + ucpSites.idTemps[i]).Rows.Count != 0)
                {
                    exist = true;
                    break;
                }
            
            if (ucpSites.idTemps.Count == 0)
                MessageBox.Show("Elija primero los sitios en el apartado de 'Sitios'", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!exist && ucpSites.idTemps.Count == 1)
                MessageBox.Show("El sitio elegido no tiene parametros, macroinvertebrados ni pruebas ingresadas\nIngrese los datos en los apartados: 'Parametros' o 'Macroinvertebrados' o 'Otras pruebas', para poder exportar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!exist && ucpSites.idTemps.Count > 1)
                MessageBox.Show("Los sitios elegidos no tienen parametros, macroinvertebrados ni pruebas ingresadas\nIngrese los datos en los apartados: 'Parametros' o 'Macroinvertebrados' o 'Otras pruebas', para poder exportar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (exist)
                using (frmExport frm = new frmExport())
                {
                    frm.idTemps = ucpSites.idTemps;
                    if (frm.ShowDialog() == DialogResult.OK)
                        MessageBox.Show("Operacion relizada correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }


        private void btnHover_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackColor != System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(203))))))
                btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
        }

        private void btnHover_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
        }

        //
    }
}
