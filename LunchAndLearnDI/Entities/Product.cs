using System.ComponentModel.DataAnnotations.Schema;

namespace LunchAndLearnDI.Entities
{
    public class Product
    {
        #region Properties
        [NotMapped]
        public int _id { get; set; }
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }
        #endregion
    }


}
