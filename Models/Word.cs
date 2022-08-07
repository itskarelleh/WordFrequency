using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordFrequency.Models
{
    public class Word
    {
        public String Value { get; set; }
        public int Frequency { get; set; }

        public Word(String value, int frequency)
        {
            this.Value = value;
            this.Frequency = frequency;
        }
    }
}