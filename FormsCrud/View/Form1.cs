using FormsCrud.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCrud
{
    public partial class Form1 : Form
    {
        private int IdGeral = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIdade_KeyUp(object sender, KeyEventArgs e)
        {
            int valor;
            bool validaInt = int.TryParse(txtIdade.Text, out valor);
            if (!validaInt)
            {
                if(txtIdade.Text.Length != 0)
                    txtIdade.Text = txtIdade.Text.Substring(0, txtIdade.Text.Length-1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                new ClienteController().InserirCliente(txtNome.Text,Convert.ToInt32(txtIdade.Text),
                               txtEmail.Text,txtEndereco.Text);
                MessageBox.Show("Cliente Inserido com Sucesso!!");
                LimparCampos();
                CarregaClientes();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios nessa tela");
            }
        }
        private bool ValidaCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtIdade.Text)
               || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtEndereco.Text))
            {
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaClientes();
        }
        private void CarregaClientes()
        {
            dtClientes.DataSource = new ClienteController().RetornaClientes();
            dtClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LimparCampos()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is GroupBox)
                {
                    for (int j = 0; j < this.Controls[i].Controls.Count; j++)
                    {
                        if (this.Controls[i].Controls[j] is TextBox)
                        {
                            this.Controls[i].Controls[j].Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void dtClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja Remover esse Cliente", "Excluir!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.IdGeral = Convert.ToInt32(dtClientes.Rows[e.RowIndex].Cells[0].Value);
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            new ClienteController().RemoverCliente(IdGeral);
            MessageBox.Show("Cliente Removido com sucesso");
            IdGeral = 0;
            btnRemove.Enabled = false;
            CarregaClientes();
        }
    }
}
