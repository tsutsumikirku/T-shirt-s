using System;
using UnityEngine;
/// <summary>
/// スコアを管理するクラス(シングルトンパターン)
/// </summary>
public class ScoreManager : MonoBehaviour
{
    int _score;//スコア
    int _defaultHp;
    [SerializeField] private int _hp; //HP
    [SerializeField] private int _remaing; //残機
    public event Action<int> OnScoreChanged;//スコアが変化したときに呼び出されるイベント
    public static ScoreManager Instance;
    void Awake()
    {
        _defaultHp = _hp;
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
        Debug.Log(_score);
    }
    public void Damage(int damage)
    {
        _hp -= damage;
    }
    public void PlayerDead()
    {
        _remaing--;
    }
    void PlayerRestart()
    {
        _hp = _defaultHp;
        _score = 0;
    }
}
