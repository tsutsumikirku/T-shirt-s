using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHit : MonoBehaviour
{
    [SerializeField] int _score;
    [SerializeField] AudioClip _clip; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Debug.Log(_score + "“_Šl“¾");
            //ScoreManager.Instance.AddScore(_score);
            SoundManager.Instance.PlaySE(_clip);

        }
    }
}
