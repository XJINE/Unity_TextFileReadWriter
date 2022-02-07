using UnityEngine;

public class Sample : MonoBehaviour
{
    #region Field

    public string  text         = "This is sample text.";
    public KeyCode readTextKey  = KeyCode.R;
    public KeyCode writeTextKey = KeyCode.W;

    #endregion Field

    #region Method

    private void Update()
    {
        if (Input.GetKeyDown(writeTextKey))
        {
            var (text, success) = TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", this.text);

            if (success)
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
            var (text, success) = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt");

            if (success)
            {
                this.text = text;
                Debug.Log("Success : Read Text.");
            }
            else
            {
                Debug.Log("Failure : Read Text.");
            }
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("[" + readTextKey  + "] Read Text.");
        GUILayout.Label("[" + writeTextKey + "] Write Text.");
    }

    #endregion Method
}