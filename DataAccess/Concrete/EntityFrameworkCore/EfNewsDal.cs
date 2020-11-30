using Core.DataAccess.EntityFrameworkCore;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfNewsDal : EfEntityRepositoryBase<News, NewsDbContext>, INewsDal
    {

    }
}
