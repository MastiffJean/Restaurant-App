namespace DataLayer.DbLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Item
    {
        public int Id { get; set; }

        public int Good_Id { get; set; }

        public int Order_Id { get; set; }

        public virtual Good Good { get; set; }

        public virtual Order Order { get; set; }
    }
}
