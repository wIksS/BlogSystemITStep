namespace BlogSystem.Data
{
    using BlogSystem.Data.Repositories;
    using BlogSystem.Models;

    public interface IBlogSystemData
    {
        IRepository<ApplicationUser> Users
        {
            get;
        }

        IRepository<Post> Posts
        {
            get;
        }

        IRepository<T> GetRepository<T>() where T:class;
    }
}
