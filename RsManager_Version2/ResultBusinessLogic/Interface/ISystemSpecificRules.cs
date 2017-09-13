using DAL;
using ResultBusinessLogic.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultBusinessLogic.Interface
{
  public interface ISystemSpecificRules
    {
        bool ConfirmSchoolExist();
        BusinessMessage<School> GetDefaultSchool();
       BusinessMessage<bool> CreateSchool(School school);
        BusinessMessage<List<Faculty>> CreateFaculty(Faculty faculty);
        BusinessMessage<int> CreateSingleFaculty(Faculty faculty);
        List<Faculty> GetAllFaculties();
    }
}
