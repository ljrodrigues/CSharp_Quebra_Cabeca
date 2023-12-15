namespace QuebraCabeca
{
    partial class frmQuebraCabeca
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
            this.components = new System.ComponentModel.Container();
            this.btnEscolheImagem = new System.Windows.Forms.Button();
            this.ofAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmbaralhar = new System.Windows.Forms.Button();
            this.lblCliques = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.tTempo = new System.Windows.Forms.Timer(this.components);
            this.imgVenceu = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVenceu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEscolheImagem
            // 
            this.btnEscolheImagem.Location = new System.Drawing.Point(306, 50);
            this.btnEscolheImagem.Name = "btnEscolheImagem";
            this.btnEscolheImagem.Size = new System.Drawing.Size(147, 23);
            this.btnEscolheImagem.TabIndex = 8;
            this.btnEscolheImagem.Text = "Escolher Imagem...";
            this.btnEscolheImagem.UseVisualStyleBackColor = true;
            this.btnEscolheImagem.Click += new System.EventHandler(this.btnEscolheImagem_Click);
            // 
            // ofAbrirArquivo
            // 
            this.ofAbrirArquivo.FileName = "openFileDialog1";
            this.ofAbrirArquivo.Filter = "*.png|*.jpg";
            this.ofAbrirArquivo.Title = "Selecione uma imagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantidade de Cliques:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tempo Decorrido:";
            // 
            // btnEmbaralhar
            // 
            this.btnEmbaralhar.Location = new System.Drawing.Point(306, 79);
            this.btnEmbaralhar.Name = "btnEmbaralhar";
            this.btnEmbaralhar.Size = new System.Drawing.Size(147, 23);
            this.btnEmbaralhar.TabIndex = 12;
            this.btnEmbaralhar.Text = "Embaralhar / Iniciar";
            this.btnEmbaralhar.UseVisualStyleBackColor = true;
            this.btnEmbaralhar.Click += new System.EventHandler(this.btnEmbaralhar_Click);
            // 
            // lblCliques
            // 
            this.lblCliques.AutoSize = true;
            this.lblCliques.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliques.Location = new System.Drawing.Point(127, 13);
            this.lblCliques.Name = "lblCliques";
            this.lblCliques.Size = new System.Drawing.Size(25, 25);
            this.lblCliques.TabIndex = 13;
            this.lblCliques.Text = "0";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(338, 12);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(71, 25);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "00:00";
            // 
            // tTempo
            // 
            this.tTempo.Interval = 500;
            this.tTempo.Tick += new System.EventHandler(this.tTempo_Tick);
            // 
            // imgVenceu
            // 
            this.imgVenceu.Image = global::QuebraCabeca.Properties.Resources.trofeu;
            this.imgVenceu.Location = new System.Drawing.Point(304, 104);
            this.imgVenceu.Name = "imgVenceu";
            this.imgVenceu.Size = new System.Drawing.Size(151, 248);
            this.imgVenceu.TabIndex = 15;
            this.imgVenceu.TabStop = false;
            this.imgVenceu.Visible = false;
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn3.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn3.Location = new System.Drawing.Point(200, 50);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 9;
            this.btn3.Text = " ";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn8.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn8.Location = new System.Drawing.Point(100, 250);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 7;
            this.btn8.Text = " ";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn7.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn7.Location = new System.Drawing.Point(0, 250);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 6;
            this.btn7.Text = " ";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn6.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn6.Location = new System.Drawing.Point(200, 150);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 5;
            this.btn6.Text = " ";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn5.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn5.Location = new System.Drawing.Point(100, 150);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 4;
            this.btn5.Text = " ";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn4.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.Location = new System.Drawing.Point(0, 150);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 3;
            this.btn4.Text = " ";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn2.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2.Location = new System.Drawing.Point(100, 50);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 1;
            this.btn2.Text = " ";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn1.Image = global::QuebraCabeca.Properties.Resources.img_visual_studio;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn1.Location = new System.Drawing.Point(0, 50);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 0;
            this.btn1.Text = " ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frmQuebraCabeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 352);
            this.Controls.Add(this.imgVenceu);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblCliques);
            this.Controls.Add(this.btnEmbaralhar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnEscolheImagem);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuebraCabeca";
            this.Text = "Quebra Cabeça - Estudo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVenceu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnEscolheImagem;
        private System.Windows.Forms.OpenFileDialog ofAbrirArquivo;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmbaralhar;
        private System.Windows.Forms.Label lblCliques;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer tTempo;
        private System.Windows.Forms.PictureBox imgVenceu;
    }
}

