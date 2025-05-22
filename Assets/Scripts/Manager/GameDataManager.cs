using System;
using UnityEngine;
/// <summary>
/// スコアを管理するクラス(シングルトンパターン)
/// </summary>
public class GameDataManager : MonoBehaviour
{
    [SerializeField]int _score;//スコア
    int _defaultHp;
    int _defaultRemaing;
    int _progress; //進行度
    GameObject _player;
    public GameObject Player {  set => _player = value; }
    [SerializeField] private int _hp; //HP
    [SerializeField] private int _remaing; //残機
    [SerializeField] private AudioClip _damageSE; //ダメージSE
    [SerializeField] private AudioClip _DeadSE; //死亡SE
    private SpawnManager _spawnManager;
    public SpawnManager SpawnManager { set => _spawnManager = value; }
    public event Action<int> OnScoreChanged;//スコアが変化したときに呼び出されるイベント
    public static GameDataManager Instance;
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
    public void Init()
    {
        _score = 0;
        _hp = _defaultHp;
        _remaing = 3;
        for (int i = 0; i < _spawnManager.SpawnObject.Length; i++)
        {
            _spawnManager.SpawnObject[i].oncolliderEnter += () =>
            {
                _spawnManager.SpawnObject[i].gameObject.SetActive(false);
                _progress++;
            };
        }
        _player.transform.position = _spawnManager.SpawnObject[_progress].transform.position;
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
        if (_hp <= 0)
        {
            PlayerDead();
            return;
        }
        SoundManager.Instance.PlaySE(_damageSE);
    }
    public void PlayerDead()
    {
        _remaing--;
        PlayerRestart();
        SoundManager.Instance.PlaySE(_DeadSE);
    }
    void PlayerRestart()
    {
        _hp = _defaultHp;
        _player.transform.position = _spawnManager.SpawnObject[_progress].transform.position;
    }
}
