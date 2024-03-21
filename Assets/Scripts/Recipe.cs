using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    [SerializeField] private List<TypePot> _needIngredients;
    [SerializeField] private Score _score;
    [SerializeField] private int _price;
    [SerializeField] private Button _selectButton;

    private bool _isBuy;

    public bool IsBuy => _isBuy;

    public void TryBuy()
    {
        if(_price<_score.CountScore)
        {
            _score.ChangeScore(-_price);
            BuyIngredients();
        }
    }

    public void BuyIngredients()
    {
        _isBuy = true;
        _selectButton.gameObject.SetActive(true);
        string ingredientsForPlayerPrefs = "";

        for (int i = 0; i < _needIngredients.Count; i++)
        {
            ingredientsForPlayerPrefs += (int)_needIngredients[i]+" ";
        }

        PlayerPrefs.SetString("IngredientsBuy", ingredientsForPlayerPrefs);
    }
}
