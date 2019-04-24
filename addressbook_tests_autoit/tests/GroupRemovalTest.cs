using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        public Random rnd = new Random();
        public void RemoveGroup()
        { 
        List<GroupData> oldGroups = app.Groups.GetGroupList();//Получем список имеющихся групп
            GroupData newGroup = null;//Создаём и инициализируем контейнер для хранения группы
            if (oldGroups.Count == 1)// Проверяем содержиме списка групп, если списиок содержит 1 группу
            {
                for (int i = 0; i < 4; i++)//То мы добавляем ещё 4(Так как в приложении запрещено удалять последнююгруппу)
                {
                    newGroup = new GroupData()
                    {
                        Name = "Test" + i
                    };
                    app.Groups.Add(newGroup);
                }
            }
            else if (oldGroups.Count == 0) //если списиок не содержит ни 1 группу
            {
                for (int i = 0; i < 4; i++)//То мы добавляем ещё 4(Так как в приложении запрещено удалять последнююгруппу)
                {
                    {
                        newGroup = new GroupData()
                        {
                            Name = "Test" + i
                        };
                        app.Groups.Add(newGroup);
                    }

                }
                
            }
            oldGroups = app.Groups.GetGroupList();//Получем список имеющихся групп
            app.Groups.RmoveGroup(rnd.Next(0, oldGroups.Count - 1));
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(newGroup);
            Assert.AreEqual(oldGroups, newGroups);
            oldGroups.Sort();
            newGroups.Sort();
        }
    }
}
