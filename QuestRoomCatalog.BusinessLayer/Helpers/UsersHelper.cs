using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public class UsersHelper : ICrud<UsersBO>
    {
        UnitOfWork Db { get; set; }

        public UsersHelper(UnitOfWork uow)
        {
            Db = uow;
        }

        public void Create(UsersBO Bo)
        {
            if (Bo.Id == 0)
            {
                Users quest = AutoMapper<UsersBO, Users>.Map(Bo);
                Db.UsersUowRepository.Add(quest);
                Db.Save();
            }

        }
    }
}
