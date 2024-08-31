using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFood.Models
{
    public class UserModel
    {
        private int id_user;
        private string name;
        private string last_name;
        private string email;
        private string user_name;
        private string password;
        private int profile_id;
        private string deleted;

        public int Id_user
        { get { return id_user; } set { id_user = value; } }

        //[DisplayName ("Name")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Name
        { get { return name; } set { name = value; } }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido debe tener entre 3 y 50 caracteres")]
        public string LastName
        { get { return last_name; } set { last_name = value; } }

        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El correo debe tener entre 3 y 50 caracteres")]
        [EmailAddress]
        public string Email
        { get { return email; } set { email = value; } }

        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de usuario debe tener entre 3 y 15 caracteres")]
        public string UserName
        { get { return user_name; } set { user_name = value; } }

        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La contraseña debe tener entre 3 y 15 caracteres")]
        public string Password
        { get { return password; } set { password = value; } }

        public int ProfileId
        { get { return profile_id; } set { profile_id = value; } }

        public string Deleted
        { get { return deleted; } set { deleted = value; } }
    }
}
