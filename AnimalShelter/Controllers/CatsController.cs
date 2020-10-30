using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System;

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

    [HttpGet("Random")]
    public ActionResult<IEnumerable<Cat>> Random()
    {
      var query = _db.Cats.AsQueryable(); //presents a list of Cats to "query"

      Random rand = new Random();
      int r = rand.Next(query.Count());
      var randomCat = query[r];
    
      return randomCat.ToList();
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

//  [HttpGet("Random")]
//     public ActionResult<Cat> Random()
//     {
//       var query = _db.Cats.Count();

//       Random rand = new Random();
//       int r = rand.Next(query);
//       // var randomCat = query[r];
//       string randomCat = r.ToString();
//       return Ok(randomCat); 
//     }