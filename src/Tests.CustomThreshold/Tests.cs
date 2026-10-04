namespace CustomThresholdTests;

public class Tests
{
    [Test]
    public Task Working() =>
        VerifyFile(ProjectFiles.sample1_jpg.Path);

    [Test]
    public Task FailingCompare() =>
        ThrowsTask(async () =>
            {
                await VerifyFile(ProjectFiles.sample2_jpg.Path)
                    .DisableDiff()
                    .UseMethodName("FailingCompareInner");
            })
            .IgnoreStackTrace()
            .ScrubLinesContaining("clipboard", "DiffEngineTray");
}
