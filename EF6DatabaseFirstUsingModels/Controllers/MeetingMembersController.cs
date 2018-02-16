using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF6DatabaseFirstUsingModels.DAL;

namespace EF6DatabaseFirstUsingModels.Controllers
{
    public class MeetingMembersController : Controller
    {
        private NMugEntities db = new NMugEntities();

        // GET: MeetingMembers
        public async Task<ActionResult> Index()
        {
            var meetingMembers = db.MeetingMembers.Include(m => m.Meeting).Include(m => m.Member);
            return View(await meetingMembers.ToListAsync());
        }

        // GET: MeetingMembers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingMember meetingMember = await db.MeetingMembers.FindAsync(id);
            if (meetingMember == null)
            {
                return HttpNotFound();
            }
            return View(meetingMember);
        }

        // GET: MeetingMembers/Create
        public ActionResult Create()
        {
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Name");
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "FirstName");
            return View();
        }

        // POST: MeetingMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MeetingId,MemberId,IsAttending,LastUpdated")] MeetingMember meetingMember)
        {
            if (ModelState.IsValid)
            {
                db.MeetingMembers.Add(meetingMember);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Name", meetingMember.MeetingId);
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "FirstName", meetingMember.MemberId);
            return View(meetingMember);
        }

        // GET: MeetingMembers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingMember meetingMember = await db.MeetingMembers.FindAsync(id);
            if (meetingMember == null)
            {
                return HttpNotFound();
            }
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Name", meetingMember.MeetingId);
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "FirstName", meetingMember.MemberId);
            return View(meetingMember);
        }

        // POST: MeetingMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MeetingId,MemberId,IsAttending,LastUpdated")] MeetingMember meetingMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meetingMember).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.MeetingId = new SelectList(db.Meetings, "MeetingId", "Name", meetingMember.MeetingId);
            ViewBag.MemberId = new SelectList(db.Members, "MemberId", "FirstName", meetingMember.MemberId);
            return View(meetingMember);
        }

        // GET: MeetingMembers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingMember meetingMember = await db.MeetingMembers.FindAsync(id);
            if (meetingMember == null)
            {
                return HttpNotFound();
            }
            return View(meetingMember);
        }

        // POST: MeetingMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MeetingMember meetingMember = await db.MeetingMembers.FindAsync(id);
            db.MeetingMembers.Remove(meetingMember);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
