[TestFixture]
public class Samples
{
    #region CompareImage

    [Test]
    public Task CompareImage() =>
        VerifyFile("sample1.jpg");

    #endregion
}
