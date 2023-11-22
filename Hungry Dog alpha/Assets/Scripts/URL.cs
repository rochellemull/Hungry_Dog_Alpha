using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    public string url;
    // Start is called before the first frame update
    public void OpenGithub()
    {
        Application.OpenURL(url);
    }
}
