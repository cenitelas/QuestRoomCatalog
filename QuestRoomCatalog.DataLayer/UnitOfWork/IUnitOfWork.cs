using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestRoomCatalog.DataLayer;
using DataLayer.Repositories;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        Repository<Roles> RolesUowRepository { get; }
        Repository<Rating> RatingUowRepository { get; }
        Repository<Users> UsersUowRepository { get; }
        Repository<QuestsLogos> QuestsLogosUowRepository { get; }
        Repository<QuestsRooms> QuestsRoomsUowRepository { get; }

        //Repository<T> GenericUowRepository { get; }

        void Save();
    }
}
