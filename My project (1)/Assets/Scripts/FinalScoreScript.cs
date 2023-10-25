using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScoreScript : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        int score = PlayerPrefs.GetInt("FinalScore");
        scoreText.text = score.ToString();
    }
}
