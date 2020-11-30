using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public async Task<Category> AddAsync(Category category)
        {
            return await _categoryDal.AddAsync(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public async Task DeleteAsync(Category category)
        {
            await _categoryDal.DeleteAsync(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(d => d.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            return await _categoryDal.UpdateAsync(category);
        }
    }
}
