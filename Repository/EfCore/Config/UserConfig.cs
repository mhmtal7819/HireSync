using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EfCore.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    UserId = 1,
                    Email = "john.doe@example.com",
                    Name = "John",
                    LastName = "Doe",
                    Birthday = new DateTime(1990, 5, 20),
                    Phone ="5553330278",
                    Address = "New York",
                    Gender = "Male",
                    JobId = 1,
                    Salary = 60000
                },
                new User
                {
                    UserId = 2,
                    Email = "jane.smith@example.com",
                    Name = "User",
                    LastName = "Smith",
                    Birthday = new DateTime(1992, 3, 15),
                    Phone = "5553330279",
                    Address = "Los Angeles",
                    Gender = "Female",
                    JobId = 2,
                    Salary = 55000
                }

                );
        }
    }
}
