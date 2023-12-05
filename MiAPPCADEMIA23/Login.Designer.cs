namespace MiAPPCADEMIA23
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_Cerrar = new Button();
            btn_Registrate = new Button();
            btn_EntraR = new Button();
            txtbKey = new TextBox();
            txtbId = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(btn_Registrate);
            panel1.Controls.Add(btn_EntraR);
            panel1.Controls.Add(txtbKey);
            panel1.Controls.Add(txtbId);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 689);
            panel1.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackgroundImage = Properties.Resources.close_fill;
            btn_Cerrar.FlatAppearance.BorderSize = 0;
            btn_Cerrar.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btn_Cerrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_Cerrar.FlatStyle = FlatStyle.Flat;
            btn_Cerrar.Location = new Point(392, 12);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(45, 45);
            btn_Cerrar.TabIndex = 4;
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Registrate
            // 
            btn_Registrate.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            btn_Registrate.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btn_Registrate.FlatStyle = FlatStyle.Flat;
            btn_Registrate.ForeColor = Color.White;
            btn_Registrate.Location = new Point(156, 554);
            btn_Registrate.Name = "btn_Registrate";
            btn_Registrate.Size = new Size(141, 32);
            btn_Registrate.TabIndex = 3;
            btn_Registrate.Text = "REGISTRARSE";
            btn_Registrate.UseVisualStyleBackColor = true;
            btn_Registrate.Click += btn_Registrate_Click;
            // 
            // btn_EntraR
            // 
            btn_EntraR.BackColor = Color.DarkSlateBlue;
            btn_EntraR.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btn_EntraR.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_EntraR.FlatStyle = FlatStyle.Flat;
            btn_EntraR.ForeColor = SystemColors.ButtonHighlight;
            btn_EntraR.Location = new Point(167, 317);
            btn_EntraR.Name = "btn_EntraR";
            btn_EntraR.Size = new Size(108, 32);
            btn_EntraR.TabIndex = 2;
            btn_EntraR.Text = "Entrar";
            btn_EntraR.UseVisualStyleBackColor = false;
            btn_EntraR.Click += btn_EntraR_Click;
            // 
            // txtbKey
            // 
            txtbKey.Location = new Point(139, 249);
            txtbKey.Name = "txtbKey";
            txtbKey.Size = new Size(173, 26);
            txtbKey.TabIndex = 1;
            // 
            // txtbId
            // 
            txtbId.Location = new Point(139, 192);
            txtbId.Name = "txtbId";
            txtbId.Size = new Size(173, 26);
            txtbId.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(458, 690);
            Controls.Add(panel1);
            Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiAPPCADEMIA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_EntraR;
        private TextBox txtbKey;
        private TextBox txtbId;
        private Button btn_Registrate;
        private Button btn_Cerrar;
    }
}
