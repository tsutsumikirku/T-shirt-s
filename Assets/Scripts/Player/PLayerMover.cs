using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMover : MonoBehaviour, IPlayerMover
{
    private Rigidbody2D _rb;
    [SerializeField] private float _moveSpeed=10f;
    //Start���\�b�h
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
        // �v���C���[�̓��́i���E�ړ��j���擾
        float inputX = Input.GetAxis("Horizontal");
        // ���͂ɉ����ĉE�����֗͂������A�L�����N�^�[���ړ������܂�
        _rb.AddForce(transform.right * inputX*_moveSpeed*Time.deltaTime, ForceMode2D.Impulse);
    }
}
