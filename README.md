# Unity_TextFileReadWriter

``TextFileReadWriter`` provides simple functions to Read/Write text from/to file.

## How to Use

Following codes are sample.

```csharp
TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", text);
text = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt").text;
```

These are any other functions. It is enable to read/write in any place.

```csharp
ReadFromAssets         (string relativePath)
ReadFromStreamingAssets(string relativePath)
Read                   (string absolutePath)

WriteToAssets         (string relativePath, string text)
WriteToStreamingAssets(string relativePath, string text)
Write                 (string absolutePath, string text)
```
