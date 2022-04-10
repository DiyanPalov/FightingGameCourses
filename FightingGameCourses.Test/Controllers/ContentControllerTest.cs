using FightingGameCourses.Controllers;
using MyTested.AspNetCore.Mvc;
using Xunit;

namespace FightingGameCourses.Test.Controllers
{
   public class ContentControllerTest
    {
        [Theory]
       [InlineData (1)]
        public void IndexShouldReturnView(int categoryItemId)
      => MyController<ContentController>
      .Instance()
      .Calling(c => c.Index(categoryItemId))
      .ShouldReturn().View();
    }
}
