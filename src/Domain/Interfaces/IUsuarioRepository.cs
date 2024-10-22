using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        void AddUser(Usuario usuario);
        IEnumerable<Usuario> GetUsers();
        Usuario GetUserById(int id);
        void UpdateUser(Usuario usuario);
        void DeleteUser(int id);
        public bool EmailExists(string email);
    }
}
