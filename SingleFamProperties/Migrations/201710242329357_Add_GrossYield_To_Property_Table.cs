namespace SingleFamProperties.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_GrossYield_To_Property_Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "GrossYield", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "GrossYield");
        }
    }
}
