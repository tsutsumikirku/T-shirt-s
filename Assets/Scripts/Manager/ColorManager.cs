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
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }
    public void SetBackGroundColor(int colorIndex)
    {
        Camera.main.backgroundColor = colors[colorIndex];
    }
}
