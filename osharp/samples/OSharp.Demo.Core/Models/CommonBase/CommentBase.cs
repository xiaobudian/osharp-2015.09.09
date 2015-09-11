using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leliao.web.Models
{
    public abstract class CommentBase : EntityBase
    {
        public string userName { get; set; }
        public string displayName { get; set; }
        public string content { get; set; }
        public int praise { get; set; }
    }
}