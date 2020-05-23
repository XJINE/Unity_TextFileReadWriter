using UnityEngine;
using System.IO;

public class Sample : MonoBehaviour
{
    #region Field

    public string  text = "This is sample text.";
    public KeyCode ReadTextKey  = KeyCode.R;
    public KeyCode WriteTextKey = KeyCode.W;

    #endregion Field

    #region Method

    protected virtual void Update()
    {
        if (Input.GetKeyDown(this.WriteTextKey))
        {
            TextFileIOResult result = TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", this.text);

            if (result.isSuccess)
            {
                Debug.Log("Success : Write Text.");
            }
            else
            {
                Debug.Log("Failure : Write Text.");
            }
        }

        if (Input.GetKeyDown(this.ReadTextKey))
        {
            TextFileIOResult result = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt");

            this.text = result.text;

            if (result.isSuccess)
            {
                Debug.Log("Success : Read Text.");
            }
            else
            {
                Debug.Log("Failure : Read Text.");
            }
        }
    }

    protected virtual void OnGUI()
    {
        GUILayout.Label("[" + this.ReadTextKey       + "] Read Text.");
        GUILayout.Label("[" + this.WriteTextKey      + "] Write Text.");
    }

    #endregion Method
}