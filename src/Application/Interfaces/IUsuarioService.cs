using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        void Add(ResponseCrearPersona usuario);
        IEnumerable<DtoUsuario> GetAll();
        DtoUsuario GetById(int id);
        void Update(Usuario usuario);
        void Delete(int id);
        public bool EmailExists(string email);
    }
}
