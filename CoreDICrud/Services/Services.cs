using CoreDICrud.Models;
using CoreDICrud.Repository;
using Microsoft.EntityFrameworkCore;

namespace CoreDICrud.Services
{
    public class Services : IUserRepository //inherit IUserRepository To Services For Accessing the Repository
    {
        public readonly CoreDiContext _Context; //object variable of context class //you can only read
        //Constructor Injection Applied
        public Services(CoreDiContext diContext) 
        { 
            _Context = diContext; 
        }
        public IEnumerable<TblUser> getAllUsers()
        {
            var coreDiContext = _Context.TblUsers.Include(t => t.City);//here we are applied eager loading
            return coreDiContext.ToList();
        }
    }
}
