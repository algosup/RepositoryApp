using System;
using System.Collections;
using System.Collections.Generic;
using DomainLayer;
using InfrastructureLayer;
using NSubstitute;
using NUnit.Framework;

namespace RightManagementTest
{
    public class RightManagementApplicationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(UsersWithEmptyHashedPassword))]
        public void Should_throw_exception_when_hashedpassword_is_empty(List<User> userList, string expectedResult)
        {
            // Act
            var dataLoader = Substitute.For<IDataLoader>();
            dataLoader.GetUsers().Returns(userList);
            var dataManager = new DataManager(dataLoader);
            
            // Asert
            var exception = Assert.Throws<Exception>(() => dataManager.GetUsers());
            if (exception != null) Assert.AreEqual(expectedResult, exception.Message);
        }

        private static IEnumerable UsersWithEmptyHashedPassword
        {
            get
            {
                yield return new TestCaseData(
                    new List<User>
                    {
                        new()
                        {
                            UserId = 10,
                            UserName = "Ivan",
                            HashedPassword = ""
                        },
                        new()
                        {
                            UserId = 12,
                            UserName = "Karine",
                            HashedPassword = "dfgvjnrgls"
                        },
                    }, "Error : The User Ivan has an empty password");
                
                yield return new TestCaseData(
                    new List<User>
                    {
                        new()
                        {
                            UserId = 10,
                            UserName = "Ivan",
                            HashedPassword = ""
                        },
                        new()
                        {
                            UserId = 12,
                            UserName = "Karine",
                            HashedPassword = ""
                        },
                    }, "Error : The Users Ivan,Karine have an empty password");

            }
        }
    }

    
}