//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_dApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public string BookName { get; set; }
        public string BookISBN { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public System.DateTime Year_published { get; set; }
        public bool Reserve_ { get; set; }
    
        public virtual Borrowedhistory Borrowedhistory { get; set; }
    }
}
