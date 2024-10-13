using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TestingMenuButtons : MonoBehaviour
{
    public AudioClip nextSong;
    public AudioClip btnSound;
    public Button but1;
    public Button but2;
    public Button but3;

    public void LevelOne()
    {
        MapManager.mapManager.currentLevel = 1;
        SceneManager.LoadScene("PlayScene");
    }

    public void LevelTwo()
    {
        MapManager.mapManager.currentLevel = 2;
        SceneManager.LoadScene("PlayScene");
    }

    public void LevelThree()
    {
        MapManager.mapManager.currentLevel = 3;
        SceneManager.LoadScene("PlayScene");
    }

    public void Play()
    {
        SceneManager.LoadScene("levelOptionScene");
        SoundPlayer.instance.PlaySFX(btnSound,2);
    }
    
    public void QuitGame()
    {
        Application.Quit();
        SoundPlayer.instance.PlaySFX(btnSound,2);
    }

    void Start()
    {
        SoundPlayer.instance.SetMusic(nextSong, 1F);
        SoundPlayer.instance.PlaySFX(btnSound, 2);
    }

}