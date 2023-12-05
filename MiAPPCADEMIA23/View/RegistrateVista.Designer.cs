namespace MiAPPCADEMIA23.View
{
    partial class RegistrateVista
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btn_Crear = new Button();
            lbl_id = new Label();
            lbl_NewPass = new Label();
            lbl_RepiteCLave = new Label();
            btn_Cerrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(231, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(231, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(231, 301);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 2;
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = SystemColors.ControlLightLight;
            btn_Crear.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btn_Crear.FlatAppearance.MouseOverBackColor = Color.Lime;
            btn_Crear.FlatStyle = FlatStyle.Flat;
            btn_Crear.Location = new Point(261, 386);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(75, 23);
            btn_Crear.TabIndex = 3;
            btn_Crear.Text = "CREAR";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Visible = false;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            lbl_id.Location = new Point(30, 185);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(29, 19);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "ID";
            // 
            // lbl_NewPass
            // 
            lbl_NewPass.AutoSize = true;
            lbl_NewPass.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            lbl_NewPass.Location = new Point(30, 248);
            lbl_NewPass.Name = "lbl_NewPass";
            lbl_NewPass.Size = new Size(59, 19);
            lbl_NewPass.TabIndex = 5;
            lbl_NewPass.Text = "Clave";
            // 
            // lbl_RepiteCLave
            // 
            lbl_RepiteCLave.AutoSize = true;
            lbl_RepiteCLave.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold);
            lbl_RepiteCLave.Location = new Point(30, 305);
            lbl_RepiteCLave.Name = "lbl_RepiteCLave";
            lbl_RepiteCLave.Size = new Size(159, 19);
            lbl_RepiteCLave.TabIndex = 6;
            lbl_RepiteCLave.Text = "Repite tu clave";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackgroundImage = Properties.Resources.close_fill;
            btn_Cerrar.FlatAppearance.BorderSize = 0;
            btn_Cerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btn_Cerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btn_Cerrar.FlatStyle = FlatStyle.Flat;
            btn_Cerrar.Location = new Point(350, 25);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(45, 45);
            btn_Cerrar.TabIndex = 7;
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(30, 108);
            label1.Name = "label1";
            label1.Size = new Size(386, 25);
            label1.TabIndex = 8;
            label1.Text = "AVISO:  Proximamente disponible al 100%";
            // 
            // RegistrateVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(433, 627);
            Controls.Add(label1);
            Controls.Add(btn_Cerrar);
            Controls.Add(lbl_RepiteCLave);
            Controls.Add(lbl_NewPass);
            Controls.Add(lbl_id);
            Controls.Add(btn_Crear);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrateVista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn_Crear;
        private Label lbl_id;
        private Label lbl_NewPass;
        private Label lbl_RepiteCLave;
        private Button btn_Cerrar;
        private Label label1;
    }
}