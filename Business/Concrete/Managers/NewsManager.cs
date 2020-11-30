using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class NewsManager : INewsService
    {
        private INewsDal _newsDal;
        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public News Add(News news)
        {
            return _newsDal.Add(news);
        }

        public async Task<News> AddAsync(News news)
        {
            return await _newsDal.AddAsync(news);
        }

        public void Delete(News news)
        {
            _newsDal.Delete(news);
        }

        public async Task DeleteAsync(News news)
        {
            await _newsDal.DeleteAsync(news);
        }

        public News GetById(int id)
        {
            return _newsDal.Get(d => d.NewsID == id);
        }

        public List<News> GetList()
        {
            return _newsDal.GetAll();
        }

        public List<News> GetListByCategoryId(int categoryId)
        {
            return _newsDal.GetAll(d=> d.Category == categoryId);
        }

        public News Update(News news)
        {
            return _newsDal.Update(news);
        }

        public async Task<News> UpdateAsync(News news)
        {
            return await _newsDal.UpdateAsync(news);
        }
    }
}
