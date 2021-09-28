namespace GiaiptBac1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_KhachHang_KhachHangID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        KhachHangID = c.String(nullable: false, maxLength: 128, unicode: false),
                        KhachHangName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHang");
        }
    }
}
