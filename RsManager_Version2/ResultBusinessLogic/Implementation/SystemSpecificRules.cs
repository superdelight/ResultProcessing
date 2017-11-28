using ResultBusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ResultBusinessLogic.Utility;
using DAL.Repository.Service.Implementation;

namespace ResultBusinessLogic.Implementation
{
    public class SystemSpecificRules : ISystemSpecificRules
    {

       AdminContext context = new AdminContext();
        public bool ConfirmSchoolExist()
        {
            
            return context.SchoolContext.GetActiveSchool() != null;
        }

        public BusinessMessage<bool> CreateDepartment(Department dept)
        {
           
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            try
            {
                int facId = (int)dept.FacId;
                if (!context.DepartmentContext.ConfirmDepartment(dept.DeptFullName, dept.DeptCode))
                {
                    context.DepartmentContext.Add(dept);
                    if (context.SaveChanges() > 0)
                    {
                        response.Result = true;
                        response.Response = ResponseCode.OK;
                        response.Message = string.Format("{0} has been successfully created...", dept.DeptFullName);
                    }
                    else
                    {
                        response.Response = ResponseCode.NotOk;
                        response.Result = false;
                        response.Message = string.Format("Attempt to create {0} failed", dept.DeptFullName);
                    }
                }
                else
                {
                    response.Response = ResponseCode.NotOk;
                    response.Message = string.Format("The system could not process duplicate entry for {0}", dept.DeptFullName);
                }
            }
            catch
            {
                response.Response = ResponseCode.NotOk;
                response.Message = string.Format("Null Value");
            }
            return response;
        }

        public BusinessMessage<bool> CreateFaculty(Faculty faculty)
        {
            BusinessMessage<bool> response = new Utility.BusinessMessage<bool>();
             if(context.FacultyContext.ConfirmFactulty(faculty.FacName,faculty.FacAcronyms)==false)
            {
                context.FacultyContext.Add(faculty);
                if(context.SaveChanges()>0)
                {
                    response.Response = ResponseCode.OK;
                    response.Message = string.Format("{0} has been successfully created", faculty.FacName);
                    response.Result = true;

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
           // response.Result = context.FacultyContext.GetAll().ToList();
            return response;
        }

        public BusinessMessage<bool> CreateNewProgramme(Programme progr)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
          // //ResultLINQ context = new ResultLINQ();
            progr.DateCreated = DateTime.Now;
            if (context.ProgrammeContext.ConfirmProgramme(progr.ProgrammeCode, progr.ProgrammeDescription) == false)
            {
                context.ProgrammeContext.Add(progr);
                if (context.SaveChanges() > 0)
                {
                    response.Response = ResponseCode.OK;
                    response.Message = string.Format("{0} has been successfully created", progr.ProgrammeDescription);
                }
                else
                {
                    response.Response = ResponseCode.NotOk;
                    response.Message = string.Format("Attempt to create {0} failed", progr.ProgrammeDescription);
                }
            }
            else
            {
                response.Response = ResponseCode.NotOk;
                response.Message = string.Format("Duplicate Entry is not allowed");
            }
            return response;
        }

        public BusinessMessage<bool> CreateSchool(School school)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
          // //ResultLINQ context = new ResultLINQ();
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
        public List<Department> GetAllDepartments()
        {
            return context.DepartmentContext.GetAll().ToList();
        }
        public List<Faculty> GetAllFaculties()
        {
          
           //     //ResultLINQ context = new ResultLINQ();
            return context.FacultyContext.GetAll().ToList();
            
        }
        public School GetDefaultSchool()
        {
           // BusinessMessage<School> response = new BusinessMessage<School>();
           //ResultLINQ context = new ResultLINQ();
            var sch = context.SchoolContext.GetActiveSchool();
            //if (sch != null)
            //{
            //    response.Response = ResponseCode.OK;
            //    response.Message = "School Exists..";
            //    response.Result = sch;
            //}
            //else
            //{

            //    response.Response = ResponseCode.Error;
            //    response.Message = "Unable to load School Detail..";
            //    response.Result = null;

            //}
            return sch;
        }
        public List<Programme> GetProgrammesInDepartment(int deptId)
        {
          //  BusinessMessage<List<Programme>> response = new BusinessMessage<List<Programme>>();
           //ResultLINQ context = new ResultLINQ();
            var programme = context.ProgrammeContext.GetAllProgramme(deptId).ToList();
            //if (programme != null)
            //{
            //    response.Response = ResponseCode.OK;
            //    response.Message = string.Format("{0} Programme(s)",programme.Count);
            //    response.Result = programme;
            //}
            //else
            //{
            //    response.Response = ResponseCode.Error;
            //    response.Message = "Unable to load programme Detail..";
            //    response.Result = null;
            //}
            return programme;
        }

        public List<Programme> GetProgrammesInFaculty(int facId)
        {
           // BusinessMessage<List<Programme>> response = new BusinessMessage<List<Programme>>();
           //ResultLINQ context = new ResultLINQ();
            var programme = context.ProgrammeContext.GetAllProgrammeByFaculty(facId).ToList();
            //if (programme != null)
            //{
            //    response.Response = ResponseCode.OK;
            //    response.Message = string.Format("{0} Programme(s)", programme.Count);
            //    response.Result = programme;
            //}
            //else
            //{
            //    response.Response = ResponseCode.Error;
            //    response.Message = "Unable to load programme Detail..";
            //    response.Result = null;
            //}
            return programme;
        }

        public BusinessMessage<bool> CreateNewAward(Award award)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.AwardContext.GetAward(award.AwardAcronyms, award.AwardName) == null)
            {
                var awrd = context.AwardContext.Add(award);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} has been created...", award.AwardAcronyms);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to save Award failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "Award with similar parameters already exists";
                response.Result = false;
            }
            return response;
        }

        public List<Award> GetAllAwards()
        {
            return context.AwardContext.GetAll().ToList();
        }

        public Award GetAward(string acronyms)
        {
            return context.AwardContext.GetAward(acronyms, null);
        }

        public BusinessMessage<bool> CreateNewZone(GeoZone zone)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.GeoZoneContext.GetCentre(zone.Description) == null)
            {
                var awrd = context.GeoZoneContext.Add(zone);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} has been created...", zone.Description);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to save new Geo-Political Zone failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "Geo-Political Zone with similar parameters already exists";
                response.Result = false;
            }
            return response;
        }

        public List<GeoZone> GetAllZones()
        {
            return context.GeoZoneContext.GetAll().ToList();
        }

        public GeoZone GetZone(string des)
        {
            return context.GeoZoneContext.GetCentre(des);
        }

        public BusinessMessage<bool> CreateNewState(State state)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.StateContext.GetState(state.Description) == null)
            {
                var awrd = context.StateContext.Add(state);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} has been created...", state.Description);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to save new State failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "State with similar parameters already exists";
                response.Result = false;
            }
            return response;
        }

        public List<State> GetAllStates()
        {
            return context.StateContext.GetAll().ToList();
        }

        public State GetState(string des)
        {
            return context.StateContext.GetState(des);
        }
        public BusinessMessage<bool> CreateNewCity(City city)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.CityContext.GetCity(city.CityName) == null)
            {
                var awrd = context.CityContext.Add(city);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} has been created...", city.CityName);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to save new City failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "City with similar parameters already exists";
                response.Result = false;
            }
            return response;
        }

        public List<City> GetAllCities(int stateId)
        {
            return context.CityContext.GetAll().ToList();
        }
        public City GetCity(string des)
        {
            return context.CityContext.GetCity(des);
        }
        public BusinessMessage<bool> CreateNewCentre(Centre centre)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.CentreContext.GetCentre(centre.CentreCode) == null)
            {
                var awrd = context.CentreContext.Add(centre);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("Centre with {0} has been created...", centre.CentreCode);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to create new Centre failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "Centre with similar parameters already exists";
                response.Result = false;
            }
            return response;
        }
        public List<Centre> GetAllCentresinCity(int cityId)
        {
            return context.CentreContext.GetAllCentresinCity(cityId).ToList();
        }
        public Centre GetCentre(string des)
        {
            return context.CentreContext.GetCentre(des);
        }
        public List<Centre> GetAllCentresinState(int stateId)
        {
            return context.CentreContext.GetAllCentresinState(stateId).ToList();
        }
        public BusinessMessage<bool> CreateAwardLevel(AwardLevel awrdLevel)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.AwardLevelContext.GetAwardLevel(awrdLevel.LevelId,awrdLevel.AwardId) == null)
            {
                var awrd = context.AwardLevelContext.Add(awrdLevel);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} has been created...", awrdLevel.Description);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to create new Award Level failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "Award Level with similar parameters already exists";
                response.Result = false;
            }
            return response;

        }
        public List<AwardLevel> GetAllAwardLevel()
        {
            return context.AwardLevelContext.GetAll().ToList();
        }
        public AwardLevel GetAwardLevel(int awrdId, int levId)
        {
            return context.AwardLevelContext.GetAwardLevel(levId, awrdId);
        }
        public BusinessMessage<bool> CreateFacRequirement(FacultyReq facReq)
        {
            BusinessMessage<bool> response = new BusinessMessage<bool>();
            if (context.FacReqContext.GetFacRequirement(facReq.AwardLevelId,facReq.SemesterId,facReq.FacultyId,facReq.IsElective) == null)
            {
                var awrd = context.FacReqContext.Add(facReq);
                if (context.SaveChanges() > 0)
                {
                    response.Message = string.Format("{0} has been created...", facReq.Description);
                    response.Result = true;
                }
                else
                {
                    response.Message = "Attempt to Create new Faculty Requirement failed";
                    response.Result = false;
                }
            }
            else
            {
                response.Message = "Faculty Requirement with similar parameters already exists";
                response.Result = false;
            }
            return response;

        }
        public FacultyReq GetFacRequirement(int awrdId, int semId, int facId, bool? IsElective)
        {
            return context.FacReqContext.GetFacRequirement(awrdId, semId, facId, IsElective);
        }
        public List<FacultyReq> GetAllFacultyReq(int awrdLevId)
        {
            return context.FacReqContext.GetAllFacultyReq(awrdLevId).ToList();
        }
        public List<FacultyReq> GetAllFacReqInSemester(int semId)
        {
            return context.FacReqContext.GetAllFacReqInSemester(semId).ToList();
        }
        public List<FacultyReq> GetAllFacultyReqInFac(int facId)
        {
            return context.FacReqContext.GetAllFacultyReqInFac(facId).ToList();
        }

        public List<FacultyReq> GetAllFacReq(int awrdLevId, int facId)
        {
            return context.FacReqContext.GetAllFacReq(awrdLevId,facId).ToList(); 
        }

        public List<FacultyReq> GetAllFacReqInSemester(int semId, int facId)
        {
            return context.FacReqContext.GetAllFacReqInSemester(semId, facId).ToList();
        }

        public List<FacultyReq> GetAllFacReqInFaculty(int facId, bool? IsElective)
        {
            return context.FacReqContext.GetAllFacReqInFaculty(facId,IsElective).ToList();
        }
    }
}
