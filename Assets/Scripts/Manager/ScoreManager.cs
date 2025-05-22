using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
/// <summary>
/// スコアを管理するクラス(シングルトンパターン)
/// </summary>
public class ScoreManager : MonoBehaviour
{
    int _score;//スコア
    [SerializeField] private int _hp; //HP
    public event Action<int> OnScoreChanged;//スコアが変化したときに呼び出されるイベント
    public static ScoreManager Instance;
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
    public void AddScore(int score)
    {
        _score += score;
        OnScoreChanged?.Invoke(_score);
    }
    public void Damage(int damage)
    {
        _hp -= damage;
    }
}
