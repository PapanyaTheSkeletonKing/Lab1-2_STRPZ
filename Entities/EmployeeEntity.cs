﻿using Types;

namespace Entities
{
    public class EmployeeEntity : ISaveableEntity
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Speciality Speciality { get; set; }
        public int Age { get; set; }
    }
}