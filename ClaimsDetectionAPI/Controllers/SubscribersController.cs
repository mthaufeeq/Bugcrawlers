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
using ClaimsDetectionAPI.Models;

namespace ClaimsDetectionAPI.Controllers
{
    public class SubscribersController : ApiController
    {
        private SubscriberDBContext db = new SubscriberDBContext();

        // GET: api/Subscribers
        public IQueryable<ref_Subscribers> Getref_Subscribers()
        {
            return db.ref_Subscribers;
        }

        // GET: api/Subscribers/5
        [ResponseType(typeof(ref_Subscribers))]
        public IHttpActionResult Getref_Subscribers(int id)
        {
            ref_Subscribers ref_Subscribers = db.ref_Subscribers.Find(id);
            if (ref_Subscribers == null)
            {
                return NotFound();
            }

            return Ok(ref_Subscribers);
        }

        // PUT: api/Subscribers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putref_Subscribers(int id, ref_Subscribers ref_Subscribers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ref_Subscribers.SubscriberID)
            {
                return BadRequest();
            }

            db.Entry(ref_Subscribers).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ref_SubscribersExists(id))
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

        // POST: api/Subscribers
        [ResponseType(typeof(ref_Subscribers))]
        public IHttpActionResult Postref_Subscribers(ref_Subscribers ref_Subscribers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ref_Subscribers.Add(ref_Subscribers);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ref_Subscribers.SubscriberID }, ref_Subscribers);
        }

        // DELETE: api/Subscribers/5
        [ResponseType(typeof(ref_Subscribers))]
        public IHttpActionResult Deleteref_Subscribers(int id)
        {
            ref_Subscribers ref_Subscribers = db.ref_Subscribers.Find(id);
            if (ref_Subscribers == null)
            {
                return NotFound();
            }

            db.ref_Subscribers.Remove(ref_Subscribers);
            db.SaveChanges();

            return Ok(ref_Subscribers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ref_SubscribersExists(int id)
        {
            return db.ref_Subscribers.Count(e => e.SubscriberID == id) > 0;
        }
    }
}