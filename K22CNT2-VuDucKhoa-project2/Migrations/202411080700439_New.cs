namespace K22CNT2_VuDucKhoa_project2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_New", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_New", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
