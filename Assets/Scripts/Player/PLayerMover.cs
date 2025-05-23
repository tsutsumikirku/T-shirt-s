using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMover : MonoBehaviour, IPlayerMover
{
    private Rigidbody2D _rb;
    Animator _animator;
    [SerializeField] private float _moveSpeed=10f;
    //Start���\�b�h
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    public void PlayerUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        _rb.AddForce(transform.right * inputX * _moveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        if (inputX != 0)
        {
            if (inputX > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        _animator.SetBool("Move", inputX != 0);
    }
}
