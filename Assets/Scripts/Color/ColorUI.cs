using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorUI : MonoBehaviour
{
    Image _image;
    void Update()
    {
        _image = GetComponent<Image>();
        _image.color = ColorManager.Instance.NowColor;
    }
}
