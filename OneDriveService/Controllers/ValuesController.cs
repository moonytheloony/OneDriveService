using OneDriveService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneDriveService.Controllers
{
    public class ValuesController : ApiController
    {
        private static OneDriveConnectorRequest[] files;

        // GET api/values
        public string Get()
        {
            var data = string.Empty;
            foreach (var value in files)
            {
                data += "File Name: " + value.FileName + ", ";
            }

            return data;
        }

        // GET api/values/5
        public OneDriveConnectorRequest Get(int id)
        {
            return files.ElementAtOrDefault(id);
        }

        // POST api/values
        public void Post([FromBody]OneDriveConnectorRequest[] value)
        {
            files = value;
        }
    }
}
