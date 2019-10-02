namespace ViewPessoas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.dataGridViewSelecionados = new System.Windows.Forms.DataGridView();
            this.buttonGetPessoas = new System.Windows.Forms.Button();
            this.buttonSelcionado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonSelcionado);
            this.panel1.Controls.Add(this.buttonGetPessoas);
            this.panel1.Controls.Add(this.dataGridViewSelecionados);
            this.panel1.Controls.Add(this.dataGridViewPessoa);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewPessoa
            // 
            this.dataGridViewPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa.Location = new System.Drawing.Point(5, 0);
            this.dataGridViewPessoa.Name = "dataGridViewPessoa";
            this.dataGridViewPessoa.Size = new System.Drawing.Size(380, 408);
            this.dataGridViewPessoa.TabIndex = 0;
            
            // 
            // dataGridViewSelecionados
            // 
            this.dataGridViewSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelecionados.Location = new System.Drawing.Point(418, 0);
            this.dataGridViewSelecionados.Name = "dataGridViewSelecionados";
            this.dataGridViewSelecionados.Size = new System.Drawing.Size(380, 408);
            this.dataGridViewSelecionados.TabIndex = 1;
            // 
            // buttonGetPessoas
            // 
            this.buttonGetPessoas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGetPessoas.Location = new System.Drawing.Point(148, 416);
            this.buttonGetPessoas.Name = "buttonGetPessoas";
            this.buttonGetPessoas.Size = new System.Drawing.Size(75, 23);
            this.buttonGetPessoas.TabIndex = 2;
            this.buttonGetPessoas.Text = "Carregar";
            this.buttonGetPessoas.UseVisualStyleBackColor = true;
            this.buttonGetPessoas.Click += new System.EventHandler(this.ButtonGetPessoas_Click);
            // 
            // buttonSelcionado
            // 
            this.buttonSelcionado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSelcionado.Location = new System.Drawing.Point(597, 416);
            this.buttonSelcionado.Name = "buttonSelcionado";
            this.buttonSelcionado.Size = new System.Drawing.Size(81, 23);
            this.buttonSelcionado.TabIndex = 3;
            this.buttonSelcionado.Text = "Selecionados";
            this.buttonSelcionado.UseVisualStyleBackColor = true;
            this.buttonSelcionado.Click += new System.EventHandler(this.ButtonSelcionado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Visualizador de pessoas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelecionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSelecionados;
        private System.Windows.Forms.DataGridView dataGridViewPessoa;
        private System.Windows.Forms.Button buttonGetPessoas;
        private System.Windows.Forms.Button buttonSelcionado;
    }
}

