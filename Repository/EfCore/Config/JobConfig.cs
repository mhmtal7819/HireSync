using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EfCore.Config
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(
                new Job
                {
                    JobId = 1,
                    JobName = "Software Developer",
                    DepartmentId = 1 // Buraya uygun bir Department da olmalı
                },
                new Job
                {
                    JobId = 2,
                    JobName = "HR Specialist",
                    DepartmentId = 1
                   }
                );
        }
    }
}
