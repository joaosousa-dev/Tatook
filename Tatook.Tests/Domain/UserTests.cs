using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;

namespace Tatook.Tests.Domain
{
    public class UserTests
    {
        [Fact(DisplayName = "Instantiate")]
        public void Instantiate()
        {
            //Arrange
            var validName = new Name("Jão victor", "de sousa oliveira");
            var validEmail = new Email("jvoliveiraplays@gmail.com");
            var validCompany = new Company("TARGET", "192.158.0.1:1100/image.png");

            //Act
            var user = new User(validName, validEmail, validCompany);

            //Assert
            Assert.Empty(validName.Notifications);
            Assert.Empty(validEmail.Notifications);
            Assert.Empty(validCompany.Notifications);
            Assert.Empty(user.Notifications);
        }

        [Fact]
        public void UpdateEmail()
        {
            //Arrange 
            var user = UserFixture.GetValid();
            //Act 
            user.UpdateEmail(new Email("jvoliveira06@gmail.com"));
            //Assert
            Assert.Empty(user.Email.Notifications);
            Assert.Empty(user.Notifications);
        }

        [Fact]
        public void UpdateEmail_ShouldReturnError_SameEmail()
        {
            //Arrange 
            var user = UserFixture.GetValid();

            //Act 
            user.UpdateEmail(new Email("jvoliveiraplays@gmail.com"));

            //Assert
            var emailNotification = user.Email.Notifications.First();
            Assert.Equal("New Email must be different than old email", emailNotification.Message);
        }
    }
}