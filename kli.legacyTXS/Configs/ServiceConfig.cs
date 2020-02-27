using System;
using System.Linq;

namespace kli.legacyTXS.Configs 
	{ 

	public class ServicesConfig
	{
		public const string Key = "services";
		public Service[] Services { get; private set; }

		public Service GetServiceConfig(string serviceName)
		{
			return Services.FirstOrDefault(s => s.ApiPackage.Equals(serviceName, StringComparison.OrdinalIgnoreCase)) 
				?? throw new ArgumentOutOfRangeException();
		}

		public class Service
		{
			public string ApiPackage { get; private set; }
			public string Startup { get; private set; }
			public string Endpoint { get; private set; }
			public string TlsPublicKeyFile { get; private set; }
		}
	}
}
