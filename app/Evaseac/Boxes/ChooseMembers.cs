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
    public partial class frmChooseMembers : Form
    {
        public frmChooseMembers()
        {
            InitializeComponent();
            ids = new HashSet<int>();
            fill(this.dgvMembers);
            this.dgvMembers.ClearSelection();
        }

        /// <summary>
        /// Fills a DataGriedView with data from the DB Table 'Miembro'
        /// </summary>
        /// <param name="dataGridView">A DataGriedView that must contain 3 columns</param>
        private void fill(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            // retrieving data from DB
            DataTable dtMembers = DB.Select("SELECT ID, Etiqueta FROM Miembro ORDER BY ID DESC");
            // setting data
            foreach (DataRow row in dtMembers.Rows)
                dataGridView.Rows.Add(false, row[0], row[1]);
        }

        public HashSet<int> ids { get; set; }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // checks whether the cell is checked or unchecked
            if (dgvMembers.CurrentCell.Value.ToString() == "False") // checked
            {
                dgvMembers.CurrentCell.Value = true;
                // adds to ids
                ids.Add(int.Parse(dgvMembers.CurrentRow.Cells[1].Value.ToString()));
            }
            else // unchecked
            {
                dgvMembers.CurrentCell.Value = false;
                // removes from ids
                ids.Remove(int.Parse(dgvMembers.CurrentRow.Cells[1].Value.ToString()));
            }
        }
    }
}
