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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botao_incrementar_Click(object sender, EventArgs e)
        {
            
            int i = 10;
            while (i < 15)
            {
                MessageBox.Show("Incrementando");
                i++;
            }
            MessageBox.Show("Acabou");
        }
    }
}
