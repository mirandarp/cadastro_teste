namespace Curso_win_forms
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.idadeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.telefoneBox = new System.Windows.Forms.MaskedTextBox();
            this.listaDados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(48, 48);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(266, 20);
            this.nomeBox.TabIndex = 1;
            // 
            // idadeBox
            // 
            this.idadeBox.Location = new System.Drawing.Point(48, 74);
            this.idadeBox.MaxLength = 2;
            this.idadeBox.Name = "idadeBox";
            this.idadeBox.Size = new System.Drawing.Size(28, 20);
            this.idadeBox.TabIndex = 2;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cadastro";
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoCadastrar.Location = new System.Drawing.Point(185, 85);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(113, 40);
            this.botaoCadastrar.TabIndex = 7;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // telefoneBox
            // 
            this.telefoneBox.Location = new System.Drawing.Point(63, 105);
            this.telefoneBox.Mask = "(00) 00000-0000";
            this.telefoneBox.Name = "telefoneBox";
            this.telefoneBox.Size = new System.Drawing.Size(87, 20);
            this.telefoneBox.TabIndex = 3;
            // 
            // listaDados
            // 
            this.listaDados.HideSelection = false;
            this.listaDados.LabelEdit = true;
            this.listaDados.Location = new System.Drawing.Point(17, 156);
            this.listaDados.Name = "listaDados";
            this.listaDados.Size = new System.Drawing.Size(297, 180);
            this.listaDados.TabIndex = 8;
            this.listaDados.UseCompatibleStateImageBehavior = false;
            this.listaDados.View = System.Windows.Forms.View.Tile;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(342, 377);
            this.Controls.Add(this.listaDados);
            this.Controls.Add(this.telefoneBox);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idadeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.TextBox idadeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.MaskedTextBox telefoneBox;
        private System.Windows.Forms.ListView listaDados;
    }
}