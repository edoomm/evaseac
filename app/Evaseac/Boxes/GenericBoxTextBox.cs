using System;
using System.Drawing;
using System.Windows.Forms;

namespace Evaseac.Boxes
{
    public partial class Generic : Form
    {
        private Func<object, bool> _AcceptClick;

        public Generic(string message, string title = "", string accept = "Accept", string cancel = "Cancel", bool isPassword = false, Func<object, bool> acceptClick = null)
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

        public string TextBoxString
        {
            get
            {
                return TextBox.Text;
            }
            set
            {
                TextBox.Text = value;
            }
        }

        private void ComponentsRelocation()
        {
            Size textboxSize = TextRenderer.MeasureText(this.lblMessage.Text, this.lblMessage.Font);
            int height = textboxSize.Height;
            int width = textboxSize.Width;

            int factor = (int)width / lblMessage.Width;
            this.Height += height * factor;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_AcceptClick == null)
                this.Close();
            else if (this._AcceptClick != null && !String.IsNullOrEmpty(TextBoxString))
                if (_AcceptClick(this))
                    InsertAdminPassword();
        }


        #region Insert admin password

        private void InsertAdminPassword()
        {
            if (DB.Insert("INSERT INTO Usuario (usuario, password) VALUE ('admin', '" + TextBoxString + "')"))
                MessageBox.Show("Contraseña establecida correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
