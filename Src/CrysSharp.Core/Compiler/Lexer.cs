﻿namespace CrysSharp.Core.Compiler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Lexer
    {
        private string text;

        public Lexer(string text)
        {
            this.text = text;
        }

        public Token NextToken()
        {
            if (this.text == null || this.text.Length == 0)
                return null;

            var token = new Token(TokenType.Name, this.text.Trim());

            this.text = null;

            return token;
        }
    }
}
