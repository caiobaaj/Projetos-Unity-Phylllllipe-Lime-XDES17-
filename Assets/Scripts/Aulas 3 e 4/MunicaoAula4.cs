using System;
using UnityEngine;

public class MunicaoAula4 : MonoBehaviour
{
    [SerializeField] private float xSpeed;
    
    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _rb.AddForceX(xSpeed, ForceMode2D.Impulse);
    }
}
