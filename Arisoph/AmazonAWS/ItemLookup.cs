
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace Arisoph.DAL.Amazon.AWS
{
   public class ItemLookup
    {
        private const string MY_AWS_ACCESS_KEY_ID = "AKIAIYMSGU5E5OTDRTYA";
        private const string MY_AWS_SECRET_KEY = "0+4OSlMtGPyACUm6AcDJ[656remove51465]khG0HNzTQWx3IVhhz4mJ";
        private const string DESTINATION          = "ecs.amazonaws.com";

        public static string GetURL(string keyword, string category)
        {
            SignedRequestHelper helper = new SignedRequestHelper(MY_AWS_ACCESS_KEY_ID, MY_AWS_SECRET_KEY, DESTINATION);
            String requestUrl;

            IDictionary<string, string> r1 = new Dictionary<string, String>();
            r1["Service"] = "AWSECommerceService";
            r1["Version"] = "2011-08-01";
            r1["AssociateTag"] = "httpzerokilow-20";
            r1["ResponseGroup"] = "ItemAttributes";
            r1["MerchantId"] = "All";
            r1["Operation"] = "ItemSearch";
            r1["Availability"] = "Available";
            r1["Condition"] = "All";
            r1["SearchIndex"] = category;
            r1["Keywords"] = keyword;
            r1["Sort"] = "reviewrank";
            r1["ItemPage"] = "1";

            requestUrl = helper.Sign(r1);
            return requestUrl;
        }
    }
}
