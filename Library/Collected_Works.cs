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
    
    public partial class Collected_Works
    {
        public int ID { get; set; }
        public Nullable<int> Book_ID { get; set; }
        public Nullable<int> Author_ID { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Books Books { get; set; }
    }
}
