﻿namespace CrysSharp.Core.Tests.Compiler
{
    using System;
    using CrysSharp.Core.Compiler;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LexerTests
    {
        [TestMethod]
        public void NullToken()
        {
            Lexer lexer = new Lexer(string.Empty);

            Assert.IsNull(lexer.NextToken());
        }

        [TestMethod]
        public void GetName()
        {
            Lexer lexer = new Lexer("foo");

            var token = lexer.NextToken();

            Assert.IsNotNull(token);
            Assert.AreEqual(TokenType.Name, token.Type);
            Assert.AreEqual("foo", token.Value);

            Assert.IsNull(lexer.NextToken());
        }

        [TestMethod]
        public void GetNameWithSpaces()
        {
            Lexer lexer = new Lexer("  foo   ");

            var token = lexer.NextToken();

            Assert.IsNotNull(token);
            Assert.AreEqual(TokenType.Name, token.Type);
            Assert.AreEqual("foo", token.Value);

            Assert.IsNull(lexer.NextToken());
        }

        [TestMethod]
        public void GetNames()
        {
            Lexer lexer = new Lexer("foo bar");

            var token = lexer.NextToken();

            Assert.IsNotNull(token);
            Assert.AreEqual(TokenType.Name, token.Type);
            Assert.AreEqual("foo", token.Value);

            token = lexer.NextToken();

            Assert.IsNotNull(token);
            Assert.AreEqual(TokenType.Name, token.Type);
            Assert.AreEqual("bar", token.Value);

            Assert.IsNull(lexer.NextToken());
        }
    }
}
