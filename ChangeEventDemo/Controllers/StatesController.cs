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
using ChangeEventDemo.DAL;
using ChangeEventDemo.Models;

namespace ChangeEventDemo.Controllers
{
    public class StatesController : ApiController
    {
        private CountryContext db = new CountryContext();

        // GET: api/States
        public IQueryable<States> GetStates()
        {
            return db.States;
        }

        // GET: api/States/5
        [ResponseType(typeof(States))]
        public IHttpActionResult GetStates(string id)
        {
            States states = db.States.Find(id);
            if (states == null)
            {
                return NotFound();
            }

            return Ok(states);
        }

        // PUT: api/States/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStates(string id, States states)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != states.StateId)
            {
                return BadRequest();
            }

            db.Entry(states).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatesExists(id))
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

        // POST: api/States
        [ResponseType(typeof(States))]
        public IHttpActionResult PostStates(States states)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.States.Add(states);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (StatesExists(states.StateId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = states.StateId }, states);
        }

        // DELETE: api/States/5
        [ResponseType(typeof(States))]
        public IHttpActionResult DeleteStates(string id)
        {
            States states = db.States.Find(id);
            if (states == null)
            {
                return NotFound();
            }

            db.States.Remove(states);
            db.SaveChanges();

            return Ok(states);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StatesExists(string id)
        {
            return db.States.Count(e => e.StateId == id) > 0;
        }
    }
}