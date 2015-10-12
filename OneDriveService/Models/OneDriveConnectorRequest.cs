using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneDriveService.Models
{
    public class OneDriveConnectorRequest
    {
        public string FileName { get; set; }
        public object FolderPath { get; set; }
        public object LastModifiedUtc { get; set; }
        public object FileSizeInBytes { get; set; }
        public string FilePath { get; set; }
    }
}