using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    public string stringName;
    public void SwitchScene()
    {
        SceneManager.LoadScene(stringName);
    }
}
