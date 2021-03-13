namespace Service.DTO
{
    class MovieDTO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public byte[] Image { get; set; }
    }
}
