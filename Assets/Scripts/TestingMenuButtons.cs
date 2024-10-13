using UnityEngine.SceneManagement;
using UnityEngine;

public class TestingMenuButtons : MonoBehaviour
{
    public AudioClip nextSong;
    public AudioClip btnSound;
    
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
        SoundPlayer.instance.SetMusic(nextSong,1F);
        SoundPlayer.instance.PlaySFX(btnSound,2);
    }
    
    public void QuitGame()
    {
        Application.Quit();
        SoundPlayer.instance.PlaySFX(btnSound,2);
    }
    
}
