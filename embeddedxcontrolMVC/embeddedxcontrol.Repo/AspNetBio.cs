//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace embeddedxcontrol.Repo
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetBio
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Biography { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoName { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}