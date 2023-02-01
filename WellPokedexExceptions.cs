using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellPokedex
{
    [Serializable]
    public class WellPokedexException : Exception
    {
        public WellPokedexException() { }
        public WellPokedexException(string message) : base("Aconteceu uma Exceção -> " + message) { }
        public WellPokedexException(string message, Exception inner) : base(message, inner) { }
        protected WellPokedexException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
