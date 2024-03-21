using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MainBall : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;

    public void StopBall()
    {
        _rb.velocity = Vector2.zero;
    }
}
