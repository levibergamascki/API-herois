﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        [ForeignKey("IdentityId")]
        public Guid FavHeroi { get; set; }
    }
}
