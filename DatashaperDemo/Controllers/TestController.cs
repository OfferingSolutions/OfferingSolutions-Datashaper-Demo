using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DatashaperDemo.Factories;
using DatashaperDemo.Models;
using OfferingSolutions.Datashaper;

namespace DatashaperDemo.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Get(string fields = null)
        {
            try
            {
                ParentClassFactory parentClassFactory = new ParentClassFactory();

                List<ParentClass> parents = new List<ParentClass>()
                {
                    parentClassFactory.CreateParentClass(),
                    parentClassFactory.CreateParentClass()
                    //...
                };

                List<string> listOfFields = new List<string>();

                if (fields != null)
                {
                    listOfFields = fields.Split(',').ToList();
                }

                IEnumerable<object> result = parents
                    .Select(x => Datashaper.CreateDataShapedObject(x, listOfFields));

                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
