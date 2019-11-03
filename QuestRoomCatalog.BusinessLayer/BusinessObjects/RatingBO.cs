namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;


    public class RatingBO
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        public int RatingLevel { get; set; }

        public QuestsRoomsBO QuestsRooms { get; set; }
    }
}
