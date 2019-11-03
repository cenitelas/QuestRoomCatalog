namespace QuestRoomCatalog.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rating")]
    public partial class Rating
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        public int RatingLevel { get; set; }

        public virtual QuestsRooms QuestsRooms { get; set; }
    }
}
