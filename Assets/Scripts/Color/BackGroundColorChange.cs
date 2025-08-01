using UnityEngine;

public class BackGroundColorChange : MonoBehaviour
{
    [SerializeField] private int _colorLength = 0;
    [SerializeField] private int _color = 0;
    [SerializeField] AudioClip _audioClip;
    // Start is called before the first frame update
    void Start()
    {
        _colorLength = ColorManager.Instance.Colors.Length;
        ColorManager.Instance.SetBackGroundColor(_color);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
    }
    private void ChangeColor()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            _color++;
            _color = _color % _colorLength;
            ColorManager.Instance.SetBackGroundColor(_color);
            SoundManager.Instance.PlaySE(_audioClip);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            _color--;
            if (_color < 0)
            {
                _color = _colorLength - 1;
            }
            ColorManager.Instance.SetBackGroundColor(_color);
            SoundManager.Instance.PlaySE(_audioClip);
        }
    }
}
