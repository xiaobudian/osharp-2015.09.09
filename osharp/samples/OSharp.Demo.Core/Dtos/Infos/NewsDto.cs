using leliao.web.Models;
using OSharp.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSharp.Demo.Dtos.Infos
{
    public class NewsDto : EntityCommon, IAddDto, IEditDto<int>
    {
        /// <summary>
        /// 新闻标题
        /// </summary>
        [Required]
        public string title { get; set; }
    }
}
