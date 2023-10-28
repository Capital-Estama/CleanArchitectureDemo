using System;
namespace CleanArchitectureDemo.Domain.Common
{
	public abstract class BaseEvent : INotification 
	{
		public DateTime DateOccured { get; protected set; } = DateTime.UtcNow;
	}
}

