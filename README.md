# Unity_TextFileReadWriter

``TextFileReadWriter`` provides simple functions to Read/Write text from/to file.

## Import to Your Project

You can import this asset from UnityPackage.

- [TextFileReadWriter.unitypackage](https://github.com/XJINE/Unity_TextFileReadWriter/blob/master/TextFileReadWriter.unitypackage)

## How to Use

Following codes are sample.

```csharp
TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", this.text);
this.text = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt");
```