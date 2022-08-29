# <img src="/src/icon.png" height="30px"> Verify.ImageSharp.Compare

[![Build status](https://ci.appveyor.com/api/projects/status/5xbq2gu1qh383r16?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-ImageSharp-Compare)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.ImageSharp.Compare.svg)](https://www.nuget.org/packages/Verify.ImageSharp.Compare/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of images via [Codeuctivity.ImageSharp.Compare](https://github.com/Codeuctivity/ImageSharp.Compare).

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, and bmp.


## NuGet package

https://nuget.org/packages/Verify.ImageSharp.Compare/


## Usage

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init()
{
    VerifyImageSharpCompare.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Image Comparers

The following will use ImageHash to compare the images instead of the default DifferenceHash algorithm.

<!-- snippet: CompareImage -->
<a id='snippet-compareimage'></a>
```cs
[Test]
public Task CompareImage() =>
    VerifyFile("sample.jpg");
```
<sup><a href='/src/Tests/Samples.cs#L4-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-compareimage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Register all comparers

All comparers can be registered:

```
VerifyImageHash.RegisterComparers();
```


## Icon

[Pattern](https://thenounproject.com/term/pattern/891931/) designed by [Marialuisa Iborra](https://thenounproject.com/marialuisa.iborra/) from [The Noun Project](https://thenounproject.com/).
