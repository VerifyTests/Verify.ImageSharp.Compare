using Codeuctivity.ImageSharpCompare;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace VerifyTests;

public static class VerifyImageSharpCompare
{
    /// <summary>
    /// Helper method that calls <see cref="RegisterComparers"/>(threshold = 95, new DifferenceHash()) for png, bmp, and jpg.
    /// </summary>
    public static void Initialize()
    {
        InnerVerifier.ThrowIfVerifyHasBeenRun();
        RegisterComparers();
    }

    public static void RegisterComparers(int threshold = 5)
    {
        InnerVerifier.ThrowIfVerifyHasBeenRun();
        RegisterComparer(threshold, "png");
        RegisterComparer(threshold, "bmp");
        RegisterComparer(threshold, "jpg");
    }

    public static void UseImageHash(this VerifySettings settings, int threshold = 5) =>
        settings.UseStreamComparer(
            (received, verified, _) => Compare(threshold, received, verified));

    public static SettingsTask UseImageHash(this SettingsTask settings, int threshold = 5) =>
        settings.UseStreamComparer(
            (received, verified, _) => Compare(threshold, received, verified));

    public static void RegisterComparer(int threshold, string extension) =>
        VerifierSettings.RegisterStreamComparer(
            extension,
            (received, verified, _) => Compare(threshold, received, verified));

    static Task<CompareResult> Compare(int threshold, Stream received, Stream verified)
    {
        using var receivedImage = Image.Load<Rgba32>(received);
        using var verifiedImage = Image.Load<Rgba32>(verified);

        ICompareResult similarity;
        try
        {
            similarity = ImageSharpCompare.CalcDiff(receivedImage, verifiedImage);
        }
        catch (ImageSharpCompareException exception)
        {
            return Task.FromResult(CompareResult.NotEqual(exception.Message));
        }

        var absoluteError = similarity.AbsoluteError;
        var compare = absoluteError <= threshold;
        if (compare)
        {
            return Task.FromResult(CompareResult.Equal);
        }

        return Task.FromResult(CompareResult.NotEqual($"""
            similarity({absoluteError}) > threshold({threshold}).
            If this difference is acceptable, use:
            
             * Globally: VerifyImageSharpCompare.RegisterComparers({absoluteError});
             * For one test: Verifier.VerifyFile("file.jpg").UseImageHash({absoluteError});
            """));
    }
}