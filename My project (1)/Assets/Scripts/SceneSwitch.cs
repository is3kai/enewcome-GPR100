using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string stringName;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SwitchScene();
        }
    }
    void SwitchScene()
    {
        SceneManager.LoadScene(stringName);
    }
}
