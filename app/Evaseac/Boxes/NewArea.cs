using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaseac.Boxes
{
    public partial class NewArea : Form
    {
        private bool isValid = false;

        public NewArea()
        {
            InitializeComponent();
            this.ActiveControl = txtArea;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid)
                return;

            if (txtArea.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre para el area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtArea.Focus();
                return;
            }
            if (DB.AlreadyExists("Nombre", "Area", txtArea.Text))
            {
                MessageBox.Show("El area '" + txtArea.Text + "' ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea añadir el area '" + txtArea.Text + "'", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
                DB.Insert("INSERT INTO Area (Nombre) VALUE ('" + txtArea.Text + "')");
                isValid = true;
                btnAdd.PerformClick();
            }
        }
    }
}
