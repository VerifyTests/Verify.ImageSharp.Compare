static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageSharpCompare.RegisterComparers(threshold: 10);
        VerifierSettings.InitializePlugins();
    }
}
