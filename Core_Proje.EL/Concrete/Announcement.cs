﻿using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class Announcement
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
    }
}
