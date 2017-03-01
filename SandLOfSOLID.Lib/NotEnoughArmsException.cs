using System;

namespace SandLOfSOLID.Lib
{
	public class NotEnoughArmsException : Exception
	{
		public NotEnoughArmsException(string message) : base(message)
		{

		}
	}
}