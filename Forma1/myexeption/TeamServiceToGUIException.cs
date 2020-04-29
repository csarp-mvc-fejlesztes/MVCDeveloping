using System;
using System.Runtime.Serialization;

namespace Forma1.myexeption
{
    [Serializable]
    internal class TeamServiceToGUIException : Exception
    {
        public TeamServiceToGUIException()
        {
        }

        public TeamServiceToGUIException(string message) : base(message)
        {
        }

        public TeamServiceToGUIException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TeamServiceToGUIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}