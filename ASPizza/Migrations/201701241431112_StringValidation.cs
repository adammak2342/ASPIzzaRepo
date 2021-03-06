namespace ASPizza.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pizzas", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pizzas", "Name", c => c.String(maxLength: 20));
        }
    }
}
