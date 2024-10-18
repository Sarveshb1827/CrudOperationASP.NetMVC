using CoreDICrud.Models;

namespace CoreDICrud.Repository
{
    public interface IUserRepository
    {
        public IEnumerable<TblUser> getAllUsers();
    }
}
