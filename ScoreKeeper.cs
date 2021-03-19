using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static int score = 0;
    const string SCORE_KEY = "Score";
    // Start is called before the first frame update

    private void Start()
    {
        score = GetScore();
    }

    public static void IncrementScore(int Increment)
    {
        score += Increment;
        print(score);
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt(SCORE_KEY, score);
    }

    public int GetScore()
    {
        return PlayerPrefs.GetInt(SCORE_KEY);
    }

    private void OnDestroy()
    {
        SaveScore();
    }
}
