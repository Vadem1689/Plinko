using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pot : MonoBehaviour
{
    [SerializeField] private TypePot _typePot;
    [SerializeField] private SpriteRenderer _iconTypePot;

    public Action<TypePot> OnFellIntoPot;

    public void ChangeType(TypePot newTypePot,Sprite newIconTypePot)
    {
        _typePot = newTypePot;
        _iconTypePot.sprite = newIconTypePot;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MainBall>())
        {
            OnFellIntoPot?.Invoke(_typePot);
            collision.gameObject.SetActive(false);
        }
    }

    
}
