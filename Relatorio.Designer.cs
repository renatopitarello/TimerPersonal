namespace TimerPersonal_v1
{
    partial class Relatorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encerramento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Uso e Tempo de Aplicações";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.fechar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 411);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.aplicacao,
            this.abertura,
            this.encerramento,
            this.tempo,
            this.janelas});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(781, 322);
            this.dataGridView1.TabIndex = 1;
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fechar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar.Location = new System.Drawing.Point(633, 36);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(152, 40);
            this.fechar.TabIndex = 2;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // aplicacao
            // 
            this.aplicacao.HeaderText = "Aplicação";
            this.aplicacao.Name = "aplicacao";
            this.aplicacao.ReadOnly = true;
            // 
            // abertura
            // 
            this.abertura.HeaderText = "Hora Abertura";
            this.abertura.Name = "abertura";
            this.abertura.ReadOnly = true;
            // 
            // encerramento
            // 
            this.encerramento.HeaderText = "Hora Encerramento";
            this.encerramento.Name = "encerramento";
            this.encerramento.ReadOnly = true;
            // 
            // tempo
            // 
            this.tempo.HeaderText = "Tempo Ativo";
            this.tempo.Name = "tempo";
            this.tempo.ReadOnly = true;
            // 
            // janelas
            // 
            this.janelas.HeaderText = "Janelas/Sites";
            this.janelas.Name = "janelas";
            this.janelas.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(4, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn encerramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn janelas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}