using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// プレイヤーに関するクラスを管理するクラス
/// </summary>
public class PlayerContainer : MonoBehaviour
{
    IPlayerMover[] _playerMovers;
    bool _isPlayerMover = true;

    public bool IsPlayerMover { set => _isPlayerMover = value; }
    /// <summary>
    /// Awakeメソッド
    /// 初期化処理を行う
    /// </summary>
    void Start()
    {
        _playerMovers = GetComponents<IPlayerMover>();
        GameDataManager.Instance.Player = gameObject;
        GameDataManager.Instance.Init();
    }
    /// <summary>
    /// プレイヤーの移動処理を実行する
    /// </summary>
    void Update()
    {
        if(!_isPlayerMover) return;
        // プレイヤーの移動処理を実行
        foreach (var playerMover in _playerMovers)
        {
            playerMover.PlayerUpdate();
        }
    }
}
