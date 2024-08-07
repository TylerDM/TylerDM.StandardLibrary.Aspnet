namespace TylerDM.StandardLibrary.Aspnet.StaticFiles;

public static class FileExtensionContentTypeProviderExt
{
	public static string Get(this FileExtensionContentTypeProvider provider, string extension)
	{
		if (provider.TryGetContentType(extension, out var contentType))
			return contentType;
		return "application/octet-stream";
	}
}
