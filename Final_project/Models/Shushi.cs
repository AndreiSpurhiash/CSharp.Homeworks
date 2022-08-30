﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Final_project.Models
{
    public class Sushi
    {
        public Guid _Id { get; set; }
        public int _Number { get; set; }
        public string _Name { get; set; }

        public double _Coast { get; set; }

        public string _Description { get; set; }

        public Sushi(int number, string name, double coast, string description)
        {
            _Id = Guid.NewGuid();
            _Number = number;
            _Name = name;
            _Coast = coast;
            _Description = description;
        }

        public override string ToString()
        {

            return string.Format($"{_Number,+6}\t\t{_Name,-44}\t{_Coast}\t\t{_Description}");
        }
    }
}
