using SoftDepartment.OrganigationStuct.Library.CompanyResources;
using SoftDepartment.OrganigationStuct.Library.CompanyResources.Stuffs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftDepartment.OrganigationStuct.Library
{
    public class SoftCompany
    {
        private int _countEmpl;
        private bool _projectIsAssembled;
        public List<Employee> Staff;
        public List<Software> Soft;
        public List<Hardware> Hardware;
        private static Random _rnd = new Random(Environment.TickCount);

        public Dictionary<Speciality, int> _taskTeam;

        public void CreateTeam(Project project)
        {
            project.Tasks = Enumerable.Range(1, project.HardnessLevel)
                .Select(i => new Task())
                .ToList();

            foreach (var pt in project.Tasks)
            {
                _countEmpl = 0;
                _taskTeam = new Dictionary<Speciality, int>()
                {
                    {Speciality.Developer, _rnd.Next(6)},
                    {Speciality.Devops, _rnd.Next(3)},
                    {Speciality.Test, _rnd.Next(4)}
                };

                foreach (var tT in _taskTeam.Values)
                {
                    _countEmpl += tT;
                }

                int count = 0;
                var _selectedEmployee = Staff.Where(e => e.isBusy == false);
                foreach (var se in _selectedEmployee)
                {
                    if (_taskTeam.TryGetValue(se.Speciality, out var value))
                    {
                        if (value > 0)
                        {
                            pt.employees.Add(se);
                            se.isBusy = true;
                            _taskTeam[se.Speciality] -= 1;
                            count += 1;
                            Console.WriteLine($"+1 {se.Speciality}");
                        }
                    }
                }

                if (count == _countEmpl)
                {
                    Console.WriteLine("Task was created!");
                    _projectIsAssembled = true;
                }
                else
                {
                    Console.WriteLine($"Task don't created! Need are {_countEmpl} employees");
                    _projectIsAssembled = false;
                    break;
                }
            }
            if (_projectIsAssembled)
            {
                Console.WriteLine("Team for project are assemled! Project is start!");
            }
            else
            {
                Console.WriteLine("Team for project aren't assemled! Project isn't start!");
            }
        }
    }
}
