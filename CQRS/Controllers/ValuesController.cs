using CQRS.Contracts.AddProduct;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using CQRS.Infrastructure.Interfaces.Busses;

namespace CQRS.Controllers
{
    public class ValuesController : ApiController
    {
        ICommandBus CommandBus { get; }

        public ValuesController(ICommandBus commandBus)
        {
            //var test = testInject;
            CommandBus = commandBus;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            Debug.WriteLine("Hello World");

            CommandBus.Send(new AddProductCommand { Name = "Hello World", InititalQuantity = 600m, Price = 12.32m });

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
