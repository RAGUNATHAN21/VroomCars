using Class.Repositary.Interface;
using Class.Repositary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Repositary
{
     public class RepositaryClass: RepositaryInterface
    {
        private readonly NextTurnDBContext _myContext;

        public RepositaryClass(NextTurnDBContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<List<EmployeeVM>> GetAllEmployees()
        {
            return await _myContext.Employees.ToListAsync();
        }
    }
}
