﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsers();
        public void AddUser(Usuario usuario);
        public void UpdateUser(Usuario usuario);
        public Usuario GetByIdUser(int Id);
    

    }
}