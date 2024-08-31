using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NutriFood.Models
{
    public class ProfileModel
    {
        private int id_profile;
        private string description;
        

        public int Id_profile
        { get { return id_profile; } set { id_profile = value; } }

        public string Description
        { get { return description; } set { description = value; } }
    }
}
