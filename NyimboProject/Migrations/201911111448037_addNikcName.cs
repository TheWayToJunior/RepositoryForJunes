namespace NyimboProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNikcName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NickName");
        }
    }
}
