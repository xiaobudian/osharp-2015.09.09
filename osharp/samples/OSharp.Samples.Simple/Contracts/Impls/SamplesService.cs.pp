using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using OSharp.Core.Data;
using $rootnamespace$.Models.Samples;
using OSharp.SiteBase.Security;

namespace $rootnamespace$.Contracts.Impls
{
    /// <summary>
    /// 业务实现——测试模块
    /// </summary>
    public partial class SamplesService : ISamplesContract
    {
        /// <summary>
        /// 获取或设置 测试信息仓储对象（这里由依赖注入赋值）
        /// </summary>
        public IRepository<TestInfo, int> TestInfoRepository { protected get; set; }

        /// <summary>
        /// 获取或设置 功能信息仓储对象
        /// </summary>
        public IRepository<Function, Guid> FunctionRepository { protected get; set; }

        /// <summary>
        /// 获取或设置 实体数据信息仓储对象
        /// </summary>
        public IRepository<EntityInfo,Guid> EntityInfoRepository { protected get; set; }

        /// <summary>
        /// 获取 功能信息查询数据集
        /// </summary>
        public IQueryable<Function> Functions
        {
            get { return FunctionRepository.Entities; }
        }

        /// <summary>
        /// 获取 实体数据信息查询数据集
        /// </summary>
        public IQueryable<EntityInfo> EntityInfos
        {
            get { return EntityInfoRepository.Entities; }
        }
    }
}