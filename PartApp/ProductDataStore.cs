using System;
using System.ComponentModel;
using System.Linq;


namespace PartApp
{
    public static class ProductDataStore
    {
        
        public static BindingList<Product> Products { get; private set; } = new BindingList<Product>();

        public static BindingList<Part> AllParts { get; private set; } = new BindingList<Part>();

        static ProductDataStore()
        {
         
            AllParts.Add(new Inhouse(0, "Wheel", 12.11m, 15, 5, 25, 42)); 
            AllParts.Add(new Inhouse(1, "Pedal", 8.22m, 11, 5, 25, 72));
            AllParts.Add(new Outsourced(2, "Chain", 8.33m, 12, 5, 25, "Chain Depot")); 
            AllParts.Add(new Inhouse(3, "Seat", 4.55m, 8, 2, 15, 15));

         
            Products.Add(new Product(0, "Red Bicycle", 114.99m, 15, 1, 25));
            Products.Add(new Product(1, "Yellow Bicycle", 96.99m, 19, 1, 20));
            Products.Add(new Product(2, "Blue Bicycle", 127.99m, 5, 1, 25));

            Products[0].AddAssociatedPart(AllParts[0]);
            Products[0].AddAssociatedPart(AllParts[2]);
        }

        public static Product GetProductById(int productId)
        {
            return Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static int GenerateProductId()
        {
            return Products.Any() ? Products.Max(p => p.ProductId) + 1 : 0;
        }
        public static bool DeleteProduct(int productId)
        {
            var product = GetProductById(productId);
            return product != null && Products.Remove(product);
        }

        public static Part GetPartById(int partId)
        {
            return AllParts.FirstOrDefault(p => p.PartId == partId);
        }

        public static void UpdateProduct(Product updatedProduct)
        {
            var product = Products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.InStock = updatedProduct.InStock;
                product.Price = updatedProduct.Price;
                product.Min = updatedProduct.Min;
                product.Max = updatedProduct.Max;

        
                var partsToRemove = product.AssociatedParts.Where(p => !updatedProduct.AssociatedParts.Contains(p)).ToList();
                foreach (var part in partsToRemove)
                {
                    product.RemoveAssociatedPart(part.PartId);
                }

                var partsToAdd = updatedProduct.AssociatedParts.Where(p => !product.AssociatedParts.Contains(p)).ToList();
                foreach (var part in partsToAdd)
                {
                    product.AddAssociatedPart(part);
                }
            }
        }

        public static int GeneratePartId()
        {
          
            if (AllParts.Count == 0)
            {
                return 0;
            }
           
            return AllParts.Max(p => p.PartId) + 1;
        }

        public static bool DeletePart(int partId)
        {
            var part = GetPartById(partId);
            return part != null && AllParts.Remove(part);
        }
        public static void UpdatePart(Part updatedPart)
        {
            var part = AllParts.FirstOrDefault(p => p.PartId == updatedPart.PartId);
            if (part != null)
            {
                part.Name = updatedPart.Name;
                part.InStock = updatedPart.InStock;
                part.Price = updatedPart.Price;
                part.Min = updatedPart.Min;
                part.Max = updatedPart.Max;

                if (part is Inhouse inhousePart && updatedPart is Inhouse updatedInhousePart)
                {
                    inhousePart.MachineId = updatedInhousePart.MachineId;
                }
                else if (part is Outsourced outsourcedPart && updatedPart is Outsourced updatedOutsourcedPart)
                {
                    outsourcedPart.CompanyName = updatedOutsourcedPart.CompanyName;
                }
            }
        }

    }
}
