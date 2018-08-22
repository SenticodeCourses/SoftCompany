using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuffs;

namespace SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuff
{
    public class Head : Employee
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override Speciality Speciality { get; set; }
        public override Task Task { get; set; }
        public override bool isBusy { get; set; }
    }
}
