using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] string GameSceneName;

    public void RestartGame() 
    {
        SceneManager.LoadScene(GameSceneName);
    }
}
