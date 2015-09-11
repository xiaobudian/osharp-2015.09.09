using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leliao.web.Models
{
    public abstract class PraiseBase : EntityBase
    {
        public string UserName { get; set; }
        public int Status { get; set; }
    }
}