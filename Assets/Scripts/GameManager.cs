using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {
        // reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
