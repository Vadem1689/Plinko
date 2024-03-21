using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPointMainBall : MonoBehaviour
{
    [SerializeField] private SpawnPointMainBall _spawnPoint;
    [SerializeField] private MainBall _mainBall;
    [SerializeField] private float _maxRandomX;
    [SerializeField] private float _minRandomX;


    public void TurnOnMainBall()
    {
        if(_mainBall.gameObject.active==false)
        {
            _mainBall.transform.position = GetSpawnPoint();
            _mainBall.StopBall();
            _mainBall.gameObject.SetActive(true);
        }
    }

    private Vector2 GetSpawnPoint()
    {
        float randomNumberX = Random.Range(_minRandomX, _maxRandomX);
        return new Vector2(randomNumberX, _spawnPoint.transform.position.y);
    }
}
