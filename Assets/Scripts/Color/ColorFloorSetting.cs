using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFloorSetting : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetColor(int colorIndex)
    {
        _spriteRenderer.color = ColorManager.Instance.Colors[colorIndex];
    }
}
