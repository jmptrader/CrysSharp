﻿namespace CrysSharp.Core.Expressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConstantExpression : IExpression
    {
        private object value;

        public ConstantExpression(object value)
        {
            this.value = value;
        }

        public object Value { get { return this.value; } }
    }
}
