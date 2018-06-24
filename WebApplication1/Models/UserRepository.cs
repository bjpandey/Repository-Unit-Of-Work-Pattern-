using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Infrastructure;

namespace WebApplication1.Models

{
    public class UserRepository : BaseRepository<tblUser>
    {

        public UserRepository(IUnitOfWork unit) : base(unit)
        {

        }

        internal void Update(tblUser tb)
        {
            throw new NotImplementedException();
        }
    }


}