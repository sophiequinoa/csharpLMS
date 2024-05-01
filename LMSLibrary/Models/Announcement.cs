﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Models
{
    public class Announcement
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }


        public Announcement(string title, string content, DateTime date)
        {
            Title = title;
            Content = content;
            Date = date;
        }
    }
}


