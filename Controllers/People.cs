using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using personListingsAPI.Servises;

namespace personListingsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class People : ControllerBase
    {
        private readonly MongoService mongo;
        private readonly IMongoCollection<People> people;

        public People(MongoService mongo)
        {
            this.mongo = mongo;
            people = mongo.GetCollection<People>("people");
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(people.Find(p => true).ToList());
        }

    }

}
