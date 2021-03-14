namespace Service.DTO
{
    public class MovieDTO : MovieSimpleDTO
    {
        public long Id { get; set; }
        public byte[] Image { get; set; }
    }
}
