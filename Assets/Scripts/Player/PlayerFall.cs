using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    private float _fallPoint = 0f;
    [SerializeField] private float _playerPoint = -5.0f;
    private void Start()
    {

        
    }
    private void Update()
    {
        _fallPoint = transform.position.y;
        if (_fallPoint < _playerPoint)
        {
            GameDataManager.Instance.PlayerDead();
        }
        
    }
    
}
