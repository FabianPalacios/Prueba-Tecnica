
namespace GestionInventario._1._1_Vista
{
    partial class Transferir
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodigoBodegaOrigen = new System.Windows.Forms.TextBox();
            this.lblCodigoBodega = new System.Windows.Forms.Label();
            this.CodigoOrigen = new System.Windows.Forms.TextBox();
            this.lblCodigoOrigen = new System.Windows.Forms.Label();
            this.BodegaOrigen = new System.Windows.Forms.TextBox();
            this.ArticuloOrigen = new System.Windows.Forms.TextBox();
            this.lblArticuloOrigen = new System.Windows.Forms.Label();
            this.CantidadOrigen = new System.Windows.Forms.TextBox();
            this.lblCantidadOrigen = new System.Windows.Forms.Label();
            this.lblBodegaOrigen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CodigoDestino = new System.Windows.Forms.TextBox();
            this.lblCodigoDestino = new System.Windows.Forms.Label();
            this.ArticuloDestino = new System.Windows.Forms.TextBox();
            this.lblArticuloDestino = new System.Windows.Forms.Label();
            this.CantidadDestino = new System.Windows.Forms.TextBox();
            this.lblCantidadDestino = new System.Windows.Forms.Label();
            this.cmbBodegaDestino = new System.Windows.Forms.ComboBox();
            this.lblBodegaDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(684, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(397, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Transferencia de Artículos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodigoBodegaOrigen);
            this.groupBox1.Controls.Add(this.lblCodigoBodega);
            this.groupBox1.Controls.Add(this.CodigoOrigen);
            this.groupBox1.Controls.Add(this.lblCodigoOrigen);
            this.groupBox1.Controls.Add(this.BodegaOrigen);
            this.groupBox1.Controls.Add(this.ArticuloOrigen);
            this.groupBox1.Controls.Add(this.lblArticuloOrigen);
            this.groupBox1.Controls.Add(this.CantidadOrigen);
            this.groupBox1.Controls.Add(this.lblCantidadOrigen);
            this.groupBox1.Controls.Add(this.lblBodegaOrigen);
            this.groupBox1.Location = new System.Drawing.Point(91, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // CodigoBodegaOrigen
            // 
            this.CodigoBodegaOrigen.Enabled = false;
            this.CodigoBodegaOrigen.Location = new System.Drawing.Point(528, 172);
            this.CodigoBodegaOrigen.Name = "CodigoBodegaOrigen";
            this.CodigoBodegaOrigen.Size = new System.Drawing.Size(126, 26);
            this.CodigoBodegaOrigen.TabIndex = 10;
            // 
            // lblCodigoBodega
            // 
            this.lblCodigoBodega.AutoSize = true;
            this.lblCodigoBodega.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBodega.Location = new System.Drawing.Point(361, 171);
            this.lblCodigoBodega.Name = "lblCodigoBodega";
            this.lblCodigoBodega.Size = new System.Drawing.Size(161, 28);
            this.lblCodigoBodega.TabIndex = 9;
            this.lblCodigoBodega.Text = "Código Bodega :";
            this.lblCodigoBodega.Click += new System.EventHandler(this.lblCodigoBodega_Click);
            // 
            // CodigoOrigen
            // 
            this.CodigoOrigen.Enabled = false;
            this.CodigoOrigen.Location = new System.Drawing.Point(174, 34);
            this.CodigoOrigen.Name = "CodigoOrigen";
            this.CodigoOrigen.Size = new System.Drawing.Size(181, 26);
            this.CodigoOrigen.TabIndex = 8;
            // 
            // lblCodigoOrigen
            // 
            this.lblCodigoOrigen.AutoSize = true;
            this.lblCodigoOrigen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOrigen.Location = new System.Drawing.Point(81, 31);
            this.lblCodigoOrigen.Name = "lblCodigoOrigen";
            this.lblCodigoOrigen.Size = new System.Drawing.Size(87, 28);
            this.lblCodigoOrigen.TabIndex = 7;
            this.lblCodigoOrigen.Text = "Código :";
            this.lblCodigoOrigen.Click += new System.EventHandler(this.lblCodigoOrigen_Click);
            // 
            // BodegaOrigen
            // 
            this.BodegaOrigen.Enabled = false;
            this.BodegaOrigen.Location = new System.Drawing.Point(174, 173);
            this.BodegaOrigen.Name = "BodegaOrigen";
            this.BodegaOrigen.Size = new System.Drawing.Size(181, 26);
            this.BodegaOrigen.TabIndex = 6;
            // 
            // ArticuloOrigen
            // 
            this.ArticuloOrigen.Enabled = false;
            this.ArticuloOrigen.Location = new System.Drawing.Point(174, 109);
            this.ArticuloOrigen.Name = "ArticuloOrigen";
            this.ArticuloOrigen.Size = new System.Drawing.Size(181, 26);
            this.ArticuloOrigen.TabIndex = 5;
            // 
            // lblArticuloOrigen
            // 
            this.lblArticuloOrigen.AutoSize = true;
            this.lblArticuloOrigen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloOrigen.Location = new System.Drawing.Point(70, 105);
            this.lblArticuloOrigen.Name = "lblArticuloOrigen";
            this.lblArticuloOrigen.Size = new System.Drawing.Size(98, 28);
            this.lblArticuloOrigen.TabIndex = 4;
            this.lblArticuloOrigen.Text = "Artículo :";
            // 
            // CantidadOrigen
            // 
            this.CantidadOrigen.Enabled = false;
            this.CantidadOrigen.Location = new System.Drawing.Point(174, 231);
            this.CantidadOrigen.Name = "CantidadOrigen";
            this.CantidadOrigen.Size = new System.Drawing.Size(181, 26);
            this.CantidadOrigen.TabIndex = 3;
            // 
            // lblCantidadOrigen
            // 
            this.lblCantidadOrigen.AutoSize = true;
            this.lblCantidadOrigen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadOrigen.Location = new System.Drawing.Point(64, 231);
            this.lblCantidadOrigen.Name = "lblCantidadOrigen";
            this.lblCantidadOrigen.Size = new System.Drawing.Size(104, 28);
            this.lblCantidadOrigen.TabIndex = 2;
            this.lblCantidadOrigen.Text = "Cantidad :";
            // 
            // lblBodegaOrigen
            // 
            this.lblBodegaOrigen.AutoSize = true;
            this.lblBodegaOrigen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodegaOrigen.Location = new System.Drawing.Point(6, 173);
            this.lblBodegaOrigen.Name = "lblBodegaOrigen";
            this.lblBodegaOrigen.Size = new System.Drawing.Size(162, 28);
            this.lblBodegaOrigen.TabIndex = 0;
            this.lblBodegaOrigen.Text = "Bodega Origen :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodigoDestino);
            this.groupBox2.Controls.Add(this.lblCodigoDestino);
            this.groupBox2.Controls.Add(this.ArticuloDestino);
            this.groupBox2.Controls.Add(this.lblArticuloDestino);
            this.groupBox2.Controls.Add(this.CantidadDestino);
            this.groupBox2.Controls.Add(this.lblCantidadDestino);
            this.groupBox2.Controls.Add(this.cmbBodegaDestino);
            this.groupBox2.Controls.Add(this.lblBodegaDestino);
            this.groupBox2.Location = new System.Drawing.Point(1104, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 326);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // CodigoDestino
            // 
            this.CodigoDestino.Enabled = false;
            this.CodigoDestino.Location = new System.Drawing.Point(180, 37);
            this.CodigoDestino.Name = "CodigoDestino";
            this.CodigoDestino.Size = new System.Drawing.Size(223, 26);
            this.CodigoDestino.TabIndex = 7;
            // 
            // lblCodigoDestino
            // 
            this.lblCodigoDestino.AutoSize = true;
            this.lblCodigoDestino.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDestino.Location = new System.Drawing.Point(81, 37);
            this.lblCodigoDestino.Name = "lblCodigoDestino";
            this.lblCodigoDestino.Size = new System.Drawing.Size(87, 28);
            this.lblCodigoDestino.TabIndex = 6;
            this.lblCodigoDestino.Text = "Código :";
            // 
            // ArticuloDestino
            // 
            this.ArticuloDestino.Enabled = false;
            this.ArticuloDestino.Location = new System.Drawing.Point(180, 104);
            this.ArticuloDestino.Name = "ArticuloDestino";
            this.ArticuloDestino.Size = new System.Drawing.Size(223, 26);
            this.ArticuloDestino.TabIndex = 5;
            // 
            // lblArticuloDestino
            // 
            this.lblArticuloDestino.AutoSize = true;
            this.lblArticuloDestino.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloDestino.Location = new System.Drawing.Point(70, 101);
            this.lblArticuloDestino.Name = "lblArticuloDestino";
            this.lblArticuloDestino.Size = new System.Drawing.Size(98, 28);
            this.lblArticuloDestino.TabIndex = 4;
            this.lblArticuloDestino.Text = "Artículo :";
            // 
            // CantidadDestino
            // 
            this.CantidadDestino.Location = new System.Drawing.Point(180, 242);
            this.CantidadDestino.Name = "CantidadDestino";
            this.CantidadDestino.Size = new System.Drawing.Size(223, 26);
            this.CantidadDestino.TabIndex = 3;
            // 
            // lblCantidadDestino
            // 
            this.lblCantidadDestino.AutoSize = true;
            this.lblCantidadDestino.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDestino.Location = new System.Drawing.Point(70, 239);
            this.lblCantidadDestino.Name = "lblCantidadDestino";
            this.lblCantidadDestino.Size = new System.Drawing.Size(104, 28);
            this.lblCantidadDestino.TabIndex = 2;
            this.lblCantidadDestino.Text = "Cantidad :";
            // 
            // cmbBodegaDestino
            // 
            this.cmbBodegaDestino.FormattingEnabled = true;
            this.cmbBodegaDestino.Location = new System.Drawing.Point(180, 172);
            this.cmbBodegaDestino.Name = "cmbBodegaDestino";
            this.cmbBodegaDestino.Size = new System.Drawing.Size(223, 28);
            this.cmbBodegaDestino.TabIndex = 1;
            // 
            // lblBodegaDestino
            // 
            this.lblBodegaDestino.AutoSize = true;
            this.lblBodegaDestino.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodegaDestino.Location = new System.Drawing.Point(6, 172);
            this.lblBodegaDestino.Name = "lblBodegaDestino";
            this.lblBodegaDestino.Size = new System.Drawing.Size(168, 28);
            this.lblBodegaDestino.TabIndex = 0;
            this.lblBodegaDestino.Text = "Bodega Destino :";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(97, 47);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(77, 29);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(1110, 47);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(84, 29);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Destino";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(865, 422);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTransferir);
            this.groupBox4.Location = new System.Drawing.Point(841, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 93);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransferir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(6, 19);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(167, 56);
            this.btnTransferir.TabIndex = 0;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(906, 440);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(865, 422);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1779, 874);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Transferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.Load += new System.EventHandler(this.Transferir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBodegaOrigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBodegaDestino;
        private System.Windows.Forms.Label lblCantidadOrigen;
        private System.Windows.Forms.Label lblCantidadDestino;
        private System.Windows.Forms.ComboBox cmbBodegaDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox CantidadOrigen;
        private System.Windows.Forms.TextBox CantidadDestino;
        private System.Windows.Forms.TextBox ArticuloOrigen;
        private System.Windows.Forms.Label lblArticuloOrigen;
        private System.Windows.Forms.TextBox ArticuloDestino;
        private System.Windows.Forms.Label lblArticuloDestino;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox BodegaOrigen;
        private System.Windows.Forms.Label lblCodigoOrigen;
        private System.Windows.Forms.TextBox CodigoOrigen;
        private System.Windows.Forms.TextBox CodigoDestino;
        private System.Windows.Forms.Label lblCodigoDestino;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox CodigoBodegaOrigen;
        private System.Windows.Forms.Label lblCodigoBodega;
    }
}