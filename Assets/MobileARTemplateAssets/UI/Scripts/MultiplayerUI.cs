using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerUI : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
