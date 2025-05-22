using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class EnemyWalk : EnemyBase
    {
    [SerializeField, Header("�ړ����x")]
     private float _MoveSpeed;

     private Rigidbody2D _rig;

     private bool _moveDirection = true; 
     

    // Start is called before the first frame update
    void Start()
        {
            _rig = GetComponent<Rigidbody2D>();

        }

        // Update is called once per frame
        void Update()
        {
            
            _rig.AddForce((_moveDirection ? Vector2.left : Vector2.right)*_MoveSpeed,ForceMode2D.Impulse);
            
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Wall"))
        {
            _moveDirection = !_moveDirection;
            
        }
    }
    }





