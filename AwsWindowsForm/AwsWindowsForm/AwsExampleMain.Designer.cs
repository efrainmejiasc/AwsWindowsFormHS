namespace AwsWindowsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.shopNow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productImgUrl = new System.Windows.Forms.DataGridViewImageColumn();
            this.asin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offersUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv1.RowHeadersWidth = 20;
            this.dgv1.RowTemplate.Height = 100;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(779, 446);
            this.dgv1.TabIndex = 7;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
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
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(9, 475);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto";
            // 
            // txtProduct
            // 
            this.txtProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduct.Location = new System.Drawing.Point(75, 472);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(188, 20);
            this.txtProduct.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.Silver;
            this.txtUrl.Location = new System.Drawing.Point(0, 446);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(779, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categoria";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Baby",
            "Beauty",
            "Books",
            "Electronics",
            "Fashion",
            "Industrial",
            "MP3Downloads",
            "Movies",
            "Music",
            "Toys",
            "VideoGames"});
            this.comboBox1.Location = new System.Drawing.Point(75, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // AwsExampleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 574);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProduct);
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
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn shopNow;
        private System.Windows.Forms.DataGridViewImageColumn productImgUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn asin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn offersUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgText;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

