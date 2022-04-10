using FightingGameCourses.Controllers;
using MyTested.AspNetCore.Mvc;
using Xunit;

namespace FightingGameCourses.Test.Controllers
{
   public class UserAuthControllerTest
    {
       
        [Theory]
        [InlineData("user")]
        public void IndexShouldReturnView(string returnUrl)
      => MyController<UserAuthController>
      .Instance()
      .Calling(c => c.Logout(returnUrl))
      .ShouldReturn().ActionResult();
    }
}
