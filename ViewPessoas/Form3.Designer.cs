namespace ViewPessoas
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSelecionados = new System.Windows.Forms.Button();
            this.buttonCarregar = new System.Windows.Forms.Button();
            this.gridControlPessoaSelecionada = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlPessoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoaSelecionada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonRemover);
            this.panel1.Controls.Add(this.buttonSelecionados);
            this.panel1.Controls.Add(this.buttonCarregar);
            this.panel1.Controls.Add(this.gridControlPessoaSelecionada);
            this.panel1.Controls.Add(this.gridControlPessoa);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 444);
            this.panel1.TabIndex = 0;
            // 
            // buttonSelecionados
            // 
            this.buttonSelecionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionados.Location = new System.Drawing.Point(486, 412);
            this.buttonSelecionados.Name = "buttonSelecionados";
            this.buttonSelecionados.Size = new System.Drawing.Size(75, 23);
            this.buttonSelecionados.TabIndex = 3;
            this.buttonSelecionados.Text = "Selecionados";
            this.buttonSelecionados.UseVisualStyleBackColor = true;
            this.buttonSelecionados.Click += new System.EventHandler(this.ButtonSelecionados_Click);
            // 
            // buttonCarregar
            // 
            this.buttonCarregar.Location = new System.Drawing.Point(152, 412);
            this.buttonCarregar.Name = "buttonCarregar";
            this.buttonCarregar.Size = new System.Drawing.Size(75, 23);
            this.buttonCarregar.TabIndex = 2;
            this.buttonCarregar.Text = "Carregar";
            this.buttonCarregar.UseVisualStyleBackColor = true;
            this.buttonCarregar.Click += new System.EventHandler(this.ButtonCarregar_Click);
            // 
            // gridControlPessoaSelecionada
            // 
            this.gridControlPessoaSelecionada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPessoaSelecionada.Location = new System.Drawing.Point(409, 3);
            this.gridControlPessoaSelecionada.MainView = this.gridView2;
            this.gridControlPessoaSelecionada.Name = "gridControlPessoaSelecionada";
            this.gridControlPessoaSelecionada.Size = new System.Drawing.Size(384, 403);
            this.gridControlPessoaSelecionada.TabIndex = 1;
            this.gridControlPessoaSelecionada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlPessoaSelecionada;
            this.gridView2.Name = "gridView2";
            // 
            // gridControlPessoa
            // 
            this.gridControlPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlPessoa.Location = new System.Drawing.Point(10, 3);
            this.gridControlPessoa.MainView = this.gridView1;
            this.gridControlPessoa.Name = "gridControlPessoa";
            this.gridControlPessoa.Size = new System.Drawing.Size(384, 403);
            this.gridControlPessoa.TabIndex = 0;
            this.gridControlPessoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlPessoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemover.Location = new System.Drawing.Point(637, 412);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.ButtonRemover_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoaSelecionada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlPessoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlPessoaSelecionada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button buttonSelecionados;
        private System.Windows.Forms.Button buttonCarregar;
        private System.Windows.Forms.Button buttonRemover;
    }
}