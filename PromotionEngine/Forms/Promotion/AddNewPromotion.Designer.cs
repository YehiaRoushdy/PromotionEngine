
namespace PromotionEngine.Forms.Promotion
{
    partial class AddNewPromotion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.skuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.promotionEngineDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionEngineDBDataSet = new PromotionEngine.PromotionEngineDBDataSet();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionDetailTableAdapter = new PromotionEngine.PromotionEngineDBDataSetTableAdapters.PromotionDetailTableAdapter();
            this.skuTableAdapter = new PromotionEngine.PromotionEngineDBDataSetTableAdapters.SkuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(24, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(605, 308);
            this.dataGridView1.TabIndex = 3;
            // 
            // SKU
            // 
            this.SKU.DataSource = this.skuBindingSource1;
            this.SKU.DisplayMember = "Sku";
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.Width = 125;
            // 
            // skuBindingSource1
            // 
            this.skuBindingSource1.DataMember = "Sku";
            this.skuBindingSource1.DataSource = this.promotionEngineDBDataSetBindingSource;
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
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
            // skuTableAdapter
            // 
            this.skuTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddNewPromotion";
            this.Text = "New Promotion";
            this.Load += new System.EventHandler(this.AddNewPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionEngineDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PromotionEngineDBDataSet promotionEngineDBDataSet;
        private System.Windows.Forms.BindingSource promotionDetailBindingSource;
        private PromotionEngineDBDataSetTableAdapters.PromotionDetailTableAdapter promotionDetailTableAdapter;
        private System.Windows.Forms.BindingSource promotionEngineDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource skuBindingSource;
        private System.Windows.Forms.BindingSource skuBindingSource1;
        private PromotionEngineDBDataSetTableAdapters.SkuTableAdapter skuTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}