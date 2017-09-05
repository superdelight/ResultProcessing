using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Implementation
{
    public class LevelRepository : Repository<Level>, ILevelRepository
    {
        private DbContext Context;
        public LevelRepository(DbContext Context)
            : base(Context)
        {
            this.Context = Context;
        }

        public IEnumerable<Level> GetAllLevels()
        {
            var lev = Context.Set<Level>().ToList();
            if(lev.Count<=0)
            {
                lev = new List<DAL.Level>();
                lev.Add(new Level() { Description = "100L" });
                lev.Add(new Level() { Description = "200L" });
                lev.Add(new Level() { Description = "300L" });
                lev.Add(new Level() { Description = "400L" });
                lev.Add(new Level() { Description = "500L" });
                Context.SaveChanges();
                lev = Context.Set<Level>().ToList();
            }
            return lev;
        }
    }
}