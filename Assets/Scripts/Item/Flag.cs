using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Flag : MonoBehaviour
{
    public Action oncolliderEnter;
    void OnCollisionEnter2D(Collision2D collision)
    {
        oncolliderEnter?.Invoke();
    }
}
