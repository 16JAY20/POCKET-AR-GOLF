using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeSelector : MonoBehaviour
{
    public void LoadSinglePlayer()
    {
        SceneManager.LoadScene("SinglePlayerGame");
    }

    public void LoadMultiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }
}
