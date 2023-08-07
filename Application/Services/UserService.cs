namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //public async Task<User> GetUserById(Guid id)
        //{
        //    User result = await _userRepository.GetUserById(id);
        //    return result;
        //}

        //public async Task<User> GetUserByEmail(string email)
        //{
        //    User result = await _userRepository.GetUserByEmail(email);
        //    return result;
        //}

        //public async Task<List<User>> GetAllUsers()
        //{
        //    List<User> result = await _userRepository.GetAllUsers();
        //    return result;
        //}

        //public async Task<User> CreateUser(string name, string email)
        //{
        //    var user = new User
        //    {
        //        Name = name,
        //        Email = email
        //    };

        //    await _userRepository.CreateUser(user);
        //    return user;
        //}

        //public async Task DeleteUser(Guid id)
        //{
        //    await _userRepository.DeleteUser(id);
        //}

        //public async Task<User> UpdateUser(Guid id, string name)
        //{
        //    var user = await _userRepository.GetUserById(id);

        //    if (user == null)
        //    {
        //        throw new NotFoundException($"User with ID {id} not found.");
        //    }

        //    user.Name = name;
        //    await _userRepository.UpdateUser(user);
        //    return user;
        //}
    }

}
