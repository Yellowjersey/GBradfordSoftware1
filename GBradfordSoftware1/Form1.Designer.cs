namespace GBradfordSoftware1
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            InventoryManagementSystemLabel = new Label();
            SearchPartsInput = new TextBox();
            SearchProductsInput = new TextBox();
            SearchParts = new Button();
            SearchProducts = new Button();
            PartsLabel = new Label();
            ProductsLabel = new Label();
            AddParts = new Button();
            ModifyParts = new Button();
            DeleteParts = new Button();
            DeleteProducts = new Button();
            ModifyProducts = new Button();
            AddProducts = new Button();
            PartsDataGridView = new DataGridView();
            ProductsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InventoryManagementSystemLabel
            // 
            InventoryManagementSystemLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InventoryManagementSystemLabel.AutoSize = true;
            InventoryManagementSystemLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            InventoryManagementSystemLabel.Location = new Point(12, 9);
            InventoryManagementSystemLabel.Name = "InventoryManagementSystemLabel";
            InventoryManagementSystemLabel.Size = new Size(291, 25);
            InventoryManagementSystemLabel.TabIndex = 0;
            InventoryManagementSystemLabel.Text = "Inventory Management System";
            // 
            // SearchPartsInput
            // 
            SearchPartsInput.Location = new Point(390, 111);
            SearchPartsInput.Name = "SearchPartsInput";
            SearchPartsInput.Size = new Size(145, 23);
            SearchPartsInput.TabIndex = 3;
            // 
            // SearchProductsInput
            // 
            SearchProductsInput.Location = new Point(970, 111);
            SearchProductsInput.Name = "SearchProductsInput";
            SearchProductsInput.Size = new Size(145, 23);
            SearchProductsInput.TabIndex = 4;
            // 
            // SearchParts
            // 
            SearchParts.Location = new Point(309, 111);
            SearchParts.Name = "SearchParts";
            SearchParts.Size = new Size(75, 23);
            SearchParts.TabIndex = 5;
            SearchParts.Text = "Search";
            SearchParts.UseVisualStyleBackColor = true;
            SearchParts.Click += SearchParts_Click;
            // 
            // SearchProducts
            // 
            SearchProducts.Location = new Point(889, 111);
            SearchProducts.Name = "SearchProducts";
            SearchProducts.Size = new Size(75, 23);
            SearchProducts.TabIndex = 6;
            SearchProducts.Text = "Search";
            SearchProducts.UseVisualStyleBackColor = true;
            SearchProducts.Click += SearchProducts_Click;
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Segoe UI", 14F);
            PartsLabel.Location = new Point(12, 111);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(53, 25);
            PartsLabel.TabIndex = 7;
            PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 14F);
            ProductsLabel.Location = new Point(586, 112);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(86, 25);
            ProductsLabel.TabIndex = 8;
            ProductsLabel.Text = "Products";
            // 
            // AddParts
            // 
            AddParts.Location = new Point(322, 420);
            AddParts.Name = "AddParts";
            AddParts.Size = new Size(67, 36);
            AddParts.TabIndex = 9;
            AddParts.Text = "Add";
            AddParts.UseVisualStyleBackColor = true;
            // 
            // ModifyParts
            // 
            ModifyParts.Location = new Point(395, 420);
            ModifyParts.Name = "ModifyParts";
            ModifyParts.Size = new Size(67, 36);
            ModifyParts.TabIndex = 10;
            ModifyParts.Text = "Modify";
            ModifyParts.UseVisualStyleBackColor = true;
            ModifyParts.Click += ModifyParts_Click;
            // 
            // DeleteParts
            // 
            DeleteParts.Location = new Point(468, 420);
            DeleteParts.Name = "DeleteParts";
            DeleteParts.Size = new Size(67, 36);
            DeleteParts.TabIndex = 11;
            DeleteParts.Text = "Delete";
            DeleteParts.UseVisualStyleBackColor = true;
            // 
            // DeleteProducts
            // 
            DeleteProducts.Location = new Point(1048, 420);
            DeleteProducts.Name = "DeleteProducts";
            DeleteProducts.Size = new Size(67, 36);
            DeleteProducts.TabIndex = 14;
            DeleteProducts.Text = "Delete";
            DeleteProducts.UseVisualStyleBackColor = true;
            // 
            // ModifyProducts
            // 
            ModifyProducts.Location = new Point(975, 420);
            ModifyProducts.Name = "ModifyProducts";
            ModifyProducts.Size = new Size(67, 36);
            ModifyProducts.TabIndex = 13;
            ModifyProducts.Text = "Modify";
            ModifyProducts.UseVisualStyleBackColor = true;
            // 
            // AddProducts
            // 
            AddProducts.Location = new Point(902, 420);
            AddProducts.Name = "AddProducts";
            AddProducts.Size = new Size(67, 36);
            AddProducts.TabIndex = 12;
            AddProducts.Text = "Add";
            AddProducts.UseVisualStyleBackColor = true;
            // 
            // PartsDataGridView
            // 
            PartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGridView.Location = new Point(12, 157);
            PartsDataGridView.MaximumSize = new Size(523, 257);
            PartsDataGridView.Name = "PartsDataGridView";
            PartsDataGridView.ScrollBars = ScrollBars.Vertical;
            PartsDataGridView.Size = new Size(523, 257);
            PartsDataGridView.TabIndex = 15;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(586, 157);
            ProductsDataGridView.MaximumSize = new Size(523, 257);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ScrollBars = ScrollBars.Vertical;
            ProductsDataGridView.Size = new Size(523, 257);
            ProductsDataGridView.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 496);
            Controls.Add(ProductsDataGridView);
            Controls.Add(PartsDataGridView);
            Controls.Add(DeleteProducts);
            Controls.Add(ModifyProducts);
            Controls.Add(AddProducts);
            Controls.Add(DeleteParts);
            Controls.Add(ModifyParts);
            Controls.Add(AddParts);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(SearchProducts);
            Controls.Add(SearchParts);
            Controls.Add(SearchProductsInput);
            Controls.Add(SearchPartsInput);
            Controls.Add(InventoryManagementSystemLabel);
            Name = "Form1";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)PartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InventoryManagementSystemLabel;
        private TextBox SearchPartsInput;
        private TextBox SearchProductsInput;
        private Button SearchParts;
        private Button SearchProducts;
        private Label PartsLabel;
        private Label ProductsLabel;
        private Button AddParts;
        private Button ModifyParts;
        private Button DeleteParts;
        private Button DeleteProducts;
        private Button ModifyProducts;
        private Button AddProducts;
        private DataGridView ProductsDataGridView;
        private DataGridView PartsDataGridView;
    }
}
