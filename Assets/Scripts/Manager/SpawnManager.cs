using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] Flag[] _spawnObjects;
    public Flag[] SpawnObject { get => _spawnObjects; }
    void Awake()
    {
        GameDataManager.Instance.SpawnManager = this;
    }
}
