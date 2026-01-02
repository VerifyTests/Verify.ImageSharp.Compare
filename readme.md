# <img src="/src/icon.png" height="30px"> Verify.ImageSharp.Compare

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://img.shields.io/appveyor/build/SimonCropp/Verify-ImageSharp-Compare)](https://ci.appveyor.com/project/SimonCropp/Verify-ImageSharp-Compare)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.ImageSharp.Compare.svg)](https://www.nuget.org/packages/Verify.ImageSharp.Compare/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of images via [Codeuctivity.ImageSharp.Compare](https://github.com/Codeuctivity/ImageSharp.Compare).<!-- singleLineInclude: intro. path: /docs/intro.include.md -->

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, and bmp.

**See [Milestones](../../milestones?state=closed) for release notes.**


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.ImageSharp.Compare) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](https://raw.githubusercontent.com/VerifyTests/Verify.ImageSharp.Compare/refs/heads/main/docs/zzz.png)](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.ImageSharp.Compare)<!-- endInclude -->


## NuGet

 * https://nuget.org/packages/Verify.ImageSharp.Compare


## Usage

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyImageSharpCompare.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Image Comparers

The following will use ImageHash to compare the images instead of the default DifferenceHash algorithm.

<!-- snippet: CompareImage -->
<a id='snippet-CompareImage'></a>
```cs
[Test]
public Task CompareImage() =>
    VerifyFile("sample1.jpg");
```
<sup><a href='/src/Tests/Samples.cs#L4-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-CompareImage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Register all comparers

All comparers can be registered:

```
VerifyImageSharpCompare.RegisterComparers();
```


## Icon

[Pattern](https://thenounproject.com/term/pattern/891931/) designed by [Marialuisa Iborra](https://thenounproject.com/marialuisa.iborra/) from [The Noun Project](https://thenounproject.com/).
