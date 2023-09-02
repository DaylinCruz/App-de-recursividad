using System.Drawing.Text;

namespace App_de_recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected int contador = 0;


        private void btnSeleccionarDirectorio_Click(object sender, EventArgs e)
        {
            string RutaDirectorio = String.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                RutaDirectorio = fbd.SelectedPath;
            }

            DirectoryInfo di = new DirectoryInfo(RutaDirectorio);

            foreach(var item in di.GetFiles())
            {
                Archivos.Items.Add(item.Name);
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            contador++;
            string RutaDirectorio = String.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                RutaDirectorio = fbd.SelectedPath;
            }

            DirectoryInfo di = new DirectoryInfo(RutaDirectorio);

            foreach (var item in di.GetFiles())
            {
                Archivos.Items.Add(item.Name);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}