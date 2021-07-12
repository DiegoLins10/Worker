using System;
using System.Collections.Generic;
using System.Text;

namespace Worker.Entities
{
    class Department
    {
        public string NameDepartment { get; set; }


        public Department()
        {
        }
        public Department(string name)
        {
            this.NameDepartment = name;
        }
    }
}
