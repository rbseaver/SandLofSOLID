using System;

namespace SOLID.Lib
{
	public class NotEnoughArmsException : Exception
	{
		public NotEnoughArmsException(string message) : base(message)
		{

		}
	}
}