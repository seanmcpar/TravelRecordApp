﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TravelRecordApp.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
