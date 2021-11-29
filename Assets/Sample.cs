using UnityEngine;

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
        if (Input.GetKeyDown(writeTextKey))
        {
            var result = TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", text);

            if (result.success)
            {
                Debug.Log("Success : Write Text.");
            }
            else
            {
                Debug.Log("Failure : Write Text.");
            }
        }

        if (Input.GetKeyDown(readTextKey))
        {
            var result = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt");

            if (result.success)
            {
                text = result.text;
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
        GUILayout.Label("[" + readTextKey  + "] Read Text.");
        GUILayout.Label("[" + writeTextKey + "] Write Text.");
    }

    #endregion Method
}