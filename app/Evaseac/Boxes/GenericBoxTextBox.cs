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
    public partial class Generic : Form
    {
        public Generic(String message)
        {
            if (message.Length > 897)
                throw new OverflowException("The message is too long");

            InitializeComponent();
            this.lblMessage.Text = message;

            ComponentsRelocation();
        }

        private void ComponentsRelocation()
        {
            Size textboxSize = TextRenderer.MeasureText(this.lblMessage.Text, this.lblMessage.Font);
            int height = textboxSize.Height;
            int width = textboxSize.Width;

            int factor = (int)width / lblMessage.Width;
            this.Height += height * factor;
        }

        private void TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnAccept.PerformClick();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
