//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactsManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactAddress
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public long AddressType { get; set; }
        public long ContactPersonID { get; set; }
    
        public virtual ContactPerson ContactPerson { get; set; }
    }
}
