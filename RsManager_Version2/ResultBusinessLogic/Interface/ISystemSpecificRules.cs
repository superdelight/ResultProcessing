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
        School GetDefaultSchool();
        BusinessMessage<bool> CreateSchool(School school);
        BusinessMessage<bool> CreateFaculty(Faculty faculty);
        BusinessMessage<int> CreateSingleFaculty(Faculty faculty);
        List<Faculty> GetAllFaculties();
        List<Department> GetAllDepartments(int facId);
        BusinessMessage<bool> CreateDepartment(Department dept);
        BusinessMessage<bool> CreateNewProgramme(Programme progr);
        List<Department> GetAllDepartments();
        List<Programme> GetProgrammesInDepartment(int deptId);
        List<Programme> GetProgrammesInFaculty(int facId);
        BusinessMessage<bool> CreateNewAward(Award award);
        List<Award> GetAllAwards();
        Award GetAward(string acronyms);

        BusinessMessage<bool> CreateNewZone(GeoZone zone);
        List<GeoZone> GetAllZones();
        GeoZone GetZone(string des);

        BusinessMessage<bool> CreateNewState(State state);
        List<State> GetAllStates();
        State GetState(string des);

        BusinessMessage<bool> CreateNewCity(City city);
        List<City> GetAllCities(int stateId);
        City GetCity(string des);

        BusinessMessage<bool> CreateNewCentre(Centre centre);
        List<Centre> GetAllCentresinCity(int cityId);
        List<Centre> GetAllCentresinState(int stateId);
        Centre GetCentre(string des);

        BusinessMessage<bool> CreateAwardLevel(AwardLevel awrdLevel);
        List<AwardLevel> GetAllAwardLevel();
        AwardLevel GetAwardLevel(int awrdId,int levId);

        BusinessMessage<bool> CreateFacRequirement(FacultyReq facReq);
        FacultyReq GetFacRequirement(int awrdId, int semId, int facId, bool? IsElective);
        List<FacultyReq> GetAllFacultyReq(int awrdLevId);
        List<FacultyReq> GetAllFacReqInSemester(int semId);
        List<FacultyReq> GetAllFacultyReqInFac(int facId);
        List<FacultyReq> GetAllFacReq(int awrdLevId, int facId);
        List<FacultyReq> GetAllFacReqInSemester(int semId, int facId);
        List<FacultyReq> GetAllFacReqInFaculty(int facId, bool? IsElective);
    }
}
