using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class EnemyJump : EnemyBase
{
    private Rigidbody2D _rb;
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private float _jumpCoolTime = 3.0f;
    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count > _jumpCoolTime)
        {
            _rb.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
            count = 0;
        }
    }
}
