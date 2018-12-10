namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        taskID = c.Int(nullable: false, identity: true),
                        taskTitle = c.String(),
                        taskBody = c.String(),
                        taskOwner = c.String(),
                        taskPriority = c.Boolean(nullable: false),
                        taskComplete = c.Boolean(nullable: false),
                        taskCreationTime = c.DateTime(nullable: false),
                        taskCompletionTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.taskID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
