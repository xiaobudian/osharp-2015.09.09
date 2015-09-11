using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OSharp.Core;
using OSharp.Utility.Data;
using $rootnamespace$.Dtos.Samples;
using $rootnamespace$.Models.Samples;
using OSharp.SiteBase.Security;

namespace $rootnamespace$.Contracts
{
    /// <summary>
    /// 业务契约——测试模块（业务接口需继承于 IDependency接口，以便进行依赖注入）
    /// </summary>
    public interface ISamplesContract : ILifetimeScopeDependency
    {
        #region 测试信息业务

        /// <summary>
        /// 获取 测试信息查询数据集
        /// </summary>
        IQueryable<TestInfo> TestInfos { get; }

        /// <summary>
        /// 检查测试信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的测试信息编号</param>
        /// <returns>测试信息是否存在</returns>
        bool CheckTestInfoExists(Expression<Func<TestInfo, bool>> predicate, int id = 0);

        /// <summary>
        /// 添加测试信息信息
        /// </summary>
        /// <param name="dtos">要添加的测试信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult AddTestInfos(params TestInfoDto[] dtos);

        /// <summary>
        /// 更新测试信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的测试信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult EditTestInfos(params TestInfoDto[] dtos);

        /// <summary>
        /// 删除测试信息信息
        /// </summary>
        /// <param name="ids">要删除的测试信息编号</param>
        /// <returns>业务操作结果</returns>
        OperationResult DeleteTestInfos(params int[] ids);

        #endregion
		
        /// <summary>
        /// 获取 功能信息查询数据集
        /// </summary>
        IQueryable<Function> Functions { get; }

        /// <summary>
        /// 获取 实体数据信息查询数据集
        /// </summary>
        IQueryable<EntityInfo> EntityInfos { get; }
    }
}
