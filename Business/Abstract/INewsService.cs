using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsService
    {
        News Add(News news);
        Task<News> AddAsync(News news);
        News Update(News news);
        Task<News> UpdateAsync(News news);
        void Delete(News news);
        Task DeleteAsync(News news);
        News GetById(int id);
        List<News> GetList();
        List<News> GetListByCategoryId(int categoryId);
    }
}
