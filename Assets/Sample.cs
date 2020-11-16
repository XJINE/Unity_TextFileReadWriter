using UnityEngine;
using System.IO;

public class Sample : MonoBehaviour
{
    #region Field

    public string  text         = "This is sample text.";
    public KeyCode readTextKey  = KeyCode.R;
    public KeyCode writeTextKey = KeyCode.W;

    #endregion Field

    #region Method

    protected virtual void Update()
    {
        if (Input.GetKeyDown(this.writeTextKey))
        {
            TextFileIOResult result = TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", this.text);

            if (result.success)
            {
                Debug.Log("Success : Write Text.");
            }
            else
            {
                Debug.Log("Failure : Write Text.");
            }
        }

        if (Input.GetKeyDown(this.readTextKey))
        {
            TextFileIOResult result = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt");

            this.text = result.text;

            if (result.success)
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
        GUILayout.Label("[" + this.readTextKey  + "] Read Text.");
        GUILayout.Label("[" + this.writeTextKey + "] Write Text.");
    }

    #endregion Method
}