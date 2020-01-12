﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace ThEvent.Models
{
    class Events
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
    }
}
