using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemNWF.Models
{
    public class BlobInfo
    {
        public BlobInfo(Stream Content, string ContentType)
        {
            this.Content = Content;
            this.ContentType = ContentType;
        }

        public Stream Content { get; set; }
        public string ContentType { get; set; }
    }
}
