using System;
using MonoDevelop.Projects;
using MonoDevelop.UnitTesting;

namespace TestChangingAddinDependency
{
	public class TestProvider : ITestProvider
	{
		public UnitTest CreateUnitTest (WorkspaceObject entry)
		{
			return null;
		}

		public void Dispose ()
		{
			
		}
	}
}

