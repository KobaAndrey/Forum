﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dal.Interface.Entities;
using Dal.Implementation;
using Dal.Interface.DataAccess;
using System.Data.Entity.Infrastructure;
using Dal.Interface;

namespace Dal.Implementation.Concrete
{
    public class UserRepository: EntityRepository<DalUser>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
