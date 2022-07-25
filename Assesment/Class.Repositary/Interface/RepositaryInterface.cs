using Class.Repositary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Repositary.Interface
{
    public interface RepositaryInterface
    {
        Task<List<EmployeeVM>> GetAllEmployees();
    }
}
