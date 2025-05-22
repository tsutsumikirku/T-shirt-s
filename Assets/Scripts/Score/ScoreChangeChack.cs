using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChangeChack : MonoBehaviour
{
    // Start is called before the first frame update
    public void ScoreChack(int score)
    {
        GameDataManager.Instance.AddScore(score);
    }
}
