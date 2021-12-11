namespace Student.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SubmissionForm = c.String(),
                        Money = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentModels");
        }
    }
}
