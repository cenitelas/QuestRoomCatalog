namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;

    public class QuestsRoomsBO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TimeForQuest { get; set; }

        public int MaxGamer { get; set; }

        public int MinGamer { get; set; }

        public int MinAgeGamer { get; set; }

        public int FearLevel { get; set; }

        public int ComplexityLevel { get; set; }

    }
}
