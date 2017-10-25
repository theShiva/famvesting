namespace SingleFamProperties.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Create_Properties_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 500),
                        YearBuilt = c.Int(nullable: false),
                        ListPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
        }
    }
}
