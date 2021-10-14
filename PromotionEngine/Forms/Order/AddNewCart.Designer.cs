
namespace PromotionEngine.Forms.Order
{
    partial class AddNewCart
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.skuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionEngineDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionEngineDBDataSet = new PromotionEngine.PromotionEngineDBDataSet();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionDetailTableAdapter = new PromotionEngine.PromotionEngineDBDataSetTableAdapters.PromotionDetailTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cartItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartItemTableAdapter = new PromotionEngine.PromotionEngineDBDataSetTableAdapters.CartItemTableAdapter();
            this.skuTableAdapter = new PromotionEngine.PromotionEngineDBDataSetTableAdapters.SkuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(605, 308);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // SKU
            // 
            this.SKU.DataSource = this.skuBindingSource;
            this.SKU.DisplayMember = "Sku";
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.Width = 125;
            // 
            // skuBindingSource
            // 
            this.skuBindingSource.DataMember = "Sku";
            this.skuBindingSource.DataSource = this.promotionEngineDBDataSetBindingSource;
            // 
            // promotionEngineDBDataSetBindingSource
            // 
            this.promotionEngineDBDataSetBindingSource.DataSource = this.promotionEngineDBDataSet;
            this.promotionEngineDBDataSetBindingSource.Position = 0;
            // 
            // promotionEngineDBDataSet
            // 
            this.promotionEngineDBDataSet.DataSetName = "PromotionEngineDBDataSet";
            this.promotionEngineDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartItemBindingSource
            // 
            this.cartItemBindingSource.DataMember = "CartItem";
            this.cartItemBindingSource.DataSource = this.promotionEngineDBDataSetBindingSource;
            // 
            // promotionDetailBindingSource
            // 
            this.promotionDetailBindingSource.DataMember = "PromotionDetail";
            this.promotionDetailBindingSource.DataSource = this.promotionEngineDBDataSet;
            // 
            // promotionDetailTableAdapter
            // 
            this.promotionDetailTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cartItemBindingSource1
            // 
            this.cartItemBindingSource1.DataMember = "CartItem";
            this.cartItemBindingSource1.DataSource = this.promotionEngineDBDataSetBindingSource;
            // 
            // cartItemTableAdapter
            // 
            this.cartItemTableAdapter.ClearBeforeFill = true;
            // 
            // skuTableAdapter
            // 
            this.skuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(415, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 6;
            // 
            // AddNewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "AddNewCart";
            this.Text = "New Cart";
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private PromotionEngineDBDataSet promotionEngineDBDataSet;
        private System.Windows.Forms.BindingSource promotionDetailBindingSource;
        private PromotionEngineDBDataSetTableAdapters.PromotionDetailTableAdapter promotionDetailTableAdapter;
        private System.Windows.Forms.BindingSource promotionEngineDBDataSetBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource cartItemBindingSource1;
        private System.Windows.Forms.BindingSource cartItemBindingSource;
        private PromotionEngineDBDataSetTableAdapters.CartItemTableAdapter cartItemTableAdapter;
        private System.Windows.Forms.BindingSource skuBindingSource;
        private PromotionEngineDBDataSetTableAdapters.SkuTableAdapter skuTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
    }
}