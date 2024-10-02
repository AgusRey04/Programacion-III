using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        public void Add(Usuario usuario);
        public List<Usuario> GetAll();
        public void Update(Usuario usuario);
        public Usuario GetById(int Id);
    }
}