namespace Domain.Interfaces.Repositories

{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int id);
        User GetUserByName(string name);
        void CreateUser(User User);
        void UpdateUser(User User);
        void DeleteUser(int id);
    }
}
