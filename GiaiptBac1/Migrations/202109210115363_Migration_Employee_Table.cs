namespace GiaiptBac1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Employee_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128, unicode: false),
                        EmployeeName = c.String(),
                        EmployeeBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            AddColumn("dbo.Student", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Address");
            DropTable("dbo.Employees");
        }
    }
}
