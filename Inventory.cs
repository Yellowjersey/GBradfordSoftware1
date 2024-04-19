using System.ComponentModel;

namespace InventoryManagement
{
    // Abstract class for Part
    public abstract class Part
    {
        // Properties common to all parts
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    // Class representing Inhouse parts
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
    }

    // Class representing Outsourced parts
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
    }

    // Class representing Product
    public class Product
    {
        // Properties for Product
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Associated parts list
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        // Method to add associated part
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        // Method to remove associated part
        public bool RemoveAssociatedPart(int partID)
        {
            Part partToRemove = null;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    partToRemove = part;
                    break;
                }
            }
            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            return false;
        }
    }

    // Class representing the Inventory
    public class Inventory
    {
        // Properties for Products and AllParts
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        // Method to add product
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Method to remove product
        public bool RemoveProduct(int productID)
        {
            Product productToRemove = null;
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    productToRemove = product;
                    break;
                }
            }
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            return false;
        }

        // Method to lookup product
        public Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        // Method to update product
        public void UpdateProduct(int productID, Product updatedProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = updatedProduct;
                    break;
                }
            }
        }

        // Method to add part
        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        // Method to delete part
        public bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        // Method to lookup part
        public Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        // Method to update part
        public void UpdatePart(int partID, Part updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    break;
                }
            }
        }
    }
}
