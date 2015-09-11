using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leliao.web.Models
{
    public class NewsPraise : PraiseBase
    {
        public int NewsId { get; set; }
        public virtual News News { get; set; }
    }
}