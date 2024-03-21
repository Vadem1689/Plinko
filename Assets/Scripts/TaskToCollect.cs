using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskToCollect : MonoBehaviour
{
    [SerializeField] private List<TypePot> _typePot;
    [SerializeField] private TaskUI _taskUI;
    [SerializeField] private ChangePot _changePot;

    private void OnEnable()
    {
        foreach (Pot pot in _changePot.Pots)
        {
            pot.OnFellIntoPot += Check—orrectnessElement;
        }
    }

    private void OnDisable()
    {
        foreach (Pot pot in _changePot.Pots)
        {
            pot.OnFellIntoPot -= Check—orrectnessElement;
        }
    }

    private void Start()
    {
        GetTask();
        _taskUI.ShowTask(_typePot);
    }

    private void GetTask()
    {
        if (PlayerPrefs.HasKey("IngredientsBuy"))
        {
            string geterPlayerPrefsIngredients = PlayerPrefs.GetString("IngredientsBuy");

            string[] words = geterPlayerPrefsIngredients.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                int y = 0;
                if (words[i]!= "")
                {
                    y = Convert.ToInt32(words[i]);
                    print(words[i]);
                }
                
                _typePot[i] = (TypePot)(y);
                
            }
        }    
    }

    private void ReplaceTask(List<TypePot> newTypePot)
    {
        _typePot=newTypePot;
        _taskUI.ShowTask(_typePot);
    }

    private void Check—orrectnessElement(TypePot typePot)
    {
        for (int i = 0; i < _typePot.Count; i++)
        {
            if (_typePot[i]== typePot)
            {
                print("≈ÒÚ¸ Ú‡ÍÓÈ");
                _taskUI.TurnOnCheckMark(typePot);
                break;
            }
        }
    }
}
