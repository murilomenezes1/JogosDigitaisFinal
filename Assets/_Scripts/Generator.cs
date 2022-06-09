using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
   
	public float Distance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject GeneratorBox;
	public AudioSource GeneratorSound;
	public GameObject PC;
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {

    	if(Distance <= 2) 
    	{
    		ActionText.GetComponent<Text>().text = "Ligar Energia";
    		ActionDisplay.SetActive(true);
    		ActionText.SetActive(true);
    	}

    	if(Input.GetKeyDown(KeyCode.E))
    	{
    		if (Distance <= 1) {

    			this.GetComponent<BoxCollider>().enabled = false;

    			ActionDisplay.SetActive(false);
    			ActionText.SetActive(false);
    			PC.SetActive(true);
    			GeneratorSound.Play();

    		}
    	}
    }

     void OnMouseExit() 
    {
    	ActionDisplay.SetActive(false);
    	ActionText.SetActive(false);
    }
}
