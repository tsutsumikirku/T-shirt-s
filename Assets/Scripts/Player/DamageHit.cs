using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            int hitDamage = collision.gameObject.GetComponent<EnemyBase>().AttackPower;
            ScoreManager.Instance.Damage(hitDamage);
        }
    }
}
