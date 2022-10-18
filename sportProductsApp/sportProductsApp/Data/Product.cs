//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sportProductsApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public int Id { get; set; }
        public int Id_unit { get; set; }
        public int Id_manufacturer { get; set; }
        public int Id_supplier { get; set; }
        public int Id_category { get; set; }
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }
        public byte ProductMaxDiscountAmount { get; set; }
        public Nullable<byte> ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductDescription { get; set; }
        public byte[] ProductPhoto { get; set; }
        public string ProductPhotoPath { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Manufacturers Manufacturers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Units Units { get; set; }
    }
}
