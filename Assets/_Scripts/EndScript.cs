using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{

	public GameObject EndScreen;
    // Start is called before the first frame update
    void Start()
    {



    	StartCoroutine(EndScene ());
        
    }

    IEnumerator EndScene()
    {

    	yield return new WaitForSeconds(4f);
    	Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    	EndScreen.SetActive(true);
    }


    public void LoadMenu()
    {

    	SceneManager.LoadScene("MainMenu");

    }


}
