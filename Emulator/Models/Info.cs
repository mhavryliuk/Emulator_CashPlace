//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emulator.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Info
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Sum { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
