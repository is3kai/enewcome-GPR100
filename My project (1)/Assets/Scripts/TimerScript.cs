using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public string sceneName;
    public TextMeshProUGUI timetext;
    public float _time = 90f;
    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        timetext.text = _time.ToString("F3");
        if (_time <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
