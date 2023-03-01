using System.ComponentModel;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        private BindingList<string> messages = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();
            lbxMensajes.DataSource = messages;

        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Adiós {txtNombre.Text}");
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hola {txtNombre.Text}");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) )
            {
                MessageBox.Show("Please enter a message before to Add.", "Blank message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                messages.Add(txtNombre.Text);
                txtNombre.Text = string.Empty;
            }
            txtNombre.Focus();
        }
    }
}