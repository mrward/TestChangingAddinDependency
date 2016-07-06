
using MonoDevelop.Components.Commands;
using MonoDevelop.Core;
using MonoDevelop.Ide;

namespace TestChangingAddinDependency
{
	public class StartupHandler : CommandHandler
	{
		protected override void Run ()
		{
			LoggingService.LogInfo ("TestChangingAddinDependency - startup handler run");
		}
	}
}

