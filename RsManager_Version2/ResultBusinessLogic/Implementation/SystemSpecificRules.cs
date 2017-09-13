using ResultBusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ResultBusinessLogic.Utility;
using DAL.Repository.Implementation;

namespace ResultBusinessLogic.Implementation
{
    public class SystemSpecificRules : ISystemSpecificRules
    {
        public bool ConfirmSchoolExist()
        {
            ResultLINQ context = new ResultLINQ();
            return context.SchoolContext.GetActiveSchool() != null;
        }

        public BusinessMessage<List<Faculty>> CreateFaculty(Faculty faculty)
        {
            throw new NotImplementedException();
        }

        public BusinessMessage<bool> CreateSchool(School school)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            ResultLINQ context = new ResultLINQ();
            if (context.SchoolContext.GetActiveSchool() == null)
            {
                context.SchoolContext.Add(school);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} just been added",school.SchoolName);
                    response.Response = ResponseCode.OK;
                    response.Result = true;
                }
                else
                {
                    response.Message = string.Format("Attempt to Create {0} failed due to technical reason", school.SchoolName);
                    response.Response = ResponseCode.Error;
                    response.Result = false;
                }
            }
            else
            {
                response.Message = string.Format("Attempt to Create {0} failed because, there alrady a preconfiguration", school.SchoolName);
                response.Response = ResponseCode.Error;
                response.Result = false;
            }
            return response;
        }

        public BusinessMessage<int> CreateSingleFaculty(Faculty faculty)
        {
            throw new NotImplementedException();
        }

        public List<Faculty> GetAllFaculties()
        {
            throw new NotImplementedException();
        }

        public BusinessMessage<School> GetDefaultSchool()
        {
            BusinessMessage<School> response = new BusinessMessage<School>();
            ResultLINQ context = new ResultLINQ();
            var sch = context.SchoolContext.GetActiveSchool();
            if (sch != null)
            {
                response.Response = ResponseCode.OK;
                response.Message = "School Exists..";
                response.Result = sch;
            }
            else
            {

                response.Response = ResponseCode.Error;
                response.Message = "Unable to load School Detail..";
                response.Result = null;

            }
            return response;
        }
    }
}
