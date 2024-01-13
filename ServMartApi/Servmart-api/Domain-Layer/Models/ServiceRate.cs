namespace Domain_Layer.Models
{
    public class ServiceRate
    {
        public Guid ID { get; set; }
        public Guid ServiceID { get; set; }
        public string Message { get; set; }
        public float NominateToOthers { get; set; }
        public float WorkQuality { get; set; }
        public float RespectDeliveryTime { get; set; }
               
        public virtual User User { get; set; }
        public virtual Service Service { get; set; }
    }
}
