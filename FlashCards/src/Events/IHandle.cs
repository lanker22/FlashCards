using System;
using System.Collections.Generic;
using System.Text;

namespace src.Events
{
    public interface IHandle<T>
    {
        public void Handle(T message);
    }
}
