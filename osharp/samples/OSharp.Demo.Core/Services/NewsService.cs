using leliao.web.Models;
using OSharp.Core.Data;
using OSharp.Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public Utility.Data.OperationResult AddRoles(params Dtos.Infos.NewsDto[] dtos)
        {
            throw new NotImplementedException();
        }

        public Utility.Data.OperationResult EditRoles(params Dtos.Infos.NewsDto[] dtos)
        {
            throw new NotImplementedException();
        }

        public Utility.Data.OperationResult DeleteRoles(params int[] ids)
        {
            throw new NotImplementedException();
        }
    }
}
