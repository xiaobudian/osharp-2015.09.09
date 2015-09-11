using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using OSharp.Samples.Simple.Dtos.Samples;
using OSharp.Samples.Simple.Models.Samples;

namespace OSharp.Samples.Simple.Dtos
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