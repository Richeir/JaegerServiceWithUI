using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaegerServiceWithUI.Models
{
	public class ResponseModel<T>
	{
		public T data { get; set; }

		public string errors { get; set; }

		public int limit { get; set; }

		public int offset { get; set; }

		public int total { get; set; }
	}
}
