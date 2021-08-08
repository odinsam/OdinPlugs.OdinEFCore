using System;
using Microsoft.EntityFrameworkCore;
using OdinPlugs.OdinEFCore.EntityFrameworkExtensions.EFExtensions;
using OdinPlugs.OdinEFCore.EntityFrameworkExtensions.EFInterface;

namespace OdinPlugs.OdinEFCore.DBContext
{
    public class DBContextFactory
    {
        public static IBaseRepository<T> GetRepository<T>(DbContext _objectContext) where T : class, new()
        {
            return new BaseRepository<T>(_objectContext);
        }
    }
}