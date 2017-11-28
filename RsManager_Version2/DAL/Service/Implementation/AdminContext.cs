using DAL.Repository.Implementation;
using DAL.Repository.Interface;
using DAL.Repository.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Service.Implementation
{
    public class AdminContext:IAdminContext
    {
           private readonly ResultMEntities _Context;
        public AdminContext()
        {
            _Context = new DAL.ResultMEntities();
            SchoolContext = new SchoolRepository(_Context);
            FacultyContext = new FacultyRepository(_Context);
            CourseContext = new CourseRepository(_Context);
            DepartmentContext = new DepartmentRepository(_Context);
            ProgrammeContext = new ProgrammeRepository(_Context);
            AwardContext = new AwardRepository(_Context);
            AwardLevelContext = new AwardLevelRepository(_Context);
            CentreContext = new CentreRepository(_Context);
            CityContext = new CityRepository(_Context);
            FacReqContext = new FacultyReqRepository(_Context);
            LevelContext = new LevelRepository(_Context);
            GeoZoneContext = new GeoZoneRepository(_Context);
            GenReqContext = new GenReqRepository(_Context);
            StateContext = new StateRepository(_Context);
        }

        public IAwardRepository AwardContext { get; private set; }
        public IAwardLevelRepository AwardLevelContext { get; private set; }
        public ICentreRepository CentreContext { get; private set; }
        public ICityRepository CityContext { get; private set; }
        public ICourseRepository CourseContext { get; private set; }
        public IDepartmentRepository DepartmentContext { get; private set; }
        public IFacReqRepository FacReqContext { get; private set; }
        public IFacultyRepository FacultyContext { get; private set; }
        public IGenReqRepository GenReqContext { get; private set; }
        public IGeoZoneRepository GeoZoneContext { get; private set; }
        public ILevelRepository LevelContext { get; private set; }
        public IProgrammeRepository ProgrammeContext { get; private set; }
        public ISchoolRepository SchoolContext { get; private set;}

        public IStateRepository StateContext { get; private set; }
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return _Context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}
