using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    int _score = 0;

    public void AddScore()
    {
        _score++;
        scoretext.text = _score.ToString();

        PlayerPrefs.SetInt("FinalScore", _score);
    }
}
