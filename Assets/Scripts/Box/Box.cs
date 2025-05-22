using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, StepOnInterface
{
    int _stepCount;

    [SerializeField, Header("Destroy")]
    public int DestroyCount;

    public void OnStep()
    {
        _stepCount++;

        if (_stepCount >= DestroyCount)
        {
            Destroy(gameObject);
        }
    }

}
