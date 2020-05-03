using System;
namespace ShoppingCart.Project.Datas
{
    public class SessionDataModel
    {
        public long Id { get; set; }
        public Guid SessionId { get; set; }
        public string CustomerHashId { get; set; }
        public int CartId { get; set; }
        public DateTime SessionStartDate { get; set; }
        public DateTime SessionEndDate { get; set; }
    }

}