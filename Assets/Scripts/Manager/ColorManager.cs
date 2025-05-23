using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// カラーのマネージャークラス(シングルトンパターン)
/// </summary>
public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;
    [SerializeField] Color[] colors;
    public Color[] Colors { get => colors; }
    public Color NowColor { get => Camera.main.backgroundColor; }
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }
    void OnDisable()
    {
        Instance = null;
    }
    public void SetBackGroundColor(int colorIndex)
    {
        Camera.main.backgroundColor = colors[colorIndex];
    }
}
