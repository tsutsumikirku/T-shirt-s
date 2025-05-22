using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BoxButton : MonoBehaviour, StepOnInterface
{
    [SerializeField] GameObject[] _boxes;
    [SerializeField] int boxlook;

    public void OnStep()
    {
        

        for (int i = 0; i < _boxes.Length; i++)
        {
            _boxes[i].GetComponent<TranparentBox>().Look(boxlook);
           
        }

    }
}
