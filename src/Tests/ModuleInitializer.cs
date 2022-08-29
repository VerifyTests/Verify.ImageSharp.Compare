public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageSharpCompare.Initialize();

        #endregion

        VerifyDiffPlex.Initialize();
    }
}