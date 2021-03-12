using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class MovieImage
    {
        public long Id { get; set; }
        public byte[] Image { get; set; }
    }
}
