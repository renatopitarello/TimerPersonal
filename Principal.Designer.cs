namespace TimerPersonal_v1
{
    partial class Principal
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
            this.pausar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.configuracao = new System.Windows.Forms.Button();
            this.relatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pausar
            // 
            this.pausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pausar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pausar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausar.Location = new System.Drawing.Point(35, 108);
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(152, 40);
            this.pausar.TabIndex = 0;
            this.pausar.Text = "Pausar";
            this.pausar.UseVisualStyleBackColor = false;
            this.pausar.Click += new System.EventHandler(this.pausar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sair);
            this.panel1.Controls.Add(this.configuracao);
            this.panel1.Controls.Add(this.relatorio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pausar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 298);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "00:00:00";
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sair.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(35, 246);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(152, 40);
            this.sair.TabIndex = 4;
            this.sair.Text = "Ocultar";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // configuracao
            // 
            this.configuracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.configuracao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.configuracao.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracao.Location = new System.Drawing.Point(35, 200);
            this.configuracao.Name = "configuracao";
            this.configuracao.Size = new System.Drawing.Size(152, 40);
            this.configuracao.TabIndex = 3;
            this.configuracao.Text = "Configurações";
            this.configuracao.UseVisualStyleBackColor = false;
            this.configuracao.Click += new System.EventHandler(this.configuracao_Click);
            // 
            // relatorio
            // 
            this.relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.relatorio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.relatorio.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio.Location = new System.Drawing.Point(35, 154);
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(152, 40);
            this.relatorio.TabIndex = 2;
            this.relatorio.Text = "Relatório de uso";
            this.relatorio.UseVisualStyleBackColor = false;
            this.relatorio.Click += new System.EventHandler(this.relatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(223, 301);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pausar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button configuracao;
        private System.Windows.Forms.Button relatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

