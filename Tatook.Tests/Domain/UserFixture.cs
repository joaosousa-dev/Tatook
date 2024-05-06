using Tatook.Domain.Entities.Companies;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.ValueObjects;

namespace Tatook.Tests.Domain
{
    public static class UserFixture
    {
        public static User GetValid() => new User(
            new Name("Joao", "Sousa"),
            new Email("jvoliveiraplays@gmail.com"),
            new Company("JsousaCompany", null)
            );
    }
}
