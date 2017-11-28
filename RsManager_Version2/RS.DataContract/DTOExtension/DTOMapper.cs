
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DataContract
{
    public static class DTOMapper
    {
        public static SchoolDTO ToDTO(this School source)
        {
            if (source == null) return null;
            return new SchoolDTO()
            {
                Id=source.Id,
                SchoolName = source.SchoolName,
                Address = source.Address,
                DateCreated = source.DateCreated,
                EmailAddress=source.EmailAddress,
                IsVisible=source.IsVisible,
                Logo=source.Logo,
                PhoneNo=source.PhoneNo
            };
        }
        public static List<SchoolDTO> ToDTO(this List<School> source)
        {
            if (source == null) return new List<SchoolDTO>();
            List<SchoolDTO> banks = new List<SchoolDTO>();
            source.ForEach(o => banks.Add(o.ToDTO()));
            return banks;
        }
        public static School FromDTO(this SchoolDTO source)
        {
            if (source == null) return null;
            return new School()
            {

                Id = source.Id,
                SchoolName = source.SchoolName,
                Address = source.Address,
                DateCreated = source.DateCreated,
                EmailAddress = source.EmailAddress,
                IsVisible = source.IsVisible,
                Logo = source.Logo,
                PhoneNo = source.PhoneNo

            };
        }


        public static FacultyDTO ToDTO(this Faculty source)
        {
            if (source == null) return null;
            return new FacultyDTO()
            {
                Id = source.Id,
                FacAcronyms = source.FacAcronyms,
                FacName = source.FacAcronyms,
                SchoolId = source.SchoolId
            };
        }
        public static List<FacultyDTO> ToDTO(this List<Faculty> source)
        {
            if (source == null) return new List<FacultyDTO>();
            List<FacultyDTO> fac = new List<FacultyDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static Faculty FromDTO(this FacultyDTO source)
        {
            if (source == null) return null;
            return new Faculty()
            {

                Id = source.Id,
                FacAcronyms = source.FacAcronyms,
                FacName = source.FacAcronyms,
                SchoolId = source.SchoolId
            };
        }


        public static DepartmentDTO ToDTO(this Department source)
        {
            if (source == null) return null;
            return new DepartmentDTO()
            {
                Id = source.Id,
                DeptCode = source.DeptCode,
                DeptFullName = source.DeptFullName,
                FacId = source.FacId,
                DateCreated=source.DateCreated,
                IsVisible=source.IsVisible
            };
        }
        public static List<DepartmentDTO> ToDTO(this List<Department> source)
        {
            if (source == null) return new List<DepartmentDTO>();
            List<DepartmentDTO> fac = new List<DepartmentDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static Department FromDTO(this DepartmentDTO source)
        {
            if (source == null) return null;
            return new Department()
            {
                Id = source.Id,
                DeptCode = source.DeptCode,
                DeptFullName = source.DeptFullName,
                FacId = source.FacId,
                DateCreated = source.DateCreated,
                IsVisible = source.IsVisible
            };
        }

        public static AwardDTO ToDTO(this Award source)
        {
            if (source == null) return null;
            return new AwardDTO()
            {
                Id = source.Id,
                AwardAcronyms = source.AwardAcronyms,
                AwardName = source.AwardName
              
            };
        }
        public static List<AwardDTO> ToDTO(this List<Award> source)
        {
            if (source == null) return new List<AwardDTO>();
            List<AwardDTO> fac = new List<AwardDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static Award FromDTO(this AwardDTO source)
        {
            if (source == null) return null;
            return new Award()
            {
                Id = source.Id,
                AwardAcronyms = source.AwardAcronyms,
                AwardName = source.AwardName
            };
        }


        public static ProgrammeDTO ToDTO(this Programme source)
        {
            if (source == null) return null;
            return new ProgrammeDTO()
            {
                Id = source.Id,
                ProgrammeCode = source.ProgrammeCode,
                deptId = source.deptId,
                ExpectedGraduationYear=source.ExpectedGraduationYear,
                DateCreated=source.DateCreated,
                ProgrammeDescription=source.ProgrammeDescription
            };
        }
        public static List<ProgrammeDTO> ToDTO(this List<Programme> source)
        {
            if (source == null) return new List<ProgrammeDTO>();
            List<ProgrammeDTO> fac = new List<ProgrammeDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static Programme FromDTO(this ProgrammeDTO source)
        {
            if (source == null) return null;
            return new Programme()
            {
                Id = source.Id,
                ProgrammeCode = source.ProgrammeCode,
                deptId = source.deptId,
                ExpectedGraduationYear = source.ExpectedGraduationYear,
                DateCreated = source.DateCreated,
                ProgrammeDescription = source.ProgrammeDescription
            };
        }

        public static GeoZoneDTO ToDTO(this GeoZone source)
        {
            if (source == null) return null;
            return new GeoZoneDTO()
            {
                Id = source.Id,
                Description = source.Description
            };
        }
        public static List<GeoZoneDTO> ToDTO(this List<GeoZone> source)
        {
            if (source == null) return new List<GeoZoneDTO>();
            List<GeoZoneDTO> fac = new List<GeoZoneDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static GeoZone FromDTO(this GeoZoneDTO source)
        {
            if (source == null) return null;
            return new GeoZone()
            {
                Id = source.Id,
                Description = source.Description
            };
        }


        public static CityDTO ToDTO(this City source)
        {
            if (source == null) return null;
            return new CityDTO()
            {
                Id = source.Id,
                CityName = source.CityName,
                StateId=source.StateId
            };
        }
        public static List<CityDTO> ToDTO(this List<City> source)
        {
            if (source == null) return new List<CityDTO>();
            List<CityDTO> fac = new List<CityDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static City FromDTO(this CityDTO source)
        {
            if (source == null) return null;
            return new City()
            {
                Id = source.Id,
                CityName = source.CityName,
                StateId = source.StateId
            };
        }


        public static StateDTO ToDTO(this State source)
        {
            if (source == null) return null;
            return new StateDTO()
            {
                Id = source.Id,
                Description = source.Description,
                GeoZoneId = source.GeoZoneId,
               StateCode=source.StateCode
            };
        }
        public static List<StateDTO> ToDTO(this List<State> source)
        {
            if (source == null) return new List<StateDTO>();
            List<StateDTO> fac = new List<StateDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static State FromDTO(this StateDTO source)
        {
            if (source == null) return null;
            return new State()
            {
                Id = source.Id,
                Description = source.Description,
                GeoZoneId = source.GeoZoneId,
                StateCode = source.StateCode
            };
        }

        public static CentreDTO ToDTO(this Centre source)
        {
            if (source == null) return null;
            return new CentreDTO()
            {
                Id = source.Id,
                Description = source.Description,
                CentreCode = source.CentreCode,
                CentrePicture = source.CentrePicture,
                CityId=source.CityId,
                EmailAddress=source.EmailAddress,
                PhoneNo=source.PhoneNo,
                SchoolId=source.SchoolId
            };
        }
        public static List<CentreDTO> ToDTO(this List<Centre> source)
        {
            if (source == null) return new List<CentreDTO>();
            List<CentreDTO> fac = new List<CentreDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static Centre FromDTO(this CentreDTO source)
        {
            if (source == null) return null;
            return new Centre()
            {
                Id = source.Id,
                Description = source.Description,
                CentreCode = source.CentreCode,
                CentrePicture = source.CentrePicture,
                CityId = source.CityId,
                EmailAddress = source.EmailAddress,
                PhoneNo = source.PhoneNo,
                SchoolId = source.SchoolId
            };
        }

        public static LevelDTO ToDTO(this Level source)
        {
            if (source == null) return null;
            return new LevelDTO()
            {
                Id = source.Id,
                Description = source.Description
                
            };
        }
        public static List<LevelDTO> ToDTO(this List<Level> source)
        {
            if (source == null) return new List<LevelDTO>();
            List<LevelDTO> fac = new List<LevelDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static Level FromDTO(this LevelDTO source)
        {
            if (source == null) return null;
            return new Level()
            {
                Id = source.Id,
                Description = source.Description
            };
        }

        public static FacultyReqDTO ToDTO(this FacultyReq source)
        {
            if (source == null) return null;
            return new FacultyReqDTO()
            {
                Id = source.Id,
                Description = source.Description,
                AwardLevelId = source.AwardLevelId,
                FacultyId=source.FacultyId,
                IsElective=source.IsElective,
                MaximumUnit=source.MaximumUnit,
                MinimumUnit=source.MinimumUnit,
                SemesterId=source.SemesterId

            };
        }
        public static List<FacultyReqDTO> ToDTO(this List<FacultyReq> source)
        {
            if (source == null) return new List<FacultyReqDTO>();
            List<FacultyReqDTO> fac = new List<FacultyReqDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static FacultyReq FromDTO(this FacultyReqDTO source)
        {
            if (source == null) return null;
            return new FacultyReq()
            {
                Id = source.Id,
                Description = source.Description,
                AwardLevelId = source.AwardLevelId,
                FacultyId = source.FacultyId,
                IsElective = source.IsElective,
                MaximumUnit = source.MaximumUnit,
                MinimumUnit = source.MinimumUnit,
                SemesterId = source.SemesterId
            };
        }

        public static ProgrammeReqDTO ToDTO(this ProgrammeReq source)
        {
            if (source == null) return null;
            return new ProgrammeReqDTO()
            {
                Id = source.Id,
                Description = source.Description,
                AwardLevelId = source.AwardLevelId,
                ProgrammeId = source.ProgrammeId,
                IsElective = source.IsElective,
                MaximumUnit = source.MaximumUnit,
                MinimumUnit = source.MinimumUnit,
                SemesterId = source.SemesterId

            };
        }
        public static List<ProgrammeReqDTO> ToDTO(this List<ProgrammeReq> source)
        {
            if (source == null) return new List<ProgrammeReqDTO>();
            List<ProgrammeReqDTO> fac = new List<ProgrammeReqDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static ProgrammeReq FromDTO(this ProgrammeReqDTO source)
        {
            if (source == null) return null;
            return new ProgrammeReq()
            {
                Id = source.Id,
                Description = source.Description,
                AwardLevelId = source.AwardLevelId,
                ProgrammeId = source.ProgrammeId,
                IsElective = source.IsElective,
                MaximumUnit = source.MaximumUnit,
                MinimumUnit = source.MinimumUnit,
                SemesterId = source.SemesterId
            };
        }

        public static AwardLevelDTO ToDTO(this AwardLevel source)
        {
            if (source == null) return null;
            return new AwardLevelDTO()
            {
                Id = source.Id,
                Description = source.Description,
                AwardId=source.AwardId,
                LevelId=source.LevelId

            };
        }
        public static List<AwardLevelDTO> ToDTO(this List<AwardLevel> source)
        {
            if (source == null) return new List<AwardLevelDTO>();
            List<AwardLevelDTO> fac = new List<AwardLevelDTO>();
            source.ForEach(o => fac.Add(o.ToDTO()));
            return fac;
        }
        public static AwardLevel FromDTO(this AwardLevelDTO source)
        {
            if (source == null) return null;
            return new AwardLevel()
            {
                Id = source.Id,
                Description = source.Description,
                AwardId = source.AwardId,
                LevelId = source.LevelId
            };
        }
    }
}
