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
  public class DogsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet("Random")]
    public ActionResult<Dog> Random()
    {
      int countDogList = _db.Dogs.Count();

      Random rand = new Random();
      int r = rand.Next(1, countDogList);
      // var randomDog = countDogList[r];
      return Ok(r); 
    }

    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get(string breed, string gender, string name, int page, int size)
    {
      var query = _db.Dogs.AsQueryable();

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
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Dog> Get(int id)
    {
      return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Dog dog)
    {
      dog.DogId = id;
      _db.Entry(dog).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
      _db.Dogs.Remove(dogToDelete);
      _db.SaveChanges();
    }
  }
}