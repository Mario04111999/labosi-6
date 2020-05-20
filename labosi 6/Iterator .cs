﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_6
{
    //zadatak 1
    class Iterator : IAbstractIterator
    {
        private Notebook notebook;
        private int currentPosition;
        public Iterator(Notebook notebook)
        {
            this.notebook = notebook;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.notebook.Count; } }
        public Note Current { get { return this.notebook[this.currentPosition]; } }
        public Note First() { return this.notebook[0]; }
        public Note Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.notebook[this.currentPosition];
            }
        }
    }
}