using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using QuestRoomCatalog.BusinessLayer.Helpers;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;

namespace QuestRoomCatalog.Helpers
{
    public class NinjectHelper : NinjectModule
    {
        public override void Load()
        {
            Bind<ICrud<QuestsLogosBO>>().To<QuestLogosHelper>();
            Bind<ICrud<QuestsRoomsBO>>().To<QuestsRoomsHelper>();
            Bind<ICrud<RatingBO>>().To<RatingHelper>();
            Bind<ICrud<RolesBO>>().To<RolesHelper>();
            Bind<ICrud<UsersBO>>().To<UsersHelper>();
        }
    }
}