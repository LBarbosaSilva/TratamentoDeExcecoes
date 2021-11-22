using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_11___Exercicio_Proposto__excecoes_.Entitites.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string messege) : base(messege)
        {

        }
    }
}
