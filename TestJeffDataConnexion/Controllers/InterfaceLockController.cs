
using System.Collections.Generic;
using System.Web.Mvc;
using TestJeffDataConnexion.Models;

namespace TestJeffDataConnexion.Controllers
{
    public class InterfaceLockController : Controller
    {
        // GET: InterfaceBlock
        public ActionResult _LoginLock()
        {
            List<LoginLock> LockLoginIpList2 = DAODelete.GetLockList();

            return View(LockLoginIpList2);
        }


        [HttpPost]
        // GET: InterfaceBlock/Delete/5
        public ActionResult Delete(string Value, string Type)
        {
            
            DAODelete.Delete(Type,Value);
            return RedirectToAction("_LoginLock");
        }
 
    }
  
}
