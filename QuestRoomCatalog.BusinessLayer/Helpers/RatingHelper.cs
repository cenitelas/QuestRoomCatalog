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
    public class RatingHelper : ICrud<RatingBO>
        {
            UnitOfWork Db { get; set; }

            public RatingHelper(UnitOfWork uow)
            {
                Db = uow;
            }

            public void Create(RatingBO Bo)
            {
                if (Bo.Id == 0)
                {
                    Rating quest = AutoMapper<RatingBO, Rating>.Map(Bo);
                    Db.RatingUowRepository.Add(quest);
                    Db.Save();
                }

            }

        }
    }
