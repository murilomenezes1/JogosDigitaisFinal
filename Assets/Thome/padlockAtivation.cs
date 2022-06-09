using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class padlockAtivation : MonoBehaviour
{
    public string curPassword = "2718";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform doorHinge;
    public Transform doorHinge2;
    public AudioSource source;
    // public GameObject Player;
    private bool flag = false;
 
    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        // Player.GetComponent<MouseLook>().m_MouseLookenabled = false;
        //Player.GetComponent<FirstPersonController>().enabled = false;
    }
 
    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
        //Player.GetComponent<FirstPersonController>().enabled = true;
    }
 
    void Update()
    {

        
        if(input == curPassword)
        {
            doorOpen = true;
            source.Play();
            
        }
 
        if(doorOpen)
        {
            new WaitForSeconds(5);
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -400.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
            var newRot2 = Quaternion.RotateTowards(doorHinge2.rotation, Quaternion.Euler(0.0f, -40.0f, 0.0f), Time.deltaTime * 250);
            doorHinge2.rotation = newRot2; 
        }
        if(Input.GetKeyDown(KeyCode.Alpha0)){
            input = input + "0";
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            input = input + "1";
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            input = input + "2";
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            input = input + "3";
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
            input = input + "4";
        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
            input = input + "5";
        }
        if(Input.GetKeyDown(KeyCode.Alpha6)){
            input = input + "6";
        }
        if(Input.GetKeyDown(KeyCode.Alpha7)){
            input = input + "7";
        }
        if(Input.GetKeyDown(KeyCode.Alpha8)){
            input = input + "8";
        }
        if(Input.GetKeyDown(KeyCode.Alpha9)){
            input = input + "9";
        }
    }
 
    void OnGUI()
    {
        if(!doorOpen)
        {
            if(onTrigger)
            {
                // Player.m_MouseLook.lockCursor = false;
                // Player.GetComponent<MouseLook>().m_MouseLook.enabled = false;
                GUI.Box(new Rect(60, 60, 200, 25), "Press 'E' to open keypad");
 
                if(Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }
 
            if(keypadScreen)
            {
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect(5, 5, 310, 25), input);
                GUI.Button(new Rect(5, 35, 100, 100), "1");
                GUI.Button(new Rect(110, 35, 100, 100), "2");
                GUI.Button(new Rect(215, 35, 100, 100), "3");
                GUI.Button(new Rect(5, 140, 100, 100), "4");
                GUI.Button(new Rect(110, 140, 100, 100), "5");
                GUI.Button(new Rect(215, 140, 100, 100), "6");
                GUI.Button(new Rect(5, 245, 100, 100), "7");
                GUI.Button(new Rect(110, 245, 100, 100), "8");
                GUI.Button(new Rect(215, 245, 100, 100), "9");
                GUI.Button(new Rect(110, 350, 100, 100), "0");

 
            }
        }
    }

}
