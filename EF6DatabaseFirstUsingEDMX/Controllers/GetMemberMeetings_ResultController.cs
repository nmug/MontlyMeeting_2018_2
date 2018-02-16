using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF6DatabaseFirstUsingEDMX.DAL.EDMX;

namespace EF6DatabaseFirstUsingEDMX.Controllers
{
    public class GetMemberMeetings_ResultController : Controller
    {
        private NMUGMeetingsEntities1 db = new NMUGMeetingsEntities1();

        // GET: GetMemberMeetings_Result
        public ActionResult Index()
        {
            //return View(await db.GetMemberMeetings_Result.ToListAsync());
            return View(db.Database.SqlQuery<GetMemberMeetings_Result>("GetMemberMeetings").ToList());

        }

        // GET: GetMemberMeetings_Result/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetMemberMeetings_Result getMemberMeetings_Result = await db.GetMemberMeetings_Result.FindAsync(id);
            if (getMemberMeetings_Result == null)
            {
                return HttpNotFound();
            }
            return View(getMemberMeetings_Result);
        }

        // GET: GetMemberMeetings_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GetMemberMeetings_Result/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EmailAddress,Name,Description,FirstName,LastNAme")] GetMemberMeetings_Result getMemberMeetings_Result)
        {
            if (ModelState.IsValid)
            {
                db.GetMemberMeetings_Result.Add(getMemberMeetings_Result);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(getMemberMeetings_Result);
        }

        // GET: GetMemberMeetings_Result/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetMemberMeetings_Result getMemberMeetings_Result = await db.GetMemberMeetings_Result.FindAsync(id);
            if (getMemberMeetings_Result == null)
            {
                return HttpNotFound();
            }
            return View(getMemberMeetings_Result);
        }

        // POST: GetMemberMeetings_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EmailAddress,Name,Description,FirstName,LastNAme")] GetMemberMeetings_Result getMemberMeetings_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(getMemberMeetings_Result).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(getMemberMeetings_Result);
        }

        // GET: GetMemberMeetings_Result/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetMemberMeetings_Result getMemberMeetings_Result = await db.GetMemberMeetings_Result.FindAsync(id);
            if (getMemberMeetings_Result == null)
            {
                return HttpNotFound();
            }
            return View(getMemberMeetings_Result);
        }

        // POST: GetMemberMeetings_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            GetMemberMeetings_Result getMemberMeetings_Result = await db.GetMemberMeetings_Result.FindAsync(id);
            db.GetMemberMeetings_Result.Remove(getMemberMeetings_Result);
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
