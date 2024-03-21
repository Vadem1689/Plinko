using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PanelEndGame : MonoBehaviour
{
    [SerializeField] private TMP_Text _nowScore;
    [SerializeField] private TMP_Text _record;
    [SerializeField] private Score _score;
    [SerializeField] private GameObject _buttonsDisabled;

    public void ShowStatistics()
    {
        _nowScore.text = _score.CountScore.ToString();
        _record.text = TrySaveRecord().ToString();

        _buttonsDisabled.gameObject.SetActive(false);
    }

    private int TrySaveRecord()
    {
        int record = 0; 

        if (PlayerPrefs.HasKey("Record"))
        {
            record = PlayerPrefs.GetInt("Record");
        }
        if(record< _score.CountScore)
        {
            PlayerPrefs.SetInt("Record", _score.CountScore);
            record = _score.CountScore;
        }
        return record;
    }
}
