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
        ResultLINQ context = new ResultLINQ();
        public bool ConfirmSchoolExist()
        {
            
            return context.SchoolContext.GetActiveSchool() != null;
        }

        public BusinessMessage<List<Department>> CreateDepartment(Department dept)
        {
            BusinessMessage<List<Department>> response = new BusinessMessage<List<Department>>();
            context.DepartmentContext.Add(dept);
            if(context.SaveChanges()>0)
            {
                response.Result = context.DepartmentContext.GetAllDepartment((int)dept.FacId).ToList();
                response.Response = ResponseCode.OK;
            }
            else
            {
                response.Response = ResponseCode.NotOk;
            }
            return response;
        }

        public BusinessMessage<List<Faculty>> CreateFaculty(Faculty faculty)
        {
            BusinessMessage<List<Faculty>> response = new Utility.BusinessMessage<List<Faculty>>();
             if(context.FacultyContext.ConfirmFactulty(faculty.FacName,faculty.FacAcronyms)==false)
            {
                context.FacultyContext.Add(faculty);
                if(context.SaveChanges()>0)
                {
                    response.Response = ResponseCode.OK;
                    response.Message = string.Format("{0} has been successfully created", faculty.FacName);

                }
                else
                {
                    response.Response = ResponseCode.NotOk;
                    response.Message = string.Format("Attempt to create {0} failed", faculty.FacName);

                }
            }
            else
            {
                response.Response = ResponseCode.NotOk;
                response.Message = string.Format("Duplicate Entry is not allowed");

            }
            response.Result = context.FacultyContext.GetAll().ToList();
            return response;
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

        public List<Department> GetAllDepartments(int facId)
        {
            return context.DepartmentContext.GetAllDepartment(facId).ToList();
        }
        public List<Faculty> GetAllFaculties()
        {
          
            ResultLINQ context = new ResultLINQ();
            return context.FacultyContext.GetAll().ToList();
            
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
