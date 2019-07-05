using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial.Behavioral_Patterns.Visitor
{
    abstract class Element

    {
        public abstract void Accept(IVisitor visitor);
    }
}
