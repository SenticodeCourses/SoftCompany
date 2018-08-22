using SoftDepartment.OrganigationStuct.Library;
using SoftDepartment.OrganigationStuct.Library.CompanyResources;
using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuff;
using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuffs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftDepartment.OrganigationStuct.General
{
    class Program
    {
        static void Main(string[] args)
        {
            var softDepatrment = new SoftCompany()
            {
                Hardware = Enumerable.Range(0, 10)
                    .Select(i => new Hardware())
                    .ToList(),

                Soft = Enumerable.Range(0, 10)
                    .Select(i => new Software())
                    .ToList(),

                Staff = new List<Employee>
                {
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test},
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test},
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test},
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test}, new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test},
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test},
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test},
                    new Head {Id = 0110, Name = "Jerry Smit", Age = 35, Speciality = Speciality.Developer},
                    new Head {Id = 0111, Name = "Marg Larry", Age = 28, Speciality = Speciality.Test},
                    new Speciallist {Id = 0112, Name = "Lally Lois", Age = 31, Speciality = Speciality.Test},
                    new Speciallist {Id = 0113, Name = "Garry Bucker", Age = 25, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0114, Name = "Margaret Techer", Age = 41, Speciality = Speciality.Devops},
                    new Speciallist {Id = 0115, Name = "Ric Sunches", Age = 78, Speciality = Speciality.Developer},
                    new Speciallist {Id = 0116, Name = "Morty Sunches", Age = 21, Speciality = Speciality.Test}
                }
                //Staff = Enumerable.Range(0, 5)
                //.Select(i => (Employee)new Head() { Speciality = Speciality.Developer }).ToList() //Don't work!
            };

            //for (int i = 0; i < 1; i++)
            //{
            //    softDepatrment.Staff.Add(Enumerable.Range(0, 10).Select(s => new Head { Speciality = Speciality.Developer }).ToList());
            //    softDepatrment.Staff.Add(Enumerable.Range(0, 5).Select(s => new Head { Speciality = Speciality.Devops }) as Employee);
            //    softDepatrment.Staff.Add(Enumerable.Range(0, 5).Select(s => new Head { Speciality = Speciality.Test }) as Employee);
            //    softDepatrment.Staff.Add(Enumerable.Range(0, 10).Select(s => new Speciallist { Speciality = Speciality.Developer }) as Employee);
            //    softDepatrment.Staff.Add(Enumerable.Range(0, 5).Select(s => new Speciallist { Speciality = Speciality.Devops }) as Employee);
            //    softDepatrment.Staff.Add(Enumerable.Range(0, 10).Select(s => new Speciallist { Speciality = Speciality.Test }) as Employee);
            //}  //Don't work!

            var customer1 = new Customer()
            {
                Order = new List<Project>
                {
                    new Project
                    {
                        Tasks = new List<Library.Task>(),
                        HardnessLevel = 4
                    }
                }
            };

            softDepatrment.CreateTeam(customer1.Order[0]);

            Console.ReadLine();
        }
    }
}
