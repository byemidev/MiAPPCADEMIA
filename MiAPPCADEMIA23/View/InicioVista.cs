using System;
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
    public partial class InicioVista : Form
    {
        public InicioVista()
        {
            InitializeComponent();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            this.Close();
        }

        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            mostrarPanelesPrincipales(sender, e);
            UserControl categorias = new CategoriasUserControl();
            pnl1.Controls.Add(categorias);
            categorias.Show();
        }

        //Categorias
        //Cargar vista categorias


        private void cargarVistaCategorias()
        {

        }

        //Comun para todos lo elementos menu
        private void mostrarPanelesPrincipales(object sender, EventArgs e)
        {

            if (pnl1.Visible && pnl2.Visible)
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
            }
            else
            {
                pnl1.Visible = true;
                pnl2.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
