using ApiAuth.Models;

namespace ApiAuth.Repositoris
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {

                new () { Id=1, Username= "Batman", Password="batman123", Role="manager"},
                new () { Id=2, Username= "Robin", Password="melhorAmigoDoBatman", Role="employee"}

            };
            return users.FirstOrDefault(x => 
            x.Username == username
            && x.Password == password);
        }
    }
}
