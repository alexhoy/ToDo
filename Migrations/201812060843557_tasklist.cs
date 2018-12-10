namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tasklist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Task_taskID", c => c.Int());
            CreateIndex("dbo.Tasks", "Task_taskID");
            AddForeignKey("dbo.Tasks", "Task_taskID", "dbo.Tasks", "taskID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Task_taskID", "dbo.Tasks");
            DropIndex("dbo.Tasks", new[] { "Task_taskID" });
            DropColumn("dbo.Tasks", "Task_taskID");
        }
    }
}
