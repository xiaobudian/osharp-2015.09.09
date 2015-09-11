using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OSharp.Core.Data;

namespace OSharp.Samples.Simple.Dtos.Samples
{
    public class TestInfoDto : IAddDto, IEditDto<int>
    {
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        [Required, StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 描述
        /// </summary>
        public string Remark { get; set; }

    }
}