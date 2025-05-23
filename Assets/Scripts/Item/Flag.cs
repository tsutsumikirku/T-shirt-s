using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Flag : MonoBehaviour
{
    public Action oncolliderEnter;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Call the method when the player collides with the flag
            oncolliderEnter?.Invoke();
        }
    }
}
