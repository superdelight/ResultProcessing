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

        BusinessMessage<bool> CreateNewZone(GeoZoneDTO zone);
        List<GeoZoneDTO> GetAllZones();
        GeoZoneDTO GetZone(string des);

        BusinessMessage<bool> CreateNewState(StateDTO state);
        List<StateDTO> GetAllStates();
        StateDTO GetState(string des);

        BusinessMessage<bool> CreateNewCity(CityDTO city);
        List<CityDTO> GetAllCities(int stateId);
        CityDTO GetCity(string des);

        BusinessMessage<bool> CreateNewCentre(CentreDTO centre);
        List<CentreDTO> GetAllCentresinCity(int cityId);
        List<CentreDTO> GetAllCentresinState(int stateId);
        CentreDTO GetCentre(string des);

        BusinessMessage<bool> CreateAwardLevel(AwardLevelDTO awrdLevel);
        List<AwardLevelDTO> GetAllAwardLevel();
        AwardLevelDTO GetAwardLevel(int awrdId, int levId);

        BusinessMessage<bool> CreateFacRequirement(FacultyReqDTO facReq);
        FacultyReqDTO GetFacRequirement(int awrdId, int semId, int facId, bool? IsElective);
        List<FacultyReqDTO> GetAllFacultyReq(int awrdLevId);
        List<FacultyReqDTO> GetAllFacReqInSemester(int semId);
        List<FacultyReqDTO> GetAllFacultyReqInFac(int facId);
        List<FacultyReqDTO> GetAllFacReq(int awrdLevId, int facId);
        List<FacultyReqDTO> GetAllFacReqInSemester(int semId, int facId);
        List<FacultyReqDTO> GetAllFacReqInFaculty(int facId, bool? IsElective);
    }
}
