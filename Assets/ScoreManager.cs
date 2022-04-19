using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   int score;
   public void Score(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log(score);
    }
}
