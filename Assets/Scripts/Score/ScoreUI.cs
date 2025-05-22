using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
     Text _scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        _scoreUI = GetComponent<Text>();
        ScoreManager.Instance.OnScoreChanged += ScoreUIUpdate;
    }
    public void ScoreUIUpdate(int score)
    {
        Debug.Log("Score");
        _scoreUI.text="ScoreÅF" + score;
    }
}
