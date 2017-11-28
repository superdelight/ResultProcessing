﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interface
{
    public interface IStateRepository : IRepository<State>
    {
       IEnumerable<State> GetAllStates(int zoneId);
        State GetState(string name);
    }
}
