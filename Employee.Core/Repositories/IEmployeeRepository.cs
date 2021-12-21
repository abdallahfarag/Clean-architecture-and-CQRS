using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Entities.Employee>
    {
        Task<IEnumerable<Entities.Employee>> GetEmployeeByLastName(string lastname);
    }
}
