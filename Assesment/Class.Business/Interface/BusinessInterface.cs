using Class.Repositary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Business.Interface
{
    public interface BusinessInterface
    {
        Task<List<EmployeeVM>> GetAllEmployees();
      


        
    }
}
