//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzurreWebAppDB2
{
    using System;
    using System.Collections.Generic;

    public partial class customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Nullable<int> phone { get; set; }

        public virtual order order { get; set; }
    }
}
