using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Contracts
{
    public interface ICommandHandler<in TCommand>
    {
        void Handle(TCommand command);
    }

    public interface ICommandHandler<in TCommand, out TReturn>
    {
        TReturn Handler(TCommand command);
    }
}
