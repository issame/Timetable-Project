﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySkema.ModelLayer
{
    public class Kursus
    {
        public string KursusKode { get; private set; }
        public string KursusName { get; private set; }
        public List<Hold> HoldObjs { get; private set; }
        public Laerer LaererObj { get; private set; }
        public int ModuleCount { get; private set; }

        public Kursus(string code, string name, int moduleCount, List<string> holdCodes, string teacherCode, IMoodle moodle)
        {
            this.KursusKode = code;
            this.KursusName = name;
            this.HoldObjs = new List<Hold>();
            foreach (string holdCode in holdCodes)
                this.HoldObjs.Add(moodle.LookupHold(holdCode));
            this.ModuleCount = moduleCount;
            this.LaererObj = moodle.LookupTeacher(teacherCode);
        }

        public override string ToString()
        {
            return string.Format("Kursus - Code: {0}, Name: {1}, Teacher: {2}, ModuleCount: {3}, Hold: {4}", KursusKode, KursusName, LaererObj.LaererKode, ModuleCount, string.Join(", ", HoldObjs.Select(h => h.HoldCode)));
        }
    }
}
