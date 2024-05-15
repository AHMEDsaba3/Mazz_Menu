using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManu : MonoBehaviour
{
public void PlayGame(){
    SceneManager.LoadSceneAsync(1);
}
    public AudioSource audio;
    public void QuitGame()
    {
        Application.Quit();
    }
    public void playButton()
    {
        audio.Play();
    }
}
