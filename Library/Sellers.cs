//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sellers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sellers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ID { get; set; }
        public string Seller_Name { get; set; }
        public string Seller_Surname { get; set; }
        public string Seller_Patronymic { get; set; }
        public string Seller_Email { get; set; }
        public string Seller_Password { get; set; }
        public bool Is_Admin { get; set; }
        public bool Is_Activated { get; set; }
        public bool Is_Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
