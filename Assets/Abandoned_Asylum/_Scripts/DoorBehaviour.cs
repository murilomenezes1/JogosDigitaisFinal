using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorBehaviour : MonoBehaviour
{

	public float Distance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject Door;
	public AudioSource DoorSound;
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {

    	if(Distance <= 2) 
    	{
    		ActionText.GetComponent<Text>().text = "Abrir Porta";
    		ActionDisplay.SetActive(true);
    		ActionText.SetActive(true);
    	}

    	if(Input.GetKeyDown(KeyCode.E))
    	{
    		if (Distance <= 1) {

    			this.GetComponent<BoxCollider>().enabled = false;

    			ActionDisplay.SetActive(false);
    			ActionText.SetActive(false);
    			Door.GetComponent<Animation>().Play("DoorOpening");
    			DoorSound.Play();
    		}
    	}
    }

     void OnMouseExit() 
    {
    	ActionDisplay.SetActive(false);
    	ActionText.SetActive(false);
    }
}