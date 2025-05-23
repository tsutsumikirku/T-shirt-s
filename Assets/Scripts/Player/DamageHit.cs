using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class DamageHit : MonoBehaviour
{
    [SerializeField]LayerMask _enemyLayer;
    Rigidbody2D _rigidbody2D;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit");
            int hitDamage = collision.gameObject.GetComponent<EnemyBase>().AttackPower;
            GameDataManager.Instance.Damage(hitDamage);
            Hit();
        }
    }
    async UniTask Hit()
    {
        SpriteRenderer[] spriteRenderer = gameObject.GetComponentsInChildren<SpriteRenderer>();
        _rigidbody2D.excludeLayers = _enemyLayer;
        for (int i = 0; i < 5; i++)
        {
            Array.ForEach(spriteRenderer, x => x.color = new Color(1, 1, 1, 0f));
            await UniTask.Delay(100);
            Array.ForEach(spriteRenderer, x => x.color = new Color(1, 1, 1, 1));
            await UniTask.Delay(100);
        }
        _rigidbody2D.excludeLayers = 0;
    }
}
