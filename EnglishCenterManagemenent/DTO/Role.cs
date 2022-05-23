using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterManagemenent.DTO
{
    public class Role
    {
        private int roleID;
        private string name;
        private string description;

        public Role(DataRow row)
        {
            RoleID = (int)row["RoleID"];
            Name = (string)row["Name"];
            Description = (string)row["Description"];
        }

        public int RoleID { get => roleID; set => roleID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
