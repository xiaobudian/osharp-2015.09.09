using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leliao.web.Models
{
    public abstract class ShareBase : EntityBase
    {
        public string userName { get; set; }
        public string to { get; set; }
        public string shareId { get; set; }
    }
}