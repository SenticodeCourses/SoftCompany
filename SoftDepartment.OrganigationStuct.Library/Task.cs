﻿using SoftDepartment.OrganigationStuct.Library.CompanyResources;
using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDepartment.OrganigationStuct.Library
{
    public class Task
    {
        public string Name { get; set; }
        public List<Employee> employees { get; set; } = new List<Employee>();
    }
}