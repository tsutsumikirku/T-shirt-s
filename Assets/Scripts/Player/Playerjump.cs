using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerJump : MonoBehaviour, IPlayerMover
{
    [SerializeField] AudioClip m_Clip;
    [SerializeField] float JumpPower = 5f;
    [SerializeField] int Jumpcount = 1;
    int _curretJumpcount;

    Rigidbody2D _rd;
    public void PlayerUpdate()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _curretJumpcount =Jumpcount ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (_curretJumpcount > 0)
            {
                _rd.AddForce(transform.up * JumpPower, ForceMode2D.Impulse);
                _curretJumpcount--;
                SoundManager.Instance.PlaySE(m_Clip);
            }

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            {
            _curretJumpcount=Jumpcount;
            }

    }
}
