using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private float _timeRemaining;
    [SerializeField] private PanelEndGame _panelEnd;

    void Update()
    {
        if (_timeRemaining > 0)
        {
            _timeRemaining -= Time.deltaTime;
            DisplayTime(_timeRemaining);
        }
        else
        {
            _timeRemaining = 0;
            DisplayTime(_timeRemaining);

            _panelEnd.ShowStatistics();
            _panelEnd.gameObject.SetActive(true);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        _timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
