using System.Collections.Generic;
using CodePractice.Models;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Напишите программу которая сортирует записи в порядке возрастания номера телефона.
    /// В текстовом файле находятся записи о номерах телефонов. В каждой строке записана информация: номер телефона, ФИО, адрес.
    /// </summary>
    public class NormalLevelTask26
    {
        public static List<DataModelTask26> SortedListByPhoneNumber(List<DataModelTask26> userList)
        {
            userList.Sort((a, b) => a.PhoneNumber.CompareTo(b.PhoneNumber));
            return userList;
        }
    }
}
