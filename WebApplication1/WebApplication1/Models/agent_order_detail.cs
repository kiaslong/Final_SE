//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class agent_order_detail
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int id_phone { get; set; }
        public int quantity { get; set; }
    
        public virtual agent_order agent_order { get; set; }
        public virtual phone phone { get; set; }
    }
}
