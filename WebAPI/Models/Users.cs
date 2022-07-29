using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Users
    {
        public string mobile { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string username { get; set; }

        public string user_pwd { get; set; }

        public string user_role { get; set; }

        public string email_id { get; set; }

        public bool active { get; set; }

        public string last_updated { get; set; }

        public string date_of_birth { get; set; }

    }
}
