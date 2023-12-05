
using MiAPPCADEMIA23.View;
using MiAPPCADEMIA23.Controller;
using MiAPPCADEMIA23.Model;

namespace MiAPPCADEMIA23
{
    public partial class Login : Form
    {
        private List<Usuario> usuarios;
        public Login()
        {
            InitializeComponent();
            UsuarioController controller = new UsuarioController();
            usuarios = new List<Usuario>();
            usuarios = controller.GetUsuarios();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            this.Close();
        }
        //REGISTRO
        private void btn_Registrate_Click(object sender, EventArgs e)
        {
            Form form = new RegistrateVista();
            form.ShowDialog(this);
        }

        private bool validarEntrada(string id, string clave)
        {
            if (usuarios.Any(x => (x.getId().ToLower()).Equals(txtbId.Text) && (x.getClave().ToLower()).Equals(txtbKey.Text) ))
            {
                return true;
            }
            else
                return false;
        }
        //ACCESO    
        private void btn_EntraR_Click(object sender, EventArgs e)
        {
            bool entradaValidada = validarEntrada(txtbId.Text, txtbKey.Text);
            if (!entradaValidada)
            {
                MessageBox.Show("Error en ususario o contraseña");
            }
            else
            { 
                Form form = new InicioVista();
                form.ShowDialog(this);
            }
        }
    }
}
