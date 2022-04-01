public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Init() =>
        VerifyImageSharpCompare.Initialize();
}