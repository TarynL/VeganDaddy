using System.Collections.Generic;
using VeganDaddy.Models;

namespace VeganDaddy.Repositories
{
    public interface IUserProfileRepository
    {
        UserProfile GetByFirebaseUserId(string firebaseUserId);
        public List<UserProfile> GetAllUsers();

        UserProfile GetUserById(int id);
        void Add(UserProfile userProfile);


    }
}