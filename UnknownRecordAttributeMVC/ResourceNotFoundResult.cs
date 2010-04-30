using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnknownRecord
{
    public class ResourceNotFoundResult : ActionResult
    {
        public string Message { get; private set; }

        public ResourceNotFoundResult()
        {
            Message = "The requested resource was not found";
        }

        public ResourceNotFoundResult(string message)
        {
            Message = message;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            throw new HttpException(404, Message);
        }
    }

}
