using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementTask : MonoBehaviour
{
    [SerializeField] private GameObject _checkMark;

    private TypePot _currentTypePot;
    private bool _isCollected;

    public bool IsCollected=> _isCollected;
    public TypePot CurrentTypePot => _currentTypePot;

    public void Activat—eheckMark()
    {
        _checkMark.SetActive(true);
        _isCollected = true;
    }

    public void PointOutType(TypePot typePot)
    {
        _currentTypePot = typePot;
    }
}
