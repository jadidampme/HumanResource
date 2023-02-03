﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace HumanResourceAPI.Models
{
    public class AccountRole
    {
        public int Id { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        [ForeignKey("Account")]
        public string AccountNIK { get; set; }
        public Account Account { get; set; }
    }
}