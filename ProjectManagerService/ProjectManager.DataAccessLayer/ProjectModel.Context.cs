﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectManagerEntities : DbContext
    {
        public ProjectManagerEntities()
            : base("name=ProjectManagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ParentTasks> ParentTasks1 { get; set; }
        public virtual DbSet<Projects> Projects1 { get; set; }
        public virtual DbSet<Tasks> Tasks1 { get; set; }
        public virtual DbSet<Users> Users1 { get; set; }
        public object Projects { get; set; }
        public object Users { get; set; }
        public object ParentTasks { get; set; }
        public object Tasks { get; set; }
    }
}