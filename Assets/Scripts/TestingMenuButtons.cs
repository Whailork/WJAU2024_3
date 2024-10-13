using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMenuButtons : MonoBehaviour
{
    public AudioClip nextSong;
    public AudioClip btnSound;
    
    public void Play()
    {
        SoundPlayer.instance.SetMusic(nextSong,1F);
        SoundPlayer.instance.PlaySFX(btnSound,2);
    }
    
    public void QuitGame()
    {
        Application.Quit();
        SoundPlayer.instance.PlaySFX(btnSound,2);
    }
    
}
