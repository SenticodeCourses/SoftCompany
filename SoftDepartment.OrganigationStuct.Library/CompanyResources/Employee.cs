using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuff;
using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuffs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDepartment.OrganigationStuct.Library.CompanyResources
{
    public abstract class Employee 
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract Speciality Speciality { get; set; }
        public abstract Task Task { get; set; }
        public abstract bool isBusy { get; set; }

       
    }
}
