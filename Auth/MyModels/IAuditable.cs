namespace Auth.MyModels
{
    public interface IAuditable
    {
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set;}
        public DateTimeOffset DeletedDate { get; set; }
        public bool IsDeleted { get; set;}
    }
}
