using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Embedding;

namespace Nau.Simple.Maui.Core
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp(Action<MauiAppBuilder> additional = null)
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiEmbeddedApp<Application>()
				.UseMauiCommunityToolkit();

			additional?.Invoke(builder);
			return builder.Build();
		}
	}
}
