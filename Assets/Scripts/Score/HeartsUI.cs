using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    Text _textUI;
    void Start()
    {
        _textUI = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _textUI.text = "       ×" + GameDataManager.Instance.Remaing.ToString("00");
    }
}
