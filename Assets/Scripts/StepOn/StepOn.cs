using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepOn : MonoBehaviour
{
    /// <summary>
    /// ���̃I�u�W�F�N�g���v���C���[�����񂾂��ǂ���
    /// </summary>
    [HideInInspector] public bool playerStepOn;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        else if (collision.gameObject.tag == "Box")
        {
            //ToDo: �{�b�N�X�͓��܂ꂽ���ɕ�����₦�Ď��S����
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
        }
        else if (collision.gameObject.tag == "Button")
        {
            //ToDo:���j��̌㎞�Ԍo�ߌ�ɍĐ���
            collision.gameObject.GetComponent<StepOnInterface>().OnStep();
        }

    }
}
