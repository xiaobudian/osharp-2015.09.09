using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using $rootnamespace$.Dtos.Samples;
using $rootnamespace$.Models.Samples;

namespace $rootnamespace$.Dtos
{
    /// <summary>
    /// DTO - 实体 映射配置类
    /// </summary>
    public class DtoMappers
    {
        public static void RegisterMappers()
        {
            Mapper.CreateMap<TestInfoDto, TestInfo>();
        }
    }
}