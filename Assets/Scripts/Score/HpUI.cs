using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUI : MonoBehaviour
{
    [SerializeField] GameObject[] _hpIcons;
    void Update()
    {
        if (GameDataManager.Instance.HP == 3)
        {
            _hpIcons[0].SetActive(true);
            _hpIcons[1].SetActive(true);
            _hpIcons[2].SetActive(true);
        }
        else if (GameDataManager.Instance.HP == 2)
        {
            _hpIcons[0].SetActive(true);
            _hpIcons[1].SetActive(true);
            _hpIcons[2].SetActive(false);
        }
        else if (GameDataManager.Instance.HP == 1)
        {
            _hpIcons[0].SetActive(true);
            _hpIcons[1].SetActive(false);
            _hpIcons[2].SetActive(false);
        }
        else
        {
            _hpIcons[0].SetActive(false);
            _hpIcons[1].SetActive(false);
            _hpIcons[2].SetActive(false);
        }
    }
}
