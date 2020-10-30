using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AnimalShelter.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

  //  [HttpGet("Random")]
  //   public ActionResult<Cat> Random()
  //   {
  //     int countCatList = _db.Cats.Count();

  //     Random rand = new Random();
  //     int r = rand.Next(1, countCatList);
  //     // var randomCat = countCatList[r];
  //     return Ok(r); 
  //   }

  [HttpGet("Random")]
  public async Task<ActionResult<Cat>> Random()
  {
    using(HttpClient client = new HttpClient())
    {
      var result = await client.GetAsync("https://localhost:5000/api/cats/random");
      if (result.IsSuccessStatusCode)
      {
        var catListString = await result.Content.ReadAsStringAsync();
        var catList = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Cat>>(catListString);
        return catList.ElementAt(new Random().Next(0, catList.Count() - 1));
      }
      else
      {
        return NotFound();
      }
    }
  }


    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(string breed, string gender, string name, int page, int size)
    {
      var query = _db.Cats.AsQueryable();

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (page != 0)
      {
        if (size !=0 )
        {
        }
        else {
          size = 2;
        }
        var entries = query.OrderBy(o => o.Name).Skip((page - 1) * size).Take(size).ToList();
        query = entries.AsQueryable();
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
      return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Cat cat)
    {
      cat.CatId = id;
      _db.Entry(cat).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var catToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId == id);
      _db.Cats.Remove(catToDelete);
      _db.SaveChanges();
    }
  }
}