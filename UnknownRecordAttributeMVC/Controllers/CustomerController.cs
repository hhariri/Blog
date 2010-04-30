using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Model;

namespace UnknownRecord.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerServices _customerServices = new CustomerServices(new CustomerDAO());

        [HandleError]
        public ActionResult DetailsHandleError(int id)
        {

            var customer = _customerServices.GetCustomerById(id);

            if (customer == null)
            {
                // Create own exception class
                throw new Exception("Resource not found");
            }
            return View("Details", customer);
        }
        

        public ActionResult Details(int id)
        {
            

            var customer = _customerServices.GetCustomerById(id);

            if (customer == null)
            {
                return new ResourceNotFoundResult();
            }
            return View(customer);
        }

        [HandleRecordNotFound]
        public ActionResult DetailsAttribute(int id)
        {
            var customer = _customerServices.GetCustomerById(id);
            
            return View("Details", customer);
        }
    }
}
