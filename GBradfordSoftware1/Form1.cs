using System;
using System.ComponentModel;
using System.Windows.Forms;
using GBradfordSoftware1;

namespace GBradfordSoftware1
{
    public partial class Form1 : Form
    {
        private BindingList<Part> partsBindingList;
        private BindingList<Product> productsBindingList;
        private Inventory inventory;

        // Constructor accepting an Inventory instance
        public Form1(Inventory inventory)
        {
            InitializeComponent();

            // Set the class-level inventory field to the passed inventory instance
            this.inventory = inventory;
            partsBindingList = new BindingList<Part>(inventory.AllParts);
            productsBindingList = new BindingList<Product>(inventory.Products);

            // Bind DataGridViews to BindingLists
            PartsDataGridView.DataSource = partsBindingList;
            ProductsDataGridView.DataSource = productsBindingList;


        }



     



        // Event handler for search parts button
        private void SearchParts_Click(object sender, EventArgs e)
        {
            // Implement search functionality if needed
        }

        // Event handler for search products button
        private void SearchProducts_Click(object sender, EventArgs e)
        {
            // Implement search functionality if needed
        }

        // Event handler for modify parts button
        private void ModifyParts_Click(object sender, EventArgs e)
        {
            // Implement modify parts functionality
        }

        // Event handler for modify products button
        private void ModifyProducts_Click(object sender, EventArgs e)
        {
            // Implement modify products functionality
        }

        // Event handler for delete parts button
        private void DeleteParts_Click(object sender, EventArgs e)
        {
            // Implement delete parts functionality
        }

        // Event handler for delete products button
        private void DeleteProducts_Click(object sender, EventArgs e)
        {
            // Implement delete products functionality
        }
    }
}
