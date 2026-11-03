using System.ComponentModel;

namespace EntitiesLayer
{
    public class Product
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Kod")]
        public string Code { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Satış Fiyatı")]
        public decimal SalePrice { get; set; }

        [DisplayName("Alış Fiyatı")]
        public decimal PurchasePrice { get; set; }

        [DisplayName("Stok")]
        public int Stock { get; set; }

        [Browsable(false)]
        public int UnitId { get; set; }

        [Browsable(false)]
        public int CategoryId { get; set; }

        [Browsable(false)]
        public int BrandId { get; set; }

        [Browsable(false)]
        public int SupplierId { get; set; }

        [DisplayName("Birim")]
        public string UnitName { get; set; }

        [DisplayName("Kategori")]
        public string CategoryName { get; set; }

        [DisplayName("Marka")]
        public string BrandName { get; set; }

        [DisplayName("Toptancı")]
        public string SupplierName { get; set; }
    }
}
