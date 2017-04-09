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
using Backend.API.Enties;
using Backend.API.Models;

namespace Backend.API.Controllers
{
    public class LegoPartsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/LegoParts
        public List<LegoPartDto> GetLegoParts()
        {
            var list = db.LegoParts.ToList();
            var result = AutoMapper.Mapper.Map<List<LegoPartDto>>(list);

            return result;
        }

        // GET: api/LegoParts/5
        [ResponseType(typeof(LegoPart))]
        public IHttpActionResult GetLegoPart(int id)
        {
            LegoPart legoPart = db.LegoParts.Find(id);
            if (legoPart == null)
            {
                return NotFound();
            }

            return Ok(legoPart);
        }

        // PUT: api/LegoParts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLegoPart(int id, LegoPart legoPart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != legoPart.Id)
            {
                return BadRequest();
            }

            db.Entry(legoPart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegoPartExists(id))
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

        // POST: api/LegoParts
        [ResponseType(typeof(LegoPart))]
        public IHttpActionResult PostLegoPart(LegoPart legoPart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LegoParts.Add(legoPart);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = legoPart.Id }, legoPart);
        }

        // DELETE: api/LegoParts/5
        [ResponseType(typeof(LegoPart))]
        public IHttpActionResult DeleteLegoPart(int id)
        {
            LegoPart legoPart = db.LegoParts.Find(id);
            if (legoPart == null)
            {
                return NotFound();
            }

            db.LegoParts.Remove(legoPart);
            db.SaveChanges();

            return Ok(legoPart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LegoPartExists(int id)
        {
            return db.LegoParts.Count(e => e.Id == id) > 0;
        }
    }
}