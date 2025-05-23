using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoal : MonoBehaviour
{
    public GameObject ClearText;
    [SerializeField] private float _invokeTime = 1.0f;

    private void Start()
    {
        ClearText.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            ClearText.SetActive(true);
            Invoke(nameof(Clearscene), _invokeTime);
        }
    }
    private void Clearscene()
    {
        SceneManager.LoadScene("Credit");
    }
}
