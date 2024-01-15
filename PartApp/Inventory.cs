using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PartApp
{
    public class Inventory
    {
        public BindingList<Product> Products { get; private set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; private set; } = new BindingList<Part>();

        public Inventory(IEnumerable<Product> initialProducts, IEnumerable<Part> initialParts)
        {
            Products = new BindingList<Product>(initialProducts.ToList());
            AllParts = new BindingList<Part>(initialParts.ToList());
        }


        public Part LookupPart(int partId)
        {
            return AllParts.FirstOrDefault(part => part.PartId == partId);
        }

        public Product LookupProduct(int productId)
        {
            return Products.FirstOrDefault(product => product.ProductId == productId);
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public bool DeleteProduct(Product product)
        {
            return Products.Remove(product);
        }

        public void UpdatePart(int partId, Part updatedPart)
        {
            var existingPart = LookupPart(partId);
            if (existingPart != null)
            {
                
                int index = AllParts.IndexOf(existingPart);
                if (index != -1)
                {
                    AllParts[index] = updatedPart; 
                }
            }
        }



        public void UpdateProduct(Product updatedProduct)
        {
            var product = LookupProduct(updatedProduct.ProductId);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.InStock = updatedProduct.InStock;
                product.Price = updatedProduct.Price;
                product.Min = updatedProduct.Min;
                product.Max = updatedProduct.Max;

                var partsToRemove = product.AssociatedParts
                    .Where(p => !updatedProduct.AssociatedParts.Contains(p))
                    .ToList();
                foreach (var part in partsToRemove)
                {
                    product.RemoveAssociatedPart(part.PartId);
                }

                var partsToAdd = updatedProduct.AssociatedParts
                    .Where(p => !product.AssociatedParts.Contains(p))
                    .ToList();
                foreach (var part in partsToAdd)
                {
                    product.AddAssociatedPart(part);
                }
            }
        }

        public int GeneratePartId()
        {
            if (AllParts.Count == 0)
            {
                return 1;
            }
            return AllParts.Max(p => p.PartId) + 1;
        }

        public int GenerateProductId()
        {
            if (Products.Count == 0)
            {
                return 1; 
            }
            return Products.Max(p => p.ProductId) + 1;
        }
    }
}
