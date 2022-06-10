using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenuUI : MonoBehaviour
{


	public static bool GamePaused = false;

	public GameObject PauseUI;
	public GameObject Player;

	public AudioSource Music;
	//public AudioMixer audioMixer;

	// public void SetVolume(float volume)
	// {
	// 	audioMixer.SetFloat("volume", Mathf.Log(volume)*20f);
	// }

    // Update is called once per frame
    void Update()
    {

    	if (Input.GetKeyDown(KeyCode.Escape))
    	{

    		//if (GamePaused)
    		//{
    		//	Resume();
    		//} else {

    			Pause();
    		//}


    	}
        
    }

    public void Resume()
    {

    	PauseUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    	Time.timeScale = 1f;
    	GamePaused = false;
    	Music.Play();
    	Player.GetComponent<FirstPersonController>().enabled = true;



    }

    public void Pause()
    {

    	PauseUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    	Time.timeScale = 0f;
    	GamePaused = true;
    	Music.Pause();
    	Player.GetComponent<FirstPersonController>().enabled = false;

    }

    public void LoadMenu()
    {

    	SceneManager.LoadScene("MainMenu");

    }
}