﻿namespace AwsWindowsForm
{
    partial class AwsExampleMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shopNow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productImgUrl = new System.Windows.Forms.DataGridViewImageColumn();
            this.asin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopNow,
            this.productImgUrl,
            this.asin,
            this.productUrl,
            this.price,
            this.title,
            this.offersUrl,
            this.imgText});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv1.RowHeadersWidth = 20;
            this.dgv1.RowTemplate.Height = 100;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(779, 520);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(10, 544);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shopNow
            // 
            this.shopNow.DataPropertyName = "shopNow";
            this.shopNow.HeaderText = "";
            this.shopNow.Name = "shopNow";
            this.shopNow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shopNow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shopNow.Text = "";
            this.shopNow.Visible = false;
            // 
            // productImgUrl
            // 
            this.productImgUrl.HeaderText = "IMAGEN ";
            this.productImgUrl.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.productImgUrl.Name = "productImgUrl";
            // 
            // asin
            // 
            this.asin.DataPropertyName = "asin";
            this.asin.HeaderText = "IDPRODUCTO";
            this.asin.Name = "asin";
            // 
            // productUrl
            // 
            this.productUrl.DataPropertyName = "ProductUrl";
            this.productUrl.HeaderText = "ProductoUrl";
            this.productUrl.Name = "productUrl";
            this.productUrl.Visible = false;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "PRECIO";
            this.price.Name = "price";
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "REF.";
            this.title.Name = "title";
            // 
            // offersUrl
            // 
            this.offersUrl.DataPropertyName = "offersUrl";
            this.offersUrl.HeaderText = "Oferta";
            this.offersUrl.Name = "offersUrl";
            this.offersUrl.Visible = false;
            // 
            // imgText
            // 
            this.imgText.DataPropertyName = "productImgUrl";
            this.imgText.HeaderText = "ImagenUrl";
            this.imgText.Name = "imgText";
            this.imgText.Visible = false;
            // 
            // AwsExampleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dgv1);
            this.Name = "AwsExampleMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda en Amazon";
            this.Load += new System.EventHandler(this.AwsExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn shopNow;
        private System.Windows.Forms.DataGridViewImageColumn productImgUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn asin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn offersUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgText;
    }
}

