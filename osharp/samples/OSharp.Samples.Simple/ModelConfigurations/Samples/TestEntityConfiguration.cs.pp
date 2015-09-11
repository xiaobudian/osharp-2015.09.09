using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using OSharp.Core.Data.Entity;
using $rootnamespace$.Models.Samples;

namespace $rootnamespace$.ModelConfigurations.Samples
{
    /// <summary>
    /// 实体类映射，数据层创建上下文时，将根据此配置把实体加载到上下文中
    /// </summary>
    public class TestEntityConfiguration : EntityConfigurationBase<TestInfo, int>
    {
        public TestEntityConfiguration()
        {
            //在这里配置实体属性限制及实体导航属性关系
            //HasKey(m => m.Id);
            //Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}