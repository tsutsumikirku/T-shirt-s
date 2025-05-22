using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetting : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    [SerializeField] int _colorIndex = 0;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = ColorManager.Instance.Colors[_colorIndex];
    }
}
