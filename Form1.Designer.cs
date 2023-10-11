using System.Windows.Forms;

namespace Curso_win_forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao1 = new System.Windows.Forms.Button();
            this.idade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botao1.Location = new System.Drawing.Point(326, 76);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(104, 39);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Verificar";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(220, 102);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(100, 20);
            this.idade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qual sua idade?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button botao1;
        private TextBox idade;
        private Label label1;
    }
}

