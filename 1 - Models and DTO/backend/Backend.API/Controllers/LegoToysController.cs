using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Backend.API.Entities;
using Backend.API.Models;

namespace Backend.API.Controllers
{
    public class LegoToysController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/LegoToys
        public List<LegoToyDto> GetLegoToys()
        {
            var toys = db.LegoToys.ToList();
            var list = AutoMapper.Mapper.Map<List<LegoToyDto>>(toys);

            return list;
        }

        // GET: api/LegoToys/5
        [ResponseType(typeof(LegoToy))]
        public IHttpActionResult GetLegoToy(int id)
        {
            LegoToy legoToy = db.LegoToys.Find(id);
            if (legoToy == null)
            {
                return NotFound();
            }

            var toyDto = AutoMapper.Mapper.Map<LegoToyDto>(legoToy);

            return Ok(toyDto);
        }

        // PUT: api/LegoToys/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLegoToy(int id, LegoToyUpdateDto legoToyDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != legoToyDto.Id)
            {
                return BadRequest();
            }

            //TODO: adding parts creates new part items in DB, use automapper for collections or resolve parts manualy
            var lego = db.LegoToys.Find(id);
            AutoMapper.Mapper.Map(legoToyDto, lego);
            
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegoToyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LegoToys
        [ResponseType(typeof(LegoToyDto))]
        public IHttpActionResult PostLegoToy(LegoToyCreateDto legoToyDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var legoToy = AutoMapper.Mapper.Map<LegoToy>(legoToyDto);

            db.LegoToys.Add(legoToy);
            db.SaveChanges();

            var toyDto = AutoMapper.Mapper.Map<LegoToyDto>(legoToy);

            return CreatedAtRoute("DefaultApi", new { id = toyDto.Id }, toyDto);
        }

        // DELETE: api/LegoToys/5
        [ResponseType(typeof(LegoToy))]
        public IHttpActionResult DeleteLegoToy(int id)
        {
            LegoToy legoToy = db.LegoToys.Find(id);
            if (legoToy == null)
            {
                return NotFound();
            }

            db.LegoToys.Remove(legoToy);
            db.SaveChanges();

            return Ok(legoToy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LegoToyExists(int id)
        {
            return db.LegoToys.Count(e => e.Id == id) > 0;
        }
    }
}