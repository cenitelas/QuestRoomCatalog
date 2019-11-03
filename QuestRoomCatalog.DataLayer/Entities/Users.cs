namespace QuestRoomCatalog.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string UserName { get; set; }

        public int RoleId { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
