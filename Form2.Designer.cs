namespace Curso_win_forms
{
    partial class Form2
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
            this.botao_incrementar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botao_incrementar
            // 
            this.botao_incrementar.Location = new System.Drawing.Point(247, 138);
            this.botao_incrementar.Name = "botao_incrementar";
            this.botao_incrementar.Size = new System.Drawing.Size(134, 76);
            this.botao_incrementar.TabIndex = 0;
            this.botao_incrementar.Text = "SOMAR +1";
            this.botao_incrementar.UseVisualStyleBackColor = true;
            this.botao_incrementar.Click += new System.EventHandler(this.botao_incrementar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao_incrementar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botao_incrementar;
    }
}