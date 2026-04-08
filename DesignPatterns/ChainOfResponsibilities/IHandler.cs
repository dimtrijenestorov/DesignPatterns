using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilities
{
    public interface IHandler
    {
        IHandler SetNext(IHandler next);
        object Handle(object request);
    }
}
