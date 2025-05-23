using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIUpdate : MonoBehaviour
{
    Text _text;
    void Start()
    {
        _text = GetComponent<Text>();
    }
    void Update()
    {
        _text.text = "Score : " + GameDataManager.Instance.Score.ToString("0000");
    }
}
