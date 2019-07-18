using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citizen4a.Models
{
    public class UserAdmin
    {
        db_citizen4Context context = new db_citizen4Context();

        public void AgregarUsuario(Users user)
        {
            if (string.IsNullOrEmpty(user.LoginUsers))
                throw new ArgumentException("Debe ingresar un nombre de usuario");
            if (String.IsNullOrEmpty(user.PassUsers))
                throw new ArgumentException("El password debe ser vacio");
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
