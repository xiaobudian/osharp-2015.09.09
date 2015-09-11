using leliao.web.Models;
using OSharp.Core.Data;
using OSharp.Demo.Contracts;
using OSharp.Demo.Dtos.Infos;
using OSharp.Utility.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSharp.Utility.Extensions;
using OSharp.Core.Data.Entity;

namespace OSharp.Demo.Services
{
    public class NewsService : INewsContract
    {
        public IRepository<News, int> NewsRepository { protected get; set; }
        public IQueryable<leliao.web.Models.News> News
        {
            get { return NewsRepository.Entities; }
        }

        public bool CheckRoleExists(System.Linq.Expressions.Expression<Func<leliao.web.Models.News, bool>> predicate, int id = 0)
        {
            return NewsRepository.CheckExists(predicate, id);
        }

        public OperationResult Add(params Dtos.Infos.NewsDto[] dtos)
        {
            return NewsRepository.Insert(dtos,
                dto =>
                {
                    if (dto.title.Trim().IsNullOrEmpty())
                    {
                        throw new Exception("新闻标题不能为空！");
                    }
                },
               null);
        }

        public Utility.Data.OperationResult Edit(params Dtos.Infos.NewsDto[] dtos)
        {
            throw new NotImplementedException();
        }

        public Utility.Data.OperationResult Delete(params int[] ids)
        {
            throw new NotImplementedException();
        }
    }
}
