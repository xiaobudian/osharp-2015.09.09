using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OSharp.Core.Data;

namespace OSharp.Samples.Simple.Models.Samples
{
    /// <summary>
    /// 实体类 - 测试实体信息
    /// </summary>
    public class TestInfo : EntityBase<int>, ICreatedTime
    {
        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        [Required, StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 描述
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 获取设置 信息创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
}