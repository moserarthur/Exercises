using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (ValidaLogin(txtUsuario.Text, txtSenha.Text))
            {
                CarregaResultado();
                MessageBox.Show("Seja bem vindo !!");
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }
        private bool ValidaLogin(string usuario, string senha)
        {
            if (usuario.Trim() != "admin" || senha.Trim() != "admin")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CarregaResultado()
        {
            lblResultado.Text = "Usuário Autorizado";
            lblResultado.Visible = true;
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {

            EnterEvent(sender, e);
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            EnterEvent(sender,e);
        }
        private void EnterEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirma_Click(sender, e);
            }
        }
    }
}
