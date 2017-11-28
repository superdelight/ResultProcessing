using RS.Implementation.Interface;
using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultBusinessLogic.Utility;
using RS.DataContract;
using ResultBusinessLogic.Implementation;
using ResultBusinessLogic.Interface;

namespace RS.Implementation.Implementation
{
    public class PortalAdminService : IPortalAdminService
    {
        ISystemSpecificRules logic;
        public PortalAdminService(ISystemSpecificRules logic)
        {
            this.logic = logic;
        }

        public BusinessMessage<bool> CreateAwardLevel(AwardLevelDTO awrdLevel)
        {
            throw new NotImplementedException();
        }

        public BusinessMessage<bool> CreateDepartment(DepartmentDTO dept)
        {
           return logic.CreateDepartment(dept.FromDTO());
        }

        public BusinessMessage<bool> CreateFacRequirement(FacultyReqDTO facReq)
        {
            throw new NotImplementedException();
        }

        public BusinessMessage<bool> CreateFaculty(FacultyDTO faculty)
        {
            return logic.CreateFaculty(faculty.FromDTO());
        }

        public BusinessMessage<bool> CreateNewAward(AwardDTO award)
        {
            return logic.CreateNewAward(award.FromDTO());
        }

        public BusinessMessage<bool> CreateNewCentre(CentreDTO centre)
        {
            return logic.CreateNewCentre(centre.FromDTO());
        }

        public BusinessMessage<bool> CreateNewCity(CityDTO city)
        {
            return logic.CreateNewCity(city.FromDTO());
        }

        public BusinessMessage<bool> CreateNewProgramme(ProgrammeDTO progr)
        {
            return logic.CreateNewProgramme(progr.FromDTO());
        }

        public BusinessMessage<bool> CreateNewState(StateDTO state)
        {
            return logic.CreateNewState(state.FromDTO());
        }

        public BusinessMessage<bool> CreateNewZone(GeoZoneDTO zone)
        {
            return logic.CreateNewZone(zone.FromDTO());
        }

        public BusinessMessage<bool> CreateSchool(SchoolDTO school)
        {
             
            return logic.CreateSchool(school.FromDTO());
        }

        public List<AwardLevelDTO> GetAllAwardLevel()
        {
            return logic.GetAllAwardLevel().ToDTO();
        }

        public List<AwardDTO> GetAllAwards()
        {
           return logic.GetAllAwards().ToDTO();
        }

        public List<CentreDTO> GetAllCentresinCity(int cityId)
        {
            return logic.GetAllCentresinCity(cityId).ToDTO();
        }

        public List<CentreDTO> GetAllCentresinState(int stateId)
        {
            return logic.GetAllCentresinState(stateId).ToDTO();
        }

        public List<CityDTO> GetAllCities(int stateId)
        {
            return logic.GetAllCities(stateId).ToDTO();
        }

        public List<DepartmentDTO> GetAllDepartments()
        {
            return logic.GetAllDepartments().ToDTO();
        }

        public List<DepartmentDTO> GetAllDepartmentsinFAC(int facId)
        {
            return logic.GetAllDepartments(facId).ToDTO();
        }

        public List<FacultyReqDTO> GetAllFacReq(int awrdLevId, int facId)
        {
            return logic.GetAllFacReq(awrdLevId, facId).ToDTO();
        }

        public List<FacultyReqDTO> GetAllFacReqInFaculty(int facId, bool? IsElective)
        {
            return logic.GetAllFacReqInFaculty(facId, IsElective).ToDTO();
        }

        public List<FacultyReqDTO> GetAllFacReqInSemester(int semId)
        {
            return logic.GetAllFacReqInSemester(semId).ToDTO();
        }

        public List<FacultyReqDTO> GetAllFacReqInSemester(int semId, int facId)
        {
            throw new NotImplementedException();
        }

        public List<FacultyDTO> GetAllFaculties()
        {
            return logic.GetAllFaculties().ToDTO();
        }

        public List<FacultyReqDTO> GetAllFacultyReq(int awrdLevId)
        {
            return logic.GetAllFacultyReq(awrdLevId).ToDTO();
        }

        public List<FacultyReqDTO> GetAllFacultyReqInFac(int facId)
        {
            return logic.GetAllFacultyReqInFac(facId).ToDTO();
        }

        public List<StateDTO> GetAllStates()
        {
            return logic.GetAllStates().ToDTO();
        }

        public List<GeoZoneDTO> GetAllZones()
        {
            return logic.GetAllZones().ToDTO();
        }

        public AwardDTO GetAward(string acronyms)
        {
            return logic.GetAward(acronyms).ToDTO();
        }

        public AwardLevelDTO GetAwardLevel(int awrdId, int levId)
        {
            return logic.GetAwardLevel(awrdId, levId).ToDTO();
        }

        public CentreDTO GetCentre(string des)
        {
            return logic.GetCentre(des).ToDTO();
        }

        public CityDTO GetCity(string des)
        {
            return logic.GetCity(des).ToDTO();
        }

        public SchoolDTO GetDefaultSchool()
        {
            return logic.GetDefaultSchool().ToDTO();
        }

        public FacultyReqDTO GetFacRequirement(int awrdId, int semId, int facId, bool? IsElective)
        {
            return logic.GetFacRequirement(awrdId, semId, facId, IsElective).ToDTO();
        }

        public List<ProgrammeDTO> GetProgrammesInDepartment(int deptId)
        {
            return logic.GetProgrammesInDepartment(deptId).ToDTO();
        }

        public List<ProgrammeDTO> GetProgrammesInFaculty(int facId)
        {
            return logic.GetProgrammesInFaculty(facId).ToDTO();
        }

        public StateDTO GetState(string des)
        {
            return logic.GetState(des).ToDTO();
        }
        public GeoZoneDTO GetZone(string des)
        {
            return logic.GetZone(des).ToDTO();
        }
    }
}
