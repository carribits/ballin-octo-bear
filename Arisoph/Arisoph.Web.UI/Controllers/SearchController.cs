﻿using Arisoph.DAL.Amazon.AWS;
using Arisoph.Web.Framework.Controllers;
using Arisoph.Web.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arisoph.Web.UI.Controllers
{
    public class SearchController : AnonymousController
    {

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection form)
        {
            if (Request.HttpMethod == "POST")
            {
                string query = form["query"].ToString();

                var products = ProductLoader.Load(query, "Electronics");
                var model = new SearchProduct() { Products = products };

                return Json(model);
            }

            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}