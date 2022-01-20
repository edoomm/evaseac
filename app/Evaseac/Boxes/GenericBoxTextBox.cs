using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaseac.Boxes
{
    public partial class Generic : Form
    {
        private Func<object, bool> _Validation;
        private Func<object, bool> _Action;
        private TaskCompletionSource<bool> taskCompletion = null;

        /// <summary>
        /// Creates a new Generic Box that can be used to display messages, capture data and perform actions
        /// </summary>
        /// <param name="message">The message to be displayed</param>
        /// <param name="title">The title of the window</param>
        /// <param name="accept">The text of the Accept button</param>
        /// <param name="cancel">The text of the Cancel button</param>
        /// <param name="isPassword">Indicates if the textbox should be a password text box</param>
        /// <param name="validationFunction">The function that performs the validation</param>
        /// <param name="actionFunction">The function that performs desired actions to be performed after validation completed</param>
        /// <param name="showTextbox">Indicates whether the TextBox should be hidden</param>
        /// <param name="showAccept">Indicates whether the Accept button should be hidden</param>
        /// <exception cref="OverflowException"></exception>
        public Generic(string message, string title = "", string accept = "Accept", string cancel = "Cancel", bool isPassword = false, Func<object, bool> validationFunction = null, Func<object, bool> actionFunction = null, bool showTextbox = true, bool showAccept = true)
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
            this._Validation = validationFunction;
            this._Action = actionFunction;
            this.TextBox.Visible = showTextbox;
            this.btnAccept.Visible = showAccept;

            ComponentsRelocation();
        }

        /// <summary>
        /// Property for the text contained in the main TextBox of the Box
        /// </summary>
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

        /// <summary>
        /// Shows the Generic Box in an asyncrhonous way
        /// </summary>
        /// <returns><code>true</code> when the box is closed</returns>
        public async Task<bool> ShowAsync()
        {
            taskCompletion = new TaskCompletionSource<bool>();
            base.Show();
            await taskCompletion.Task; // Dialog exited
            return true;
        }

        /// <summary>
        /// Relocates components according to constructor parameters
        /// </summary>
        private void ComponentsRelocation()
        {
            Size textboxSize = TextRenderer.MeasureText(this.lblMessage.Text, this.lblMessage.Font);
            int height = textboxSize.Height;
            int width = textboxSize.Width;

            int factor = (int)width / lblMessage.Width;
            this.Height += height * factor;

            if (!this.TextBox.Visible)
                this.Height -= height;
            if (!this.btnAccept.Visible)
                this.btnCancel.Location = new Point(this.btnCancel.Location.X - 60, this.btnCancel.Location.Y);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_Validation == null)
                this.Close();
            else if (this._Validation != null && !String.IsNullOrEmpty(TextBoxString))
                if (_Validation(this) && _Action != null)
                    _Action(this);
        }

        private void Generic_FormClosed(object sender, FormClosedEventArgs e)
        {
            taskCompletion?.TrySetResult(true);
        }
    }
}
