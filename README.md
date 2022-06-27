# Unity_TextFileReadWriter

``TextFileReadWriter`` provides simple functions to read/write text from/to file.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_TextFileReadWriter.git?path=Assets/Packages/TextFileReadWriter
```

## How to Use

Following functions are included.

```csharp
(string text, bool success) ReadFromAssets(string file)
(string text, bool success) ReadFromAssets(string dir, string file)

(string text, bool success) ReadFromStreamingAssets(string file)
(string text, bool success) ReadFromStreamingAssets(string dir, string file)

(string text, bool success) Read(string dir, string file)
(string text, bool success) Read(string path)

(string text, bool success) WriteToAssets(string file, string text)
(string text, bool success) WriteToAssets(string dir, string file, string text)

(string text, bool success) WriteToStreamingAssets(string file, string text)
(string text, bool success) WriteToStreamingAssets(string dir, string file, string text)

(string text, bool success) Write(string dir, string file, string text)
(string text, bool success) Write(string path, string text)
```
