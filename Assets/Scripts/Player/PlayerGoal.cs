using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Clearscene();
        }
    }
    private void Clearscene()
    {
        SceneManager.LoadScene("Result");
    }
}
