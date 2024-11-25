namespace WinFormsPrincipio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonFCFS_Click(object sender, EventArgs e)//al apretar el boton de FCFS 
        {
            Form2 form2 = new Form2();//se inicializa el form2 
            this.Hide();//se esconde el form principal
            form2.Show();//se muestra el form que contiene el algoritmo de FCFS
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)//al apretar el boton de salir
        {
            this.Dispose();// se cierra el programa directamente 
        }
    }
}
