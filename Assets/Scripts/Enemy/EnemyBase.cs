using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] int _attackPower;
    public int AttackPower { get => _attackPower;}
}
