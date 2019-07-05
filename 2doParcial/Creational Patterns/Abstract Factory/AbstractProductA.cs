using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial.Abstract_Factory
{
    abstract class AbstractProductA

    {
    }

    /// <summary>

    /// The 'AbstractProductB' abstract class

    /// </summary>

    abstract class AbstractProductB

    {
        public abstract void Interact(AbstractProductA a);
    }
}
