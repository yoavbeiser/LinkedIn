using System;
namespace LinkedIn
{
	public class ConnectionNotFound : Exception
	{
		public ConnectionNotFound(string message) : base(message)
		{
		}
	}
}

