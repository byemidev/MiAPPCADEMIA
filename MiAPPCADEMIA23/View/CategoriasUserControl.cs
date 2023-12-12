using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiAPPCADEMIA23.Controller;
using MiAPPCADEMIA23.Model;

namespace MiAPPCADEMIA23.View
{
    public partial class CategoriasUserControl : UserControl
    {
        public CategoriasUserControl()
        {
            CategoriaController controller = new CategoriaController();
            InitializeComponent();

            int top = 10; // Posición inicial desde la parte superior de la ventana

            foreach (Categoria valor in controller.getCategorias())
            {
                Label label = new Label();
                label.Text = valor.ToString();
                label.Font = Font = new Font("Impact", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
                label.AutoSize = true;
                label.Margin = new Padding(15); // Margen de 15px
                label.Padding = new Padding(5); // Padding de 5px
                label.Top = top;
                this.Controls.Add(label); // Añade el label al formulario

                top += label.Height + 30; // Actualiza la posición para el siguiente label, añadiendo 30px de espacio
            }
        }
    }
}
