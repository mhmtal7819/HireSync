using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Job
    {
        public int JobId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public string JobName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
