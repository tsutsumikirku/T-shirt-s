using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] _spawnObjects;
    public GameObject[] SpawnObject { get => _spawnObjects; }
    
}
