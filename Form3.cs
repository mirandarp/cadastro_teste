using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Curso_win_forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {

            //string nome = nomeBox.Text;
            //string idade = idadeBox.Text;
            //string telefone = telefoneBox.Text;
            //MessageBox.Show($"Nome: {nome} Idade: {idade} Telefone: {telefone} cadastrado com sucesso");


            //    nomeBox.Text = "";
            //    idadeBox.Text = "";
            //    telefoneBox.Text = "";


            string nome = nomeBox.Text;
            string idade = idadeBox.Text;
            string telefone = telefoneBox.Text;

            dynamic msg = "";

            if (Convert.ToInt32(idade) >= 18)
            {

                msg = "Cadastro realizado com sucesso";
                MessageBox.Show($"Nome: {nome} Idade: {idade} Telefone: {telefone} {msg}");
                nomeBox.Text = "";
                idadeBox.Text = "";
                telefoneBox.Text = "";

                listaDados.Items.Add($"Nome: {nome}" );
                listaDados.Items.Add($"Idade: {idade}");
                listaDados.Items.Add($"Telefone: {telefone}");







            }
            else
            {
                msg = "Menor de idade, o cadastro nao pode ser realizado";
                MessageBox.Show($"{msg}");
                nomeBox.Text = "";
                idadeBox.Text = "";
                telefoneBox.Text = "";
            }

            //colocar os dados aqui nesse campo listaDados
            //
        }


    }
}


