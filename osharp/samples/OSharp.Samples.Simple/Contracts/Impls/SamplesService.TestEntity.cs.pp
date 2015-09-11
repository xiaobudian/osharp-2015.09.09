using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using $rootnamespace$.Dtos.Samples;
using $rootnamespace$.Models.Samples;
using OSharp.Utility;
using OSharp.Utility.Data;
using OSharp.Utility.Extensions;

namespace $rootnamespace$.Contracts.Impls
{
	/// <summary>
	/// 业务实现——测试实体
	/// </summary>
    public partial class SamplesService
    {
        /// <summary>
        /// 获取 测试信息查询数据集
        /// </summary>
        public IQueryable<TestInfo> TestInfos
        {
            get { return TestInfoRepository.Entities; }
        }

        /// <summary>
        /// 检查测试信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的测试信息编号</param>
        /// <returns>测试信息是否存在</returns>
        public bool CheckTestInfoExists(Expression<Func<TestInfo, bool>> predicate, int id = 0)
        {
            predicate.CheckNotNull("predicate");
            return TestInfoRepository.CheckExists(predicate, id);
        }

        /// <summary>
        /// 添加测试信息信息
        /// </summary>
        /// <param name="dtos">要添加的测试信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public OperationResult AddTestInfos(params TestInfoDto[] dtos)
        {
            dtos.CheckNotNull("dtos");
            return TestInfoRepository.Insert(dtos,
                dto =>
                {
                    //数据合法性检查，插入时重复检查，不需要传Id
                    if (TestInfoRepository.CheckExists(m => m.Name == dto.Name))
                    {
                        throw new Exception("名称为“{0}”的测试信息已存在，不能重复添加".FormatWith(dto.Name));
                    }
                },
                (dto, entity) =>
                {
                    //这里可以做些创建导航属性的业务
					//本实体无导航属性，原样返回，或者本步骤可省略
                    return entity;
                });
        }

        /// <summary>
        /// 更新测试信息信息
        /// </summary>
        /// <param name="dtos">包含更新信息的测试信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public OperationResult EditTestInfos(params TestInfoDto[] dtos)
        {
            dtos.CheckNotNull("dtos");
            return TestInfoRepository.Update(dtos,
                dto =>
                {
                    //数据合法性检查，更新时重复检查，需要传入Id
                    if (TestInfoRepository.CheckExists(m => m.Name == dto.Name, dto.Id))
                    {
                        throw new Exception("名称为“{0}”的测试信息已存在，请更换".FormatWith(dto.Name));
                    }
                },
                (dto, entity) =>
                {
                    //这里可以做些更新导航属性的业务
                    //测试实体无导航属性，原样返回，或者本步骤可省略
                    return entity;
                });
        }

        /// <summary>
        /// 删除测试信息信息
        /// </summary>
        /// <param name="ids">要删除的测试信息编号</param>
        /// <returns>业务操作结果</returns>
        public OperationResult DeleteTestInfos(params int[] ids)
        {
            ids.CheckNotNull("ids" );
            return TestInfoRepository.Delete(ids,
                entity =>
                {
                    //这里可以做些验证实体是否可删除的业务
					//本实体无需验证，这里什么也不做
                },
                entity =>
                {
					//这里可以做些删除实体导航属性的业务
					//本实体无导航属性，原样返回，或者本步骤可省略
                    return entity;
                });
        }
    }
}