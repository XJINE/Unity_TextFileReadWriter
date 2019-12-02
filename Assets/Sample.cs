using UnityEngine;

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
            if (TextFileReadWriter.WriteToStreamingAssets("SampleDir/TextFile.txt", this.text))
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
            this.text = TextFileReadWriter.ReadFromStreamingAssets("SampleDir/TextFile.txt");

            if (this.text != null)
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
        GUILayout.Label("[" + this.ReadTextKey       + "] Read Json.");
        GUILayout.Label("[" + this.WriteTextKey      + "] Write Json.");
    }

    #endregion Method
}