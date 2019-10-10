using Microsoft.AspNetCore.Mvc;
using System;



namespace TestTaskMonolit.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class HttpNotFoundResult : ActionResult
    {
        private const int NotFoundCode = 404;

        //public override void ExecuteResult(ControllerContext context)
        //{
        //    if (context == null)
        //    {
        //        throw new ArgumentNullException("context");
        //    }

        //    context.HttpContext.Response.StatusCode = NotFoundCode;
        //}
    }

}