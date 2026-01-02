[TestFixture]
public class Tests
{
    [Test]
    public Task Working() =>
        VerifyFile("sample1.jpg");

    [Test]
    public Task FailingCompare() =>
        ThrowsTask(async () =>
            {
                await VerifyFile("sample2.jpg")
                    .DisableDiff()
                    .UseMethodName("FailingCompareInner");
            })
            .IgnoreStackTrace()
            .ScrubLinesContaining("clipboard", "DiffEngineTray");
}
