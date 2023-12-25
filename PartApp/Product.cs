namespace PartApp
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    public class Product
    {
        private int _inStock;
        private int _min;
        private int _max;
        public BindingList<Part> AssociatedParts { get; private set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int InStock
        {
            get => _inStock;
            set
            {
                ValidateInventory(value, Min, Max);
                _inStock = value;
            }
        }

        public int Min
        {
            get => _min;
            set
            {
                if (value > Max)
                {
                    throw new InvalidOperationException("Min cannot be greater than Max.");
                }

                _min = value;
                // Automatically adjust InStock if it's now out of range.
                if (InStock < Min)
                {
                    InStock = Min;
                }
            }
        }

        public int Max
        {
            get => _max;
            set
            {
                if (value < Min)
                {
                    throw new InvalidOperationException("Max cannot be less than Min.");
                }

                _max = value;
                // Automatically adjust InStock if it's now out of range.
                if (InStock > Max)
                {
                    InStock = Max;
                }
            }
        }

        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            AssociatedParts = new BindingList<Part>();
            // Set Max before Min to avoid conflict with Min's setter validation
            Max = max;
            Min = min;
            InStock = inStock; // This will validate the inStock value
        }

        public void AddAssociatedPart(Part part)
        {
            if (part != null)
            {
                AssociatedParts.Add(part);
            }
        }

        public bool RemoveAssociatedPart(int partId)
        {
            var part = LookupAssociatedPart(partId);
            return part != null && AssociatedParts.Remove(part);
        }

        public Part LookupAssociatedPart(int partId)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartId == partId);
        }

        private void ValidateInventory(int inventory, int min, int max)
        {
            if (inventory < min || inventory > max)
            {
                throw new InvalidOperationException("Inventory must be between Min and Max.");
            }
        }
    }
}