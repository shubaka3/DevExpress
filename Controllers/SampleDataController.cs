using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DXWebApplication1.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;

namespace DXWebApplication1.Controllers {
    public class SampleDataController : ApiController {

        //[HttpGet]
        //public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
        //    return Request.CreateResponse(DataSourceLoader.Load(SampleData.Orders, loadOptions));
        //}
        [HttpGet]
        //[Route("web/")]
        public HttpResponseMessage GetWebsiteContent(DataSourceLoadOptions loadOptions)
        {
            var websiteContent = SampleData.Websites;

            return Request.CreateResponse(DataSourceLoader.Load(websiteContent, loadOptions));
        }



    }
}