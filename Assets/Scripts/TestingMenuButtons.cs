using UnityEngine.SceneManagement;
using UnityEngine;

public class TestingMenuButtons : MonoBehaviour
{
    public AudioClip nextSong;
    public AudioClip btnSound;
    
    public void LevelOne()
    {
        //SceneManager.LoadScene("");
        SoundPlayer.instance.SetMusic(nextSong,1F);
        SoundPlayer.instance.PlaySFX(btnSound,2);
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
    
}
