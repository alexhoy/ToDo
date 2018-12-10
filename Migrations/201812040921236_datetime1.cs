namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "taskCreationTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "taskCreationTime", c => c.DateTime());
        }
    }
}
