namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "Address1", c => c.String());
            DropColumn("dbo.EmployeeModels", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeModels", "Address", c => c.String());
            DropColumn("dbo.EmployeeModels", "Address1");
        }
    }
}
