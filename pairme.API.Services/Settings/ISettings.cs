using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Services.Settings
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	namespace relativityCalculator.Core.Contracts
	{
		public interface IAppSettings
		{
			string ConnectionString { get; set; }
		}
		public class AppSettings : IAppSettings
		{
			public string ConnectionString { get; set; }
		}
	}

}
