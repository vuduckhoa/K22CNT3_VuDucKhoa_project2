namespace K22CNT2_VuDucKhoa_project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Categor", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_Categor", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Categor", "SeoDescriptio", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Categor", "SeoKeyWords", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Categor", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_Categor", "SeoDescriptio", c => c.String());
            AlterColumn("dbo.tb_Categor", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Categor", "Title", c => c.String());
        }
    }
}
