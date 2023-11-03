namespace N63hometask.Entities
{
    public class StorageFile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public User UserId { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
