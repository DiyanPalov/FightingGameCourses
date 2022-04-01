using FightingGameCourses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FightingGameCourses.Data
{
   public interface IDataFunctions
    {
        Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd);
    }
}
