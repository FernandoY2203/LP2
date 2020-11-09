namespace Atvd6___Menu_e_Metodos
{
    partial class frmExercicio2
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
            this.textPalavra1 = new System.Windows.Forms.TextBox();
            this.textPalavra2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPalavra1
            // 
            this.textPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textPalavra1.Location = new System.Drawing.Point(183, 85);
            this.textPalavra1.Name = "textPalavra1";
            this.textPalavra1.Size = new System.Drawing.Size(214, 26);
            this.textPalavra1.TabIndex = 0;
            // 
            // textPalavra2
            // 
            this.textPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textPalavra2.Location = new System.Drawing.Point(183, 139);
            this.textPalavra2.Name = "textPalavra2";
            this.textPalavra2.Size = new System.Drawing.Size(214, 26);
            this.textPalavra2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 115);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verificar se Sao Iguais";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 115);
            this.button2.TabIndex = 3;
            this.button2.Text = "Inserir a Primeira Palavra no Meio da Segunda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 115);
            this.button3.TabIndex = 4;
            this.button3.Text = "Inserir 2 Asteriscos na Primeira Palavra e Colocar o Resultado no Bloco da Segund" +
    "a Palavra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(55, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Primeira Palavra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(47, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segunda Palavra";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 115);
            this.button4.TabIndex = 7;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(112, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Escreva duas Palavras";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPalavra2);
            this.Controls.Add(this.textPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio 2 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPalavra1;
        private System.Windows.Forms.TextBox textPalavra2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}