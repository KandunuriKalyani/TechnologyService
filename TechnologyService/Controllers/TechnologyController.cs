using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TechnologyDataAccess;

namespace TechnologyService.Controllers
{
    public class TechnologyController : ApiController
    {
        public IEnumerable<TechnologyTable> Get()
        {
            using(TechnologyDBEntities entities = new TechnologyDBEntities())
            {
                return entities.TechnologyTables.ToList();
            }
        }

       public TechnologyTable Get(int seqno)
        {
            using (TechnologyDBEntities entities = new TechnologyDBEntities())
            {
                return entities.TechnologyTables.FirstOrDefault(e=>e.SNO==seqno);
            }
        }
    }
}
