namespace Domain.Entities.FSYS
{
    public class PermissionDto
    {
        public Permission Permission { get; set; }
        public string LockName { get; set; }
        public string LockGroupTitle { get; set; }
        public string OwnerName { get; set; }
        public int TotalCount { get; set; }
    }
}
