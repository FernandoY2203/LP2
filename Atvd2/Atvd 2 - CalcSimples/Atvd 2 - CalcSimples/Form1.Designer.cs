namespace Atvd_2___CalcSimples
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
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum3 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Num1.Location = new System.Drawing.Point(97, 58);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(108, 26);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "Numero 1";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Num2.Location = new System.Drawing.Point(97, 111);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(114, 26);
            this.Num2.TabIndex = 1;
            this.Num2.Text = "Numero 2 ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(509, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(509, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button3.Location = new System.Drawing.Point(32, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button4.Location = new System.Drawing.Point(189, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(352, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "*";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button6.Location = new System.Drawing.Point(509, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "/";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Result.Location = new System.Drawing.Point(97, 195);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(110, 26);
            this.Result.TabIndex = 8;
            this.Result.Text = "Resultado";
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textNum1.Location = new System.Drawing.Point(302, 52);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(150, 32);
            this.textNum1.TabIndex = 0;
            this.textNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum1_KeyPress);
            // 
            // textNum3
            // 
            this.textNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textNum3.Location = new System.Drawing.Point(302, 189);
            this.textNum3.Name = "textNum3";
            this.textNum3.ReadOnly = true;
            this.textNum3.Size = new System.Drawing.Size(150, 32);
            this.textNum3.TabIndex = 2;
            this.textNum3.TextChanged += new System.EventHandler(this.textNum2_TextChanged);
            this.textNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum1_KeyPress);
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textNum2.Location = new System.Drawing.Point(302, 105);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(150, 32);
            this.textNum2.TabIndex = 1;
            this.textNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNum1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 373);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum3);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum3;
        private System.Windows.Forms.TextBox textNum2;
    }
}

