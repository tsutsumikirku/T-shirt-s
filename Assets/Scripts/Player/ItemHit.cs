using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHit : MonoBehaviour,StepOnInterface
{
    [SerializeField] int _score;
    [SerializeField] AudioClip _clip;

    public void OnStep()
    {
        GameDataManager.Instance.AddScore(_score);
        SoundManager.Instance.PlaySE(_clip);
        gameObject.SetActive(false);
    }
}
