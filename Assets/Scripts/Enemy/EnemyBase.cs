using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour, StepOnInterface
{
    [SerializeField] int _attackPower;
    [SerializeField] private int score=10;
    public int AttackPower { get => _attackPower;}
    public void OnStep()
    {
        GameDataManager.Instance.AddScore(score);
        Destroy(this.gameObject);

    }
}
