﻿using PracticumeServer.Core.Entites;

namespace PracticumeServer.API.Models
{
    public class EmployeePostModel
    {
       
        public string IDNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime EntryWorkDate { get; set; }
        public DateTime BirthDate { get; set; }
        public List<EmployeeRolePostModel> EmployeeRoles { get; set; }
    }
}
