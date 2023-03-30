﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UrlImagenPerfil { get; set; }
        // Para futuras modificacines
        public DateTime FechaNacimiento { get; set; }
        public bool Admin { get; set; }

        public User(string email, string pass, bool admin)
        {
            Email = email;
            Pass = pass;
            Admin = admin ? true : false;
        }
    }
}
