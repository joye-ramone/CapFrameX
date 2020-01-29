﻿using CapFrameX.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapFrameX.Data
{
	public class AppVersionProvider : IAppVersionProvider
	{
		private readonly Version _version;
		public AppVersionProvider()
		{
			_version = Assembly.GetEntryAssembly().GetName().Version;
		}
		public Version GetAppVersion()
		{
			return _version;
		}
	}
}
