using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsharp.Exceptions;

public class InvalidSenderRequestException : Exception
{
	public InvalidSenderRequestException() 
		: base("Footsharp.Error: The request information is invalid for executing the Sender.SendAsync() method") 
	{ }
}
