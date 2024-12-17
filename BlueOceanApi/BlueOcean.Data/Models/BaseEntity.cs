namespace BlueOcean.Data.Models
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        //DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
