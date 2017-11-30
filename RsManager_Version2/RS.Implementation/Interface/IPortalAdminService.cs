using ResultBusinessLogic.Utility;
using RS.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RS.Implementation.Interface
{
    [ServiceContract]
    public interface IPortalAdminService
    {
        [OperationContract]
        SchoolDTO GetDefaultSchool();
        [OperationContract]
        BusinessMessage<bool> CreateSchool(SchoolDTO school);
        [OperationContract]
        BusinessMessage<bool> CreateFaculty(FacultyDTO faculty);
        [OperationContract]
        List<FacultyDTO> GetAllFaculties();
        [OperationContract]
        List<DepartmentDTO> GetAllDepartmentsinFAC(int facId);
        [OperationContract]
        BusinessMessage<bool> CreateDepartment(DepartmentDTO dept);
        [OperationContract]
        BusinessMessage<bool> CreateNewProgramme(ProgrammeDTO progr);
        [OperationContract]
        List<DepartmentDTO> GetAllDepartments();
        [OperationContract]
        List<ProgrammeDTO> GetProgrammesInDepartment(int deptId);
        [OperationContract]
        List<ProgrammeDTO> GetProgrammesInFaculty(int facId);
        [OperationContract]
        BusinessMessage<bool> CreateNewAward(AwardDTO award);
        [OperationContract]
        List<AwardDTO> GetAllAwards();
        [OperationContract]
        AwardDTO GetAward(string acronyms);
        [OperationContract]
        BusinessMessage<bool> CreateNewZone(GeoZoneDTO zone);
        [OperationContract]
        List<GeoZoneDTO> GetAllZones();
        [OperationContract]
        GeoZoneDTO GetZone(string des);
        [OperationContract]
        BusinessMessage<bool> CreateNewState(StateDTO state);
        [OperationContract]
        List<StateDTO> GetAllStates();
        [OperationContract]
        List<StateDTO> GetAllStatesinZone(int zoneId);
        [OperationContract]
        StateDTO GetState(string des);
        [OperationContract]
        BusinessMessage<bool> CreateNewCity(CityDTO city);
        [OperationContract]
        List<CityDTO> GetAllCities(int stateId);
        [OperationContract]
        CityDTO GetCity(string des);
        [OperationContract]
        BusinessMessage<bool> CreateNewCentre(CentreDTO centre);
        [OperationContract]
        List<CentreDTO> GetAllCentresinCity(int cityId);
        [OperationContract]
        List<CentreDTO> GetAllCentresinState(int stateId);
        [OperationContract]
        CentreDTO GetCentre(string des);
        [OperationContract]
        BusinessMessage<bool> CreateAwardLevel(AwardLevelDTO awrdLevel);
        [OperationContract]
        List<AwardLevelDTO> GetAllAwardLevel();
        [OperationContract]
        AwardLevelDTO GetAwardLevel(int awrdId, int levId);
        [OperationContract]
        BusinessMessage<bool> CreateFacRequirement(FacultyReqDTO facReq);
        [OperationContract]
        FacultyReqDTO GetFacRequirement(int awrdId, int semId, int facId, bool? IsElective);
        [OperationContract]
        List<FacultyReqDTO> GetAllFacultyReq(int awrdLevId);
        [OperationContract]
        List<FacultyReqDTO> GetAllFacReqInSemester(int semId);
        [OperationContract]
        List<FacultyReqDTO> GetAllFacultyReqInFac(int facId);
        [OperationContract]
        List<FacultyReqDTO> GetAllFacReq(int awrdLevId, int facId);
        [OperationContract]
        List<FacultyReqDTO> GetAllFacReqInSemesterFaq(int semId, int facId);
        [OperationContract]
        List<FacultyReqDTO> GetAllFacReqInFaculty(int facId, bool? IsElective);
    }
}
