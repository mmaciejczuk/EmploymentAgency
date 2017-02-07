using FluentMigrator;
using System;

namespace EmploymentAgency.Migrations.Migrations._2017._02
{
    [Migration(20170207101609)]
    public class _02_InsertDataIntoTables : Migration
    {
        public override void Down()
        {
            Delete.FromTable("User");
            Delete.FromTable("Role");
        }

        public override void Up()
        {
            Insert.IntoTable("Role")
                                    .Row(new { Id = 1, Name = "Admin" })
                                    .Row(new { Id = 2, Name = "User" })
                                    .Row(new { Id = 3, Name = "Anonymous" });

            Insert.IntoTable("User").Row(new
                                    {
                                        Name = "John",
                                        Surname = "Smith",
                                        DateOfBirth = "1980-05-19",
                                        Email = "john.smith@hotmail.com",
                                        Street = "DowningStreet",
                                        Code = "15-671",
                                        City = "Warsaw",
                                        IsActive = 1,
                                        AddedDate = DateTime.UtcNow,
                                        Role_Id = 1
                                    })
                                     .Row(new
                                     {
                                         Name = "John",
                                         Surname = "Smith",
                                         DateOfBirth = "1980-05-19",
                                         Email = "john.smith@hotmail.com",
                                         Street = "DowningStreet",
                                         Code = "15-671",
                                         City = "Warsaw",
                                         IsActive = 1,
                                         AddedDate = DateTime.UtcNow,
                                         Role_Id = 2
                                     })
                                     .Row(new
                                     {
                                         Name = "John",
                                         Surname = "Smith",
                                         DateOfBirth = "1980-05-19",
                                         Email = "john.smith@hotmail.com",
                                         Street = "DowningStreet",
                                         Code = "15-671",
                                         City = "Warsaw",
                                         IsActive = 1,
                                         AddedDate = DateTime.UtcNow,
                                         Role_Id = 3
                                     });
        }
    }
}
