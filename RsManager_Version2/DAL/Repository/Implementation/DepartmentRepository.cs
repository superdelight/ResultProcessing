using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private DbContext Context;
        public DepartmentRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }
       public bool ConfirmDepartment(string deptName, string deptCode)
        {
            return Context.Set<Department>().Where(c => c.DeptFullName.ToLower().Equals(deptName.ToLower()) ||
            c.DeptCode.ToLower().Equals(deptCode.ToLower())).Any();
        }

        public IEnumerable<Department> GetAllDepartment(int facId)
        {
            return Context.Set<Department>().Where(c => c.FacId == facId).ToList();
        }

        public Department GetDepartmentByCode(string code)
        {
            return Context.Set<Department>().Where(c => c.DeptCode.ToLower().Equals(code.ToLower())).FirstOrDefault();
        }

        public Department GetDepartmentByName(string deptName)
        {
            return Context.Set<Department>().Where(c => c.DeptFullName.ToLower().Equals(deptName.ToLower())).FirstOrDefault();
        }
    }
}