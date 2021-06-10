using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace ODataTest.Controllers
{
    public class ParentController : ODataController
    {
        private readonly DemoContext _context;

        public ParentController(DemoContext context)
        {
            _context = context;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Parent);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_context.Parent.FirstOrDefault(c => c.Id == key));
        }

        [EnableQuery]
        [HttpGet("/odata/Parent({key})/Childs")]
        public IActionResult GetChildsForParent(int key)
        {
            return Ok(SingleResult.Create(_context.Parent.Where(c => c.Id == key).Select(p => p.Childs)));
        }
    }
}