using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoodGrooveBlaze.Models
{
    public class BandModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string link { get; set; }

        public byte[] pictureLocation { get; set; }

        public string info { get; set; }
    }
}
