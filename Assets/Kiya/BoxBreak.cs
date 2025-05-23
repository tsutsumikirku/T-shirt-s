using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBreak : MonoBehaviour, StepOnInterface
{
    [SerializeField] int _boxLife;
    [SerializeField]AudioClip _boxBreakSound;

    public void OnStep()
    {
        Console.WriteLine("Box broken");
        if (_boxBreakSound)
        {
            SoundManager.Instance.PlaySE(_boxBreakSound);
        }
        _boxLife--;
        if (_boxLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
