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
        private Func<string, bool> _AcceptClick;

        public Generic(string message, string title = "", string accept = "Accept", string cancel = "Cancel", bool isPassword = false, Func<string, bool> acceptClick = null)
        {
            if (message.Length > 897)
                throw new OverflowException("The message is too long");

            InitializeComponent();
            this.lblMessage.Text = message;
            this.Text = title;
            this.btnAccept.Text = accept;
            this.btnCancel.Text = cancel;
            if (isPassword)
                this.TextBox.PasswordChar = '●';
            this._AcceptClick = acceptClick;

            ComponentsRelocation();
        }

        //public Generic(string message, string title) : this(message)
        //{
        //    this.Text = title;
        //}

        public string TextBoxString { get; set; }

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
            //if (e.KeyData == Keys.Enter)
            //    btnAccept.PerformClick();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            TextBoxString = TextBox.Text;

            if (_AcceptClick == null)
                this.Close();
            else if (this._AcceptClick != null && !String.IsNullOrEmpty(TextBoxString))
                _AcceptClick(TextBoxString);
        }
    }
}
