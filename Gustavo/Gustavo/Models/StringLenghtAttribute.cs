﻿using System;

namespace Gustavo.Models
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;

        public StringLenghtAttribute(int v, int MinimunLenght)
        {
            this.v = v;
            this.MinimunLenght = MinimunLenght;
        }

        public int MinimunLenght { get; set; }
    }
}