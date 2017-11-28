using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Service.Interface
{
    public interface IAdminContext : IDisposable
    {
        ISchoolRepository SchoolContext { get;}
        IFacultyRepository FacultyContext { get; }
        ICourseRepository CourseContext { get; }
        IDepartmentRepository DepartmentContext { get; }
        IProgrammeRepository ProgrammeContext { get; }
        IAwardRepository AwardContext { get; }
        ILevelRepository LevelContext { get; }
        IAwardLevelRepository AwardLevelContext { get; }
        ICentreRepository CentreContext { get; }
        ICityRepository CityContext { get; }
        IGenReqRepository GenReqContext { get; }
        IGeoZoneRepository GeoZoneContext { get; }
        IFacReqRepository FacReqContext { get; }
        IStateRepository StateContext { get; }
        int SaveChanges();
    }
}
