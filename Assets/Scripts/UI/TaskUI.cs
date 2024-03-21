using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TaskUI : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private int _award;
    [SerializeField] private List<Sprite> _imageIce—ream;
    [SerializeField] private List<ElementTask> _taskCells;

    [SerializeField] private PanelEndGame _panelEndGame;

    public void ShowTask(List<TypePot> task)
    {
        for (int i = 0; i < _taskCells.Count; i++)
        {
            _taskCells[i].GetComponent<Image>().sprite = _imageIce—ream[(int)task[i]];
            _taskCells[i].PointOutType(task[i]);
        }
    }

    public void TurnOnCheckMark(TypePot typePot)
    {
        for (int i = 0; i < _taskCells.Count; i++)
        {
            if(typePot== _taskCells[i].CurrentTypePot&& !_taskCells[i].IsCollected)
            {
                _score.ChangeScore(_award);
                _taskCells[i].Activat—eheckMark();
            }
        }
    }

    private void CheckingEndGame()
    {
        bool isFinish=false;

        for (int i = 0; i < _taskCells.Count; i++)
        {
            if (!_taskCells[i].IsCollected)
            {
                isFinish=true;
            }
        }

        if(!isFinish)
        {
            _panelEndGame.gameObject.SetActive(true);
            _panelEndGame.ShowStatistics();
        }
    }
}
