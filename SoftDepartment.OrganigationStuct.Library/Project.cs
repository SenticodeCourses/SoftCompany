using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDepartment.OrganigationStuct.Library
{
    public class Project
    {
        public List<Task> Tasks { get; set; }
        public int HardnessLevel { get; set; }
    }
}
