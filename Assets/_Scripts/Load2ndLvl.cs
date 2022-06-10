using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load2ndLvl : MonoBehaviour
{

	public float Distance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject Elevator;
    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {

    	if(Distance <= 2) 
    	{
    		ActionText.GetComponent<Text>().text = "Usar o elevador";
    		ActionDisplay.SetActive(true);
    		ActionText.SetActive(true);
    	}

    	if(Input.GetKeyDown(KeyCode.E))
    	{
    		if (Distance <= 1) {

    			this.GetComponent<BoxCollider>().enabled = false;

    			ActionDisplay.SetActive(false);
    			ActionText.SetActive(false);
                SceneManager.LoadScene("level2");

    			
    		}
    	}
    }

     void OnMouseExit() 
    {
    	ActionDisplay.SetActive(false);
    	ActionText.SetActive(false);
    }
}