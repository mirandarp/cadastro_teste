using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_win_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void botao1_Click(object sender, EventArgs e)
        {
          

            
            if (idade.Text == "")
            {
                MessageBox.Show("Digite a idade");
            }
            else
            {
                int idade1 = Convert.ToInt32(idade.Text);

                if (idade1 >= 18)
                {
                    MessageBox.Show("Pode beber");
                  
                    idade.BackColor = Color.Green;
                }
                else
                {
                  
                    MessageBox.Show("Não pode beber");
                    idade.BackColor = Color.Red;
                }
            }

      

        }
    }
}
