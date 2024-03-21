using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePot : MonoBehaviour
{
    [SerializeField] private List<Sprite> _potSprits;
    [SerializeField] private List<Pot> _pots;
    [SerializeField] private List<TypePot> _typePot;

    public List<Pot> Pots => _pots;

    public void ChangeTypePots()
    {
        for (int i = 0; i < _pots.Count; i++)
        {
            int randomTypePot = Random.Range(0, _potSprits.Count);
            //_pots[i].gameObject.GetComponent<SpriteRenderer>().sprite = _potSprits[randomTypePot];
            _pots[i].ChangeType(_typePot[randomTypePot], _potSprits[randomTypePot]);
        }
    }
}


