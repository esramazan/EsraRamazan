//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Esramazan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ESRAMAZANEntities : DbContext
    {
        public ESRAMAZANEntities()
            : base("name=ESRAMAZANEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactInf> ContactInf { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
    }
}
