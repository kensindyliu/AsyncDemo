using Entities.ViewModels;
using EntityService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace FinalLab_ORM.Controllers
{
    public class AsyncTestController : Controller
    {

         
        public async Task<IActionResult> Index()
        {
            AsyncTest ats = new();
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            AsyncTestVM ts = new AsyncTestVM();
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Task<int> id = ats.GetID(); 
            Task<string> name = ats.GetName();
            Task<string> descriptiong = ats.GetDescription();
            Task<string> lastName = ats.GetLastName();
            await Task.WhenAll(id, name, descriptiong, lastName);
            ts.ID = id.Result;
            ts.Name=name.Result;
            ts.Description = descriptiong.Result;
            ts.LastName = lastName.Result;
            stopwatch.Stop();
            ViewBag.TimeConsumption = stopwatch.ElapsedMilliseconds;
            return View(ts);
        }
    }
}
