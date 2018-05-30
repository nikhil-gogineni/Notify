namespace DomainModel.DTO
{
    public partial class MessageMedia
    {
        public long MessageMediaID { get; set; }
        public string MessageID { get; set; }
        public string Path { get; set; }
        public int MediaType { get; set; }
    
        public virtual Message Message { get; set; }
    }
}
