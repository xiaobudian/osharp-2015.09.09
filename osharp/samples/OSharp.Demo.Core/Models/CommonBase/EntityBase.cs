using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leliao.web.Models
{
    public abstract class EntityBase
    {
        //新闻ID
        public int Id { get; set; }
        //创建时间
        public DateTime? createTime { get; set; }
    }
}