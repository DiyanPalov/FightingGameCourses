using FightingGameCourses.Controllers;
using MyTested.AspNetCore.Mvc;
using Xunit;

namespace FightingGameCourses.Test.Controllers
{
  public class CategoriesToUserControllerTest
    {
        [Fact]
        public void IndexShouldReturnView()
            => MyController<CategoriesToUserController>
            .Instance()
            .Calling(c => c.Index())
            .ShouldReturn().View();
    }
}
