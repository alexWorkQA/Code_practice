using NUnit.Framework;
using CodePractice.NormalLevel;
using CodePractice.Models;
using System.Collections.Generic;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask26
    {
        static List<DataModelTask26> GenerateTestDataList()
        {
            List<DataModelTask26> userList = new List<DataModelTask26>();
            DataModelTask26 user1 = new DataModelTask26();
            user1.PhoneNumber = "12-00-23";
            user1.FirstName = "Alex";
            user1.AddressUser = "First av";
            userList.Add(user1);

            DataModelTask26 user2 = new DataModelTask26();
            user2.PhoneNumber = "20-20-20";
            user2.FirstName = "John";
            user2.AddressUser = "Second av";
            userList.Add(user2);


            DataModelTask26 user3 = new DataModelTask26();
            user3.PhoneNumber = "00-20-20";
            user3.FirstName = "Jim";
            user3.AddressUser = "Third av";
            userList.Add(user3);
            return userList;
        }


        static List<DataModelTask26> GenerateSortedTestDataList()
        {
            List<DataModelTask26> userList = new List<DataModelTask26>();
            DataModelTask26 user1 = new DataModelTask26();
            user1.PhoneNumber = "00-20-20";
            user1.FirstName = "Jim";
            user1.AddressUser = "Third av";
            userList.Add(user1);

            DataModelTask26 user2 = new DataModelTask26();
            user2.PhoneNumber = "12-00-23";
            user2.FirstName = "Alex";
            user2.AddressUser = "First av";
            userList.Add(user2);

            DataModelTask26 user3 = new DataModelTask26();
            user3.PhoneNumber = "20-20-20";
            user3.FirstName = "John";
            user3.AddressUser = "Second av";
            userList.Add(user3);

            return userList;
        }

        [Test]
        public void PositiveTestForTask26NormalSortUserList()
        {
            List<DataModelTask26> expectedResult = GenerateSortedTestDataList();
            List<DataModelTask26> actualResult = NormalLevelTask26.SortedListByPhoneNumber(GenerateTestDataList());

        }
    }
}
