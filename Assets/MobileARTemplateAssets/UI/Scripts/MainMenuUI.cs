using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlaySinglePlayer()
    {
        PlayClickSound();
        SceneManager.LoadScene("SinglePlayerGame");
    }

    public void PlayMultiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void PlayGameModeSelection()
    {
        SceneManager.LoadScene("GameModeSelect");
    }


    public void QuitGame()
    {
        PlayClickSound();
        Application.Quit();  
    }

    void PlayClickSound()
    {
        if (audioSource != null)
            audioSource.Play();
    }
}
