namespace Evaseac.Boxes
{
    partial class NewArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArea = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblArea.Location = new System.Drawing.Point(66, 64);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(37, 16);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Área";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(145, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtArea
            // 
            this.txtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArea.Font = new System.Drawing.Font("Yu Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(118, 61);
            this.txtArea.MaxLength = 40;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(200, 28);
            this.txtArea.TabIndex = 0;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewArea
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewArea";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar nueva área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtArea;
    }
}