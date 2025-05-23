using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOn : MonoBehaviour
{
    [SerializeField]AudioClip _onStepSound;
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
            //ToDo: �G�l�~�[�͓��܂ꂽ�Ƃ��Ɏ��S����
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
            _rb.AddForce(transform.up * _jumpPower, ForceMode2D.Impulse);
            SoundManager.Instance.PlaySE(_onStepSound);
        }
        else if (collision.gameObject.tag == "Box")
        {
            //ToDo: �{�b�N�X�͓��܂ꂽ���ɕ�����₦�Ď��S����
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
            SoundManager.Instance.PlaySE(_onStepSound);
        }
        else if (collision.gameObject.tag == "Button")
        {
            //ToDo:���j��̌㎞�Ԍo�ߌ�ɍĐ���
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
            SoundManager.Instance.PlaySE(_onStepSound);
        }
        else if (collision.gameObject.tag == "Item")
        {
            //ToDo:���j��̌㎞�Ԍo�ߌ�ɍĐ���
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
            SoundManager.Instance.PlaySE(_onStepSound);
        }
    }
}
