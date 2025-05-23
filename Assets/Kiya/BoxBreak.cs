using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBreak : MonoBehaviour, StepOnInterface
{
    [SerializeField] int _boxLife;

    public void OnStep()
    {
        Console.WriteLine("Box broken");
        _boxLife--;
        if (_boxLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
