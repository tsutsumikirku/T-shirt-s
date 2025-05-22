using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOn : MonoBehaviour
{
    /// <summary>
    /// このオブジェクトをプレイヤーが踏んだかどうか
    /// </summary>
    [HideInInspector] public bool playerStepOn;
    [SerializeField] private float _jumpPower = 5f;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //ToDo: エネミーは踏まれたときに死亡する
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
            _rb.AddForce(transform.up * _jumpPower, ForceMode2D.Impulse);
            
        }
        else if (collision.gameObject.tag == "Box")
        {
            //ToDo: ボックスは踏まれた時に複数回絶えて死亡する
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
        }
        else if (collision.gameObject.tag == "Button")
        {
            //ToDo:一回破壊の後時間経過後に再生成
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
        }

    }
}
