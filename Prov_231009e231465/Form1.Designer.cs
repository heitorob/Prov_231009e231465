namespace Prov_231009e231465
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
            this.btninserir = new System.Windows.Forms.Button();
            this.btnalterarqtde = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.txtalterar = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvendas = new System.Windows.Forms.Label();
            this.lblvalort = new System.Windows.Forms.Label();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            this.colproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvalorunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(555, 180);
            this.btninserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(148, 58);
            this.btninserir.TabIndex = 0;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnalterarqtde
            // 
            this.btnalterarqtde.Font = new System.Drawing.Font("Courier New", 11F);
            this.btnalterarqtde.Location = new System.Drawing.Point(823, 807);
            this.btnalterarqtde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnalterarqtde.Name = "btnalterarqtde";
            this.btnalterarqtde.Size = new System.Drawing.Size(148, 55);
            this.btnalterarqtde.TabIndex = 0;
            this.btnalterarqtde.Text = "Alterar Quantidade";
            this.btnalterarqtde.UseVisualStyleBackColor = true;
            this.btnalterarqtde.Click += new System.EventHandler(this.btnalterarqtde_Click);
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Location = new System.Drawing.Point(123, 897);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(180, 81);
            this.btngravar.TabIndex = 0;
            this.btngravar.Text = "Gravar Venda";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(733, 897);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(180, 81);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.Text = "Finalizar Sistema";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(440, 897);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(180, 81);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancelar Venda";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnremover
            // 
            this.btnremover.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(823, 182);
            this.btnremover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(148, 55);
            this.btnremover.TabIndex = 0;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txtalterar
            // 
            this.txtalterar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalterar.Location = new System.Drawing.Point(316, 767);
            this.txtalterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(653, 22);
            this.txtalterar.TabIndex = 1;
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(263, 210);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(239, 22);
            this.txtvalor.TabIndex = 1;
            // 
            // txtqtde
            // 
            this.txtqtde.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtde.Location = new System.Drawing.Point(263, 139);
            this.txtqtde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(239, 22);
            this.txtqtde.TabIndex = 1;
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(263, 75);
            this.txtprod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(707, 22);
            this.txtprod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 767);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alterar Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 841);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total da Venda: R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor Unitário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Produto:";
            // 
            // lblvendas
            // 
            this.lblvendas.AutoSize = true;
            this.lblvendas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvendas.Location = new System.Drawing.Point(164, 23);
            this.lblvendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvendas.Name = "lblvendas";
            this.lblvendas.Size = new System.Drawing.Size(18, 18);
            this.lblvendas.TabIndex = 2;
            this.lblvendas.Text = "1";
            // 
            // lblvalort
            // 
            this.lblvalort.AutoSize = true;
            this.lblvalort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalort.Location = new System.Drawing.Point(213, 841);
            this.lblvalort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalort.Name = "lblvalort";
            this.lblvalort.Size = new System.Drawing.Size(18, 18);
            this.lblvalort.TabIndex = 2;
            this.lblvalort.Text = "0";
            // 
            // dgvvendas
            // 
            this.dgvvendas.AllowUserToAddRows = false;
            this.dgvvendas.AllowUserToDeleteRows = false;
            this.dgvvendas.AllowUserToOrderColumns = true;
            this.dgvvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colproduto,
            this.colqtde,
            this.colvalorunit});
            this.dgvvendas.Location = new System.Drawing.Point(48, 345);
            this.dgvvendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.ReadOnly = true;
            this.dgvvendas.Size = new System.Drawing.Size(955, 341);
            this.dgvvendas.TabIndex = 3;
            this.dgvvendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendas_CellDoubleClick);
            // 
            // colproduto
            // 
            this.colproduto.HeaderText = "Produto";
            this.colproduto.Name = "colproduto";
            this.colproduto.ReadOnly = true;
            // 
            // colqtde
            // 
            this.colqtde.HeaderText = "Quantidade";
            this.colqtde.Name = "colqtde";
            this.colqtde.ReadOnly = true;
            // 
            // colvalorunit
            // 
            this.colvalorunit.HeaderText = "V.Unitário";
            this.colvalorunit.Name = "colvalorunit";
            this.colvalorunit.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 1012);
            this.ControlBox = false;
            this.Controls.Add(this.dgvvendas);
            this.Controls.Add(this.lblvalort);
            this.Controls.Add(this.lblvendas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnalterarqtde);
            this.Controls.Add(this.btninserir);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercados Casa do Sabão";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnalterarqtde;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox txtalterar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvendas;
        private System.Windows.Forms.Label lblvalort;
        private System.Windows.Forms.DataGridView dgvvendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvalorunit;
    }
}

