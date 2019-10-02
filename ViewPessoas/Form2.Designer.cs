namespace ViewPessoas
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
            this.gridControlPessoas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlPessoaSelecionada = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonPessoa = new System.Windows.Forms.Button();
            this.buttonSelecionados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoaSelecionada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPessoas
            // 
            this.gridControlPessoas.Location = new System.Drawing.Point(5, 5);
            this.gridControlPessoas.MainView = this.gridView1;
            this.gridControlPessoas.Name = "gridControlPessoas";
            this.gridControlPessoas.Size = new System.Drawing.Size(391, 396);
            this.gridControlPessoas.TabIndex = 0;
            this.gridControlPessoas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlPessoas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridControlPessoaSelecionada
            // 
            this.gridControlPessoaSelecionada.Location = new System.Drawing.Point(411, 5);
            this.gridControlPessoaSelecionada.MainView = this.gridView2;
            this.gridControlPessoaSelecionada.Name = "gridControlPessoaSelecionada";
            this.gridControlPessoaSelecionada.Size = new System.Drawing.Size(388, 396);
            this.gridControlPessoaSelecionada.TabIndex = 1;
            this.gridControlPessoaSelecionada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlPessoaSelecionada;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // buttonPessoa
            // 
            this.buttonPessoa.Location = new System.Drawing.Point(161, 416);
            this.buttonPessoa.Name = "buttonPessoa";
            this.buttonPessoa.Size = new System.Drawing.Size(75, 23);
            this.buttonPessoa.TabIndex = 2;
            this.buttonPessoa.Text = "Carregar";
            this.buttonPessoa.UseVisualStyleBackColor = true;
            this.buttonPessoa.Click += new System.EventHandler(this.ButtonPessoa_Click);
            // 
            // buttonSelecionados
            // 
            this.buttonSelecionados.Location = new System.Drawing.Point(570, 416);
            this.buttonSelecionados.Name = "buttonSelecionados";
            this.buttonSelecionados.Size = new System.Drawing.Size(82, 23);
            this.buttonSelecionados.TabIndex = 3;
            this.buttonSelecionados.Text = "Selecionados";
            this.buttonSelecionados.UseVisualStyleBackColor = true;
            this.buttonSelecionados.Click += new System.EventHandler(this.ButtonSelecionados_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 443);
            this.panel1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Visualizador de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPessoaSelecionada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlPessoas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlPessoaSelecionada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button buttonSelecionados;
        private System.Windows.Forms.Button buttonPessoa;
        private System.Windows.Forms.Panel panel1;
    }
}