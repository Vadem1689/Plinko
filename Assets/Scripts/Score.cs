using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private ScoreUI _scoreUI;

    private int _countScore;

    public int CountScore=> _countScore;

    private void Start()
    {
        CheckCountScore();
        _scoreUI.ShowScore(_countScore);
    }

    public void ChangeScore(int count)
    {
        _countScore+= count;
        _scoreUI.ShowScore(_countScore);
        SaveScore();
    }

    private void CheckCountScore()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            _countScore = PlayerPrefs.GetInt("Score");
        }
    }

    private void SaveScore()
    {
        PlayerPrefs.SetInt("Score", _countScore);
    }
}
