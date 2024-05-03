using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;

namespace Tatook.Tests.Domain
{
    public class UserTests
    {
        [Fact]
        public void Instantiate()
        {
            //Arrange
            var email = new Email("jvoliveiraplayscom");
            var nome = new Name("joao","sousa");
            var comp = new Company("teste","teste.png",DateTime.Today,DateTime.Today);
            //Act
            var user = new User(nome, email,comp);
            //Assert
            Assert.True(false);
        }
    }
}