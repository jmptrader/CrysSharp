﻿namespace CrysSharp.Core.Compiler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TextCharStream : ICharStream
    {
        private string text;
        private int position;

        public TextCharStream(string text)
        {
            this.text = text;
            this.position = 0;
        }

        public int NextChar()
        {
            if (this.position >= this.text.Length)
                return -1;

            return this.text[this.position++];
        }

        public void BackChar()
        {
            if (this.position > 0 && this.position <= this.text.Length)
                this.position--;
        }
    }
}
