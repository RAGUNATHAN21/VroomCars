using System;
using System.Collections.Generic;

#nullable disable

namespace Class.Repositary.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<EmployeeVM>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptLocation { get; set; }

        public virtual ICollection<EmployeeVM> Employees { get; set; }
    }
}
