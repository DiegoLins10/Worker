using System;
using System.Collections.Generic;
using System.Text;

namespace Worker.Entities
{
    class Department
    {
        public string Name { get; set; }


        public Department()
        {
        }
        public Department(string name)
        {
            this.Name = name;
        }
    }
}
