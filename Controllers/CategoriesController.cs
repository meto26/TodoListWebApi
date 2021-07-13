using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApi.Data;
using TodoApi.Models;
using TodoApi.ViewModels;

namespace TodoApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase //Wiev desteği olmayacak
    {
        private readonly TodoContext _context;
        public CategoriesController(TodoContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Category>> GetList()
        {
            return _context.Categories.ToList();
        }

        /// <summary>
        /// Veri alma işlemi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Veri ekleme işlemi
        /// </summary>
        /// <param name="model"></param>
        [HttpPost]
        public void Post([FromBody] CategoryViewModel model)
        {
            _context.Categories.Add(new Category
            {
                Name = model.Name
            });
            _context.SaveChanges();
        }

        /// <summary>
        /// Güncelleme işlemi
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        [HttpPut("{id}")]
        public void Put([FromRoute]int id, [FromBody] CategoryViewModel model)
        {
        }

        /// <summary>
        ///Silme işlemi
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
        