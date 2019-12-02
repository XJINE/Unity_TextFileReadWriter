using UnityEngine;

public static class TextFileReadWriter
{
    #region Method

    public static string ReadFromAssets(string relativePath)
    {
        return ReadFromFile(Application.dataPath + ToRelativePath(relativePath));
    }

    public static string ReadFromStreamingAssets(string relativePath)
    {
        return ReadFromFile(Application.streamingAssetsPath + ToRelativePath(relativePath));
    }

    public static string ReadFromFile(string absolutePath)
    {
        System.IO.TextFileReadWriter.Result result = System.IO.TextFileReadWriter.Read(absolutePath);

        if (!result.isSuccess)
        {
            Debug.LogWarning(result.text);
            return null;
        }

        return result.text;
    }

    public static bool WriteToAssets(string relativePath, string text)
    {
        return WriteToFile(Application.dataPath + ToRelativePath(relativePath), text);
    }

    public static bool WriteToStreamingAssets(string relativePath, string text)
    {
        return WriteToFile(Application.streamingAssetsPath + ToRelativePath(relativePath), text);
    }

    public static bool WriteToFile(string absolutePath, string text)
    {
        System.IO.TextFileReadWriter.Result result = System.IO.TextFileReadWriter.Write(absolutePath, text);

        if (!result.isSuccess)
        {
            Debug.LogWarning(result.text);
        }

        return result.isSuccess;
    }

    private static string ToRelativePath(string path)
    {
        if (path == null || path.Length == 0)
        {
            return "/";
        }

        if (path[0] == '/')
        {
            return path;
        }
        else
        {
            return "/" + path;
        }
    }

    #endregion Method
}