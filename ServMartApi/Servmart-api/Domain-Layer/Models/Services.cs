namespace Domain_Layer.Models
{
    public class Service
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public float Rate { get; set; }
        public decimal ExpectedSalary { get; set; }
        public Guid CategoryID { get; set; }
        public string ProviderID { get; set; }

        public virtual User User { get; set; }
        public virtual ServiceCategory ServiceCategory { get; set; }
        public virtual ICollection<ServiceRate> ServiceRates { get; set; }
        public virtual ICollection<ServiceMedia> ServiceMedia { get; set; }

	}
}
