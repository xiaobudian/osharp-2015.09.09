//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace leliao.web.Models
{
    using System;
    using System.Collections.Generic;

    public partial class News : EntityCommon
    {
        public News()
        {
            //this.NewsComment = new HashSet<NewsComment>();
            //this.NewsShare = new HashSet<NewsShare>();
            //this.NewsPraise = new HashSet<NewsPraise>();
        }
        public Nullable<int> DissertationId { get; set; }

        //����
        public string title { get; set; }
        //����
        public string content { get; set; }
        //ר��������
        [DefaultValue(999)]
        public int topicOrder { get; set; }
        //������
        public int pv { get; set; }

        //�Ƿ���ǰ����ʾ 0 ��  1��ʾ
        public int isActive { get; set; }
        //public virtual Dissertation Dissertation { get; set; }
        //public virtual ICollection<NewsPraise> NewsPraise { get; set; }
        //public virtual ICollection<NewsComment> NewsComment { get; set; }
        //public virtual ICollection<NewsShare> NewsShare { get; set; }
    }
}