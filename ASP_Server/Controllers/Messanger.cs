using Messenger;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messanger : ControllerBase
    {
        static List<Message> ListofMessages = new List<Message>();
        // GET: api/<Messanger>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Messanger>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not Found";
            if ((id < ListofMessages.Count) && (id >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListofMessages[id]);
            }
            
            return "Hochu v VDV" + id.ToString();
        }

        // POST api/<Messanger>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListofMessages.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщение: {1}", ListofMessages.Count, msg));
            //return new NoContentResult();
            return new OkResult();
        }

        // PUT api/<Messanger>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Messanger>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
