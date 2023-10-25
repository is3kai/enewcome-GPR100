using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RandomCollectable : MonoBehaviour
{
    public ScoreScript score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RepositionCollectible();
    }
    void RepositionCollectible()
    {
        float newX = UnityEngine.Random.Range(-5, 5);
        float newY = UnityEngine.Random.Range(-5, 5);
        Vector2 newPos = new Vector2(newX, newY);
        transform.position = newPos;
        score.AddScore();
    }
}
