namespace ViewPessoas
{
    partial class RandonNumberView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditNumber01 = new DevExpress.XtraEditors.TextEdit();
            this.textEditNumber2 = new DevExpress.XtraEditors.TextEdit();
            this.textEditResponse = new DevExpress.XtraEditors.TextEdit();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumber01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumber2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResponse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resposta:";
            // 
            // textEditNumber01
            // 
            this.textEditNumber01.Location = new System.Drawing.Point(150, 11);
            this.textEditNumber01.Name = "textEditNumber01";
            this.textEditNumber01.Properties.ReadOnly = true;
            this.textEditNumber01.Size = new System.Drawing.Size(134, 20);
            this.textEditNumber01.TabIndex = 3;
            // 
            // textEditNumber2
            // 
            this.textEditNumber2.Location = new System.Drawing.Point(150, 56);
            this.textEditNumber2.Name = "textEditNumber2";
            this.textEditNumber2.Properties.ReadOnly = true;
            this.textEditNumber2.Size = new System.Drawing.Size(134, 20);
            this.textEditNumber2.TabIndex = 4;
            // 
            // textEditResponse
            // 
            this.textEditResponse.Location = new System.Drawing.Point(150, 102);
            this.textEditResponse.Name = "textEditResponse";
            this.textEditResponse.Properties.ReadOnly = true;
            this.textEditResponse.Size = new System.Drawing.Size(134, 20);
            this.textEditResponse.TabIndex = 5;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma.Location = new System.Drawing.Point(66, 140);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(48, 29);
            this.buttonSoma.TabIndex = 6;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.ButtonSoma_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtracao.Location = new System.Drawing.Point(120, 140);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(48, 29);
            this.buttonSubtracao.TabIndex = 7;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            this.buttonSubtracao.Click += new System.EventHandler(this.ButtonSubtracao_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicacao.Location = new System.Drawing.Point(184, 140);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(48, 29);
            this.buttonMultiplicacao.TabIndex = 8;
            this.buttonMultiplicacao.Text = "*";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.ButtonMultiplicacao_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivisao.Location = new System.Drawing.Point(236, 140);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(48, 29);
            this.buttonDivisao.TabIndex = 9;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.ButtonDivisao_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(7, 194);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(157, 415);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(75, 23);
            this.buttonPdf.TabIndex = 11;
            this.buttonPdf.Text = "Gerar Pdf";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.ButtonPdf_Click);
            // 
            // RandonNumberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.textEditResponse);
            this.Controls.Add(this.textEditNumber2);
            this.Controls.Add(this.textEditNumber01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RandonNumberView";
            this.Text = "Calculo com números randômicos";
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumber01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumber2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResponse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditNumber01;
        private DevExpress.XtraEditors.TextEdit textEditNumber2;
        private DevExpress.XtraEditors.TextEdit textEditResponse;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonDivisao;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button buttonPdf;
    }
}