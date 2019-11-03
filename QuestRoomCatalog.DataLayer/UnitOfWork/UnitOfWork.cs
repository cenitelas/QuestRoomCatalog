using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer.Repositories;
using QuestRoomCatalog.DataLayer;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private Model1 db;
        private bool disposed = false;
        Repository<QuestsLogos> _questsLogosUowRepository;
        //Repository<T> _genericRepository;

        public UnitOfWork()
        {
            db = new Model1();
        }


        public Repository<QuestsLogos> QuestsLogosUowRepository
        {
            get
            {
                if (this._questsLogosUowRepository == null)
                    _questsLogosUowRepository = new Repository<QuestsLogos>(db);
                return _questsLogosUowRepository;
            }
        }

        public Repository<Roles> RolesUowRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Repository<Rating> RatingUowRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Repository<Users> UsersUowRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Repository<QuestsRooms> QuestsRoomsUowRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //public Repository<Books> BookUowRepository
        //{
        //    get
        //    {
        //        if (this._bookUowRepository == null)
        //            _bookUowRepository = new Repository<Books>(db);
        //        return _bookUowRepository;
        //    }
        //}

        //public Repository<User> UserUowRepository
        //{
        //    get
        //    {
        //        if (this._userUowRepository == null)
        //            _userUowRepository = new Repository<User>(db);
        //        return _userUowRepository;
        //    }
        //}

        //public Repository<Rent> RentUowRepository
        //{
        //    get
        //    {

        //        if (this._rentUowRepository == null)
        //            _rentUowRepository = new Repository<Rent>(db);
        //        return _rentUowRepository;
        //    }
        //}

        //public Repository<Genre> GenreUowRepository
        //{
        //    get
        //    {

        //        if (this._genreUowRepository == null)
        //            _genreUowRepository = new Repository<Genre>(db);
        //        return _genreUowRepository;
        //    }
        //}

        //public Repository<T> GenericUowRepository
        //{
        //    get
        //    {
        //        if (this._genericRepository == null)
        //            _genericRepository = new Repository<T>(db);
        //        return _genericRepository;
        //    }
        //}

        public void Save()
        {
            db.SaveChanges();
        }


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}