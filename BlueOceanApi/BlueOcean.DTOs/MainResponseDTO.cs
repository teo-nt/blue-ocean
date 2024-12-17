
namespace BlueOcean.DTOs
{
    public class MainResponseDTO<T>
    {
        public T? Result {  get; set; }
        public string? Error { get; set; }
    }
}
