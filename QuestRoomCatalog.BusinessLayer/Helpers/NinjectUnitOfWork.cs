using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using QuestRoomCatalog.DataLayer.UnitOfWork;

namespace QuestRoomCatalog.BusinessLayer.Helpers
{
    public class NinjectUnitOfWork : NinjectModule
    {

        string connection = string.Empty;
        public NinjectUnitOfWork(string conn)
        {
            connection = conn;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connection);
        }
    }
}
