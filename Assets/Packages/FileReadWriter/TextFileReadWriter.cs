using System.IO;
using UnityEngine;

public static class TextFileReadWriter
{
    #region Method

    public static (string text, bool success) ReadFromAssets(string relativePath)
    {
        return ReadFromFile(Path.Combine(Application.dataPath, relativePath));
    }

    public static (string text, bool success) ReadFromStreamingAssets(string relativePath)
    {
        return ReadFromFile(Path.Combine(Application.streamingAssetsPath, relativePath));
    }

    public static (string text, bool success) ReadFromFile(string absolutePath)
    {
        var result = System.IO.TextFileReadWriter.Read(absolutePath);

        if (!result.success)
        {
            Debug.LogWarning(result.text);
        }

        return result;
    }

    public static (string text, bool success) WriteToAssets(string relativePath, string text)
    {
        return WriteToFile(Path.Combine(Application.dataPath, relativePath), text);
    }

    public static (string text, bool success) WriteToStreamingAssets(string relativePath, string text)
    {
        return WriteToFile(Path.Combine(Application.streamingAssetsPath, relativePath), text);
    }

    public static (string text, bool success) WriteToFile(string absolutePath, string text)
    {
        var result = System.IO.TextFileReadWriter.Write(absolutePath, text);

        if (!result.success)
        {
            Debug.LogWarning(result.text);
        }

        return result;
    }

    #endregion Method
}