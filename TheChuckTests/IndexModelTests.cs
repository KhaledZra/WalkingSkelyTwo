using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging.Abstractions;
using TheChuckTests.Fakes;
using TheChuck.Core;

namespace TheChuck.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        // [TestMethod()]
        // public async Task OnGet_ShouldDisplayTextFromService()
        // {
        //     //Arrange
        //     var joke = new Joke() { Value = "Works"};
        //     var sut = new IndexModel(NullLogger<IndexModel>.Instance, new JokeServiceFake(joke));
        //
        //     //Act
        //     await sut.OnGet();
        //
        //     //Assert
        //     Assert.AreEqual("Works", sut.DisplayText);
        // }

        [TestMethod()]
        public async Task OnGet_ShouldDisplayTextTryAgainWhenApiIsNotWorking()
        {
            //Arrange
            var sut = new IndexModel(NullLogger<IndexModel>.Instance, new JokeServiceBrokenFake());

            //Act
            await sut.OnGet();

            //Assert
            Assert.AreEqual("Något gick fel. Försök igen lite senare.", sut.DisplayText);
        }


         [TestMethod()]
         public async Task OnGet_ShouldBeUppecase()
         {
             //Arrange
             var joke = new Joke() { Value = "Works"};
             var pageModel = new IndexModel(NullLogger<IndexModel>.Instance, new JokeServiceFake(joke));

             //Act
             await pageModel.OnGet();

             //Assert
             Assert.AreEqual("Works", pageModel.DisplayText);
         }

    }
}