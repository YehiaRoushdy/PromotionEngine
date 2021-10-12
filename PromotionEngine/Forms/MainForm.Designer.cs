
namespace PromotionEngine.Forms
{
    partial class MainForm
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
            this.Create_SKU = new System.Windows.Forms.Button();
            this.View_SKU_List = new System.Windows.Forms.Button();
            this.Add_New_Order = new System.Windows.Forms.Button();
            this.View_Previous_Orders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.View_Promotions_List = new System.Windows.Forms.Button();
            this.Create_Promotion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create_SKU
            // 
            this.Create_SKU.Location = new System.Drawing.Point(56, 78);
            this.Create_SKU.Name = "Create_SKU";
            this.Create_SKU.Size = new System.Drawing.Size(116, 38);
            this.Create_SKU.TabIndex = 0;
            this.Create_SKU.Text = "Add New SKU";
            this.Create_SKU.UseVisualStyleBackColor = true;
            this.Create_SKU.Click += new System.EventHandler(this.Create_SKU_Click);
            // 
            // View_SKU_List
            // 
            this.View_SKU_List.Location = new System.Drawing.Point(56, 21);
            this.View_SKU_List.Name = "View_SKU_List";
            this.View_SKU_List.Size = new System.Drawing.Size(116, 38);
            this.View_SKU_List.TabIndex = 1;
            this.View_SKU_List.Text = "View SKU List";
            this.View_SKU_List.UseVisualStyleBackColor = true;
            this.View_SKU_List.Click += new System.EventHandler(this.View_SKU_List_Click);
            // 
            // Add_New_Order
            // 
            this.Add_New_Order.Location = new System.Drawing.Point(37, 78);
            this.Add_New_Order.Name = "Add_New_Order";
            this.Add_New_Order.Size = new System.Drawing.Size(116, 38);
            this.Add_New_Order.TabIndex = 2;
            this.Add_New_Order.Text = "Add New Order";
            this.Add_New_Order.UseVisualStyleBackColor = true;
            this.Add_New_Order.Click += new System.EventHandler(this.Add_New_Order_Click);
            // 
            // View_Previous_Orders
            // 
            this.View_Previous_Orders.Location = new System.Drawing.Point(23, 21);
            this.View_Previous_Orders.Name = "View_Previous_Orders";
            this.View_Previous_Orders.Size = new System.Drawing.Size(171, 38);
            this.View_Previous_Orders.TabIndex = 3;
            this.View_Previous_Orders.Text = "View Previous Orders";
            this.View_Previous_Orders.UseVisualStyleBackColor = true;
            this.View_Previous_Orders.Click += new System.EventHandler(this.View_Previous_Orders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.View_SKU_List);
            this.groupBox1.Controls.Add(this.Create_SKU);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SKU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.View_Previous_Orders);
            this.groupBox2.Controls.Add(this.Add_New_Order);
            this.groupBox2.Location = new System.Drawing.Point(305, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.View_Promotions_List);
            this.groupBox3.Controls.Add(this.Create_Promotion);
            this.groupBox3.Location = new System.Drawing.Point(32, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promotions";
            // 
            // View_Promotions_List
            // 
            this.View_Promotions_List.Location = new System.Drawing.Point(40, 21);
            this.View_Promotions_List.Name = "View_Promotions_List";
            this.View_Promotions_List.Size = new System.Drawing.Size(146, 44);
            this.View_Promotions_List.TabIndex = 1;
            this.View_Promotions_List.Text = "View Promotions List";
            this.View_Promotions_List.UseVisualStyleBackColor = true;
            this.View_Promotions_List.Click += new System.EventHandler(this.View_Promotions_List_Click);
            // 
            // Create_Promotion
            // 
            this.Create_Promotion.Location = new System.Drawing.Point(40, 81);
            this.Create_Promotion.Name = "Create_Promotion";
            this.Create_Promotion.Size = new System.Drawing.Size(146, 38);
            this.Create_Promotion.TabIndex = 0;
            this.Create_Promotion.Text = "Add New Promotion";
            this.Create_Promotion.UseVisualStyleBackColor = true;
            this.Create_Promotion.Click += new System.EventHandler(this.Create_Promotion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 398);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_SKU;
        private System.Windows.Forms.Button View_SKU_List;
        private System.Windows.Forms.Button Add_New_Order;
        private System.Windows.Forms.Button View_Previous_Orders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button View_Promotions_List;
        private System.Windows.Forms.Button Create_Promotion;
    }
}

