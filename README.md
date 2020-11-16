# Unity_TextFileReadWriter

``TextFileReadWriter`` provides simple functions to Read/Write text from/to file.

## Import to Your Project

Paste this code into PackageManager > Add package from git URL.

> https://github.com/XJINE/Unity_TextFileReadWriter.git?path=/Packages/TextFileReadWriter

## How to Use

Following codes are sample.

```csharp
TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", this.text);
this.text = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt").text;
```

These are any other functions. It is enable to read/write in any place.

```csharp
ReadFromAssets         (string relativePath)
ReadFromStreamingAssets(string relativePath)
ReadFromFile           (string absolutePath)

WriteToAssets         (string relativePath, string text)
WriteToStreamingAssets(string relativePath, string text)
WriteToFile           (string absolutePath, string text)
```