﻿using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
