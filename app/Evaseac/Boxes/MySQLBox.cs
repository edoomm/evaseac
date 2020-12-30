using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaseac
{
    public partial class frmMySQLBox : Form
    {
        public frmMySQLBox()
        {
            InitializeComponent();
        }
        public string password
        {
            get { return txtPassword.Text; }
        }
    }
}
