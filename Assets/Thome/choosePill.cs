using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class choosePill : MonoBehaviour
{
    public GameObject Bpill;
    public GameObject Rpill;
    // public AudioSource pegando;
    // public bool escolheu = false;
    // public bool blue = false;
    // public bool red = false;
    public AudioSource gotBlue;
    public AudioSource gotRed;
    // private Animation anim;
    private string name = "wrongPill";
    public GameObject Player;
    public bool onTrigger;
    public GameObject EndScreen;
    // void start(){
    //     anim = gameObject.GetComponent<Animation>();
    // }
     void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }
    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        
    }

    void Update()
    {
       if(onTrigger){
        if(Input.GetKeyDown(KeyCode.R)){
       
            Destroy(Rpill);
            gotRed.Play();
            Player.GetComponent<Animation>().Play("death");
            Player.GetComponent<FirstPersonController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine(EndGame ());
            
        }
        if(Input.GetKeyDown(KeyCode.B)){
            Destroy(Bpill);
            Player.GetComponent<FirstPersonController>().enabled = false;
            StartCoroutine (ScenePlayer ());
            // anim.Play(name);
        }
        }
        
    }
    void OnGUI()
    {
        if(onTrigger){
            GUI.Box(new Rect(50, 50, 500, 50), "Press 'R' to take red pill. Press 'B' to take blue pill");
        }
    }

    IEnumerator ScenePlayer()
    {
    
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("BlueEnding");
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3f);
        EndScreen.SetActive(true);
    }
}
