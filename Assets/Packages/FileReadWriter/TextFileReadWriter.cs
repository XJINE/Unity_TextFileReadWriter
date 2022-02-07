using System.IO;
using UnityEngine;

public static class TextFileReadWriter
{
    #region Method

    public static (string text, bool success) ReadFromAssets(string file)
    {
        return Read(Path.Combine(Application.dataPath, file));
    }

    public static (string text, bool success) ReadFromAssets(string dir, string file)
    {
        dir ??= "";
        return Read(Path.Combine(Application.dataPath, dir, file));
    }

    public static (string text, bool success) ReadFromStreamingAssets(string file)
    {
        return Read(Path.Combine(Application.streamingAssetsPath, file));
    }

    public static (string text, bool success) ReadFromStreamingAssets(string dir, string file)
    {
        dir ??= "";
        return Read(Path.Combine(Application.streamingAssetsPath, dir, file));
    }

    public static (string text, bool success) Read(string dir, string file)
    {
        return Read(Path.Combine(dir, file));
    }

    public static (string text, bool success) Read(string path)
    {
        var result = System.IO.TextFileReadWriter.Read(path);

        if (!result.success)
        {
            Debug.LogWarning(result.text);
        }

        return result;
    }

    public static (string text, bool success) WriteToAssets(string file, string text)
    {
        return Write(Path.Combine(Application.dataPath, file), text);
    }

    public static (string text, bool success) WriteToAssets(string dir, string file, string text)
    {
        dir ??= "";
        return Write(Path.Combine(Application.dataPath, dir, file), text);
    }

    public static (string text, bool success) WriteToStreamingAssets(string file, string text)
    {
        return Write(Path.Combine(Application.streamingAssetsPath, file), text);
    }

    public static (string text, bool success) WriteToStreamingAssets(string dir, string file, string text)
    {
        dir ??= "";
        return Write(Path.Combine(Application.streamingAssetsPath, dir, file), text);
    }

    public static (string text, bool success) Write(string dir, string file, string text)
    {
        return Write(Path.Combine(dir, file), text);
    }

    public static (string text, bool success) Write(string path, string text)
    {
        var result = System.IO.TextFileReadWriter.Write(path, text);

        if (!result.success)
        {
            Debug.LogWarning(result.text);
        }

        return result;
    }

    #endregion Method
}