﻿namespace Atvd4___Triangulos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLado1 = new System.Windows.Forms.TextBox();
            this.textLado2 = new System.Windows.Forms.TextBox();
            this.textLado3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(369, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(369, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Location = new System.Drawing.Point(369, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(51, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado 3";
            // 
            // textLado1
            // 
            this.textLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textLado1.Location = new System.Drawing.Point(188, 25);
            this.textLado1.Name = "textLado1";
            this.textLado1.Size = new System.Drawing.Size(140, 32);
            this.textLado1.TabIndex = 0;
            // 
            // textLado2
            // 
            this.textLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textLado2.Location = new System.Drawing.Point(188, 68);
            this.textLado2.Name = "textLado2";
            this.textLado2.Size = new System.Drawing.Size(140, 32);
            this.textLado2.TabIndex = 1;
            // 
            // textLado3
            // 
            this.textLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textLado3.Location = new System.Drawing.Point(188, 120);
            this.textLado3.Name = "textLado3";
            this.textLado3.Size = new System.Drawing.Size(140, 32);
            this.textLado3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(40, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textResult.Location = new System.Drawing.Point(188, 211);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(311, 32);
            this.textResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 292);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLado3);
            this.Controls.Add(this.textLado2);
            this.Controls.Add(this.textLado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLado1;
        private System.Windows.Forms.TextBox textLado2;
        private System.Windows.Forms.TextBox textLado3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textResult;
    }
}
