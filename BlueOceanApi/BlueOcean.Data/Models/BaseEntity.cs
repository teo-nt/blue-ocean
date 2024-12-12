namespace BlueOcean.Data.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        //DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
