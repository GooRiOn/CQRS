using CQRS.Contracts.AddProduct;
using CQRS.Messaging.Busses.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CQRS.Controllers
{

    public class TestInject : ITestInject
    {
        
    }

    public interface ITestInject
    {
    }

    public class ValuesController : ApiController
    {
        //ICommandBus CommandBus { get; }

        public ValuesController(ITestInject testInject)
        {
            var test = testInject;
            //CommandBus = commandBus;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            Debug.WriteLine("Hello World");

            //.Send(new AddProductCommand { Name = "Hello World", InititalQuantity = 600m, Price = 12.32m });

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
