namespace Evaseac
{
    partial class frmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangeRoute = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una base de datos";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(75, 87);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(350, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.TabStop = false;
            this.btnOpen.Text = "Abrir archivo acces existente";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(75, 128);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(350, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Crear nueva base de datos";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFile.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(25, 210);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(362, 18);
            this.txtFile.TabIndex = 4;
            this.txtFile.TabStop = false;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(120, 250);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 28);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(285, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnChangeRoute
            // 
            this.btnChangeRoute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeRoute.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeRoute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeRoute.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRoute.Location = new System.Drawing.Point(393, 208);
            this.btnChangeRoute.Name = "btnChangeRoute";
            this.btnChangeRoute.Size = new System.Drawing.Size(82, 23);
            this.btnChangeRoute.TabIndex = 5;
            this.btnChangeRoute.Text = "Cambiar ruta";
            this.btnChangeRoute.UseVisualStyleBackColor = false;
            this.btnChangeRoute.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(25, 186);
            this.txtFileName.MaxLength = 50;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(450, 18);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            this.txtFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileName_KeyPress);
            this.txtFileName.Leave += new System.EventHandler(this.txtFileName_Leave);
            // 
            // frmDatabase
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnChangeRoute);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDatabase";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeRoute;
        private System.Windows.Forms.TextBox txtFileName;
    }
}