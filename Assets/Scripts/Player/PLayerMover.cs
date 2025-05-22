using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMover : MonoBehaviour, IPlayerMover
{
    private Rigidbody2D _rb;
    [SerializeField] private float _moveSpeed=10f;
    //Startメソッド
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerUpdate()
    {
        // プレイヤーの入力（左右移動）を取得
        float inputX = Input.GetAxis("Horizontal");
        // 入力に応じて右方向へ力を加え、キャラクターを移動させます
        _rb.AddForce(transform.right * inputX*_moveSpeed*Time.deltaTime, ForceMode2D.Impulse);
    }
}
