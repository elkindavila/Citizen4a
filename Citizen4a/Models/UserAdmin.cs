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
                throw new ArgumentException("Ingrese el password");
            context.Users.Add(user);
            context.SaveChanges();
        }

        public IEnumerable<Users> GetUsers()
        {
            return context.Users;
        }

        public void EliminarUsuario(int id)
        {
            var usuario = context.Users.FirstOrDefault(x => x.IdUsers==id);
            if (usuario != null)
            {
                context.Users.Remove(usuario);
                context.SaveChanges();
            }

        }

        public void ModificarUsuario(Users usuario, int id)
        {
            if (string.IsNullOrEmpty(usuario.LoginUsers))
                throw new ArgumentException("Debe ingresar un nombre de usuario");
            if (String.IsNullOrEmpty(usuario.PassUsers))
                throw new ArgumentException("Ingrese el password");
            var userbd = context.Users.FirstOrDefault(x => x.IdUsers == id);

            if (userbd!=null)
            {
                userbd.LoginUsers = usuario.LoginUsers;
                userbd.PassUsers = usuario.PassUsers;

                context.SaveChanges();
            }
        }

        public Users GetUsuarioById(int id)
        {
            var userbd = context.Users.FirstOrDefault(x => x.IdUsers == id);
            if (userbd!=null)
            {
                return userbd;
            }
            else
            {
                throw new ArgumentException("Usuario no encontrado");
            }
        }
    }
}
