using System;
using System.Collections.Generic;
using System.Text;

namespace Condominio.Exceptions
{
    class BancoException : Exception
    {
        public BancoException() 
            : base("Houve um erro ao acessar o banco de dados. Por favor, contate o fornecedor da aplicação. Nesse caso sua filha mesmo...rsrs") { }
        public BancoException(string message) : base(message) { }

        public BancoException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
