﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySkema.ModelLayer
{
    public class Skema
    {
        public List<Lecture> LectureList { get; set; }

        public Skema()
        {
           LectureList = new List<Lecture>();
        }
    }
}
