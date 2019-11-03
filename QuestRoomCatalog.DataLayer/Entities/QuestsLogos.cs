namespace QuestRoomCatalog.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestsLogos
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }

        //[Required]
        //[MaxLength(1)]
        public byte[] Image { get; set; }

        public bool IsLogo { get; set; }

        public virtual QuestsRooms QuestsRooms { get; set; }
    }
}
