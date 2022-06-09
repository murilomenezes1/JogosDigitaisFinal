using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerBehaviour : MonoBehaviour
{
   
	public float Distance;
    public GameObject Player;
    public GameObject PlayerCamera;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public AudioSource PCSound;
    public GameObject passwordCanvas;
    public GameObject PC_camera;
    public GameObject PasswordInput;
    public bool passwordCheck;
    public string password = "2751";
    public GameObject ElevatorDoor;
    public AudioSource CorrectSound;

    public bool passwordPass;
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;


        if (passwordCheck && passwordPass == false)
        {
            this.GetComponent<BoxCollider>().enabled = false;
            Player.SetActive(false);
            PlayerCamera.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            passwordCanvas.SetActive(true);
            PC_camera.SetActive(true);

            ActionText.GetComponent<Text>().text = "Digite a Senha";
            //ActionDisplay.SetActive(true);
            ActionText.SetActive(true);

            if (PasswordInput.GetComponent<Text>().text == password && Input.GetKeyDown(KeyCode.Return))
            {

               

                ActionText.SetActive(false);
                PC_camera.SetActive(false);
                CorrectSound.Play();
                Player.SetActive(true);
                this.GetComponent<BoxCollider>().enabled = true;
                PlayerCamera.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                passwordCanvas.SetActive(false);
                ElevatorDoor.SetActive(false);
                passwordPass = true;

            }

        }
    }

    void OnMouseOver()
    {

    	if(Distance <= 2) 
    	{
    		ActionText.GetComponent<Text>().text = "Acessar Computador";
    		ActionDisplay.SetActive(true);
    		ActionText.SetActive(true);
    	}

    	if(Input.GetKeyDown(KeyCode.E))
    	{
    		if (Distance <= 1) {


                passwordCheck = true;
                PCSound.Play();

    			

    		}
    	}
    }

     void OnMouseExit() 
    {
    	ActionDisplay.SetActive(false);
    	ActionText.SetActive(false);
    }
}
