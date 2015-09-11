using OSharp.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace leliao.web.Models
{
    public abstract class EntityCommon : EntityBase<int>, ICreatedTime
    {
        //外链
        public string link { get; set; }
        //4:3封面url
        public string faceUrl43 { get; set; }
        //封面图片路径
        //16:9封面url
        public string faceUrl { get; set; }
        public bool canPraise { get; set; }
        public bool canComment { get; set; }
        public bool canShare { get; set; }
        public int UserId { get; set; }
        //推荐排序
        [DefaultValue(999)]
        public int recommendOrder { get; set; }
        //置顶排序
        [DefaultValue(999)]
        public int topOrder { get; set; }
        //状态
        public int status { get; set; }
        public bool deleted { get; set; }
        //是否置顶
        public bool istop { get; set; }
        //是否是推荐 轮播新闻
        public bool recommend { get; set; }
        //新闻简介
        public string description { get; set; }
        public int praise { get; set; }
        //来源
        public string source { get; set; }
        //新闻发生时间
        public DateTime? newsTime { get; set; }
        //送审时间
        public DateTime? preAuditTime { get; set; }
        //审核时间
        public DateTime? auditTime { get; set; }
        //创建者
        public string Creator { get; set; }
        //审核人
        public string Auditor { get; set; }
        //删除者
        public string DeleteBy { get; set; }
        //审批意见
        public string AuditSuggestion { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}