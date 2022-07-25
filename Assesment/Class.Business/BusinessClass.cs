using AutoMapper;
using Class.Business.Interface;
using Class.Repositary.Interface;
using Class.Repositary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Business
{
    public class BusinessClass : BusinessInterface
    {
        private readonly RepositaryInterface _employeeRepository;
        private readonly IMapper _mapper;  
        public BusinessClass(RepositaryInterface employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeVM>> GetAllEmployees()
        {
            List<EmployeeVM> list = await _employeeRepository.GetAllEmployees();
            return _mapper.Map<List<EmployeeVM>>(list);
        }
    }
}
