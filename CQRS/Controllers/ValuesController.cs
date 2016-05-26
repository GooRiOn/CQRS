using CQRS.Contracts.AddProduct;
using CQRS.Contracts.AddProductQuantity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using CQRS.Infrastructure.Interfaces.Busses;
using System;

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

        static Guid ProductId = Guid.NewGuid(); 

        // GET api/values
        public IEnumerable<string> Get()
        {
            Debug.WriteLine("Hello World");

            CommandBus.Send(new AddProductCommand { AggregateId = ProductId, Name = "Hello World", InititalQuantity = 600m, Price = 12.32m });

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int quantity)
        {
            Debug.WriteLine("Hello World");

            CommandBus.Send(new AddProductQuantityCommand { AdditionalQuantity = quantity, AggregateId = ProductId });

            return "dasdas";
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
