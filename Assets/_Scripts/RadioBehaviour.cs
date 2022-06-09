using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioBehaviour : MonoBehaviour
{

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakeRadio;
	public GameObject RealRadio;

    // Update is called once per frame
    void Update()
    {

    	TheDistance = PlayerCasting.DistanceFromTarget;
        
    }

    void OnMouseOver()
    {

    	if (TheDistance <= 1) {

    		ActionText.GetComponent<Text>().text = "Pegar Radio";
    		ActionDisplay.SetActive(true);
    		ActionText.SetActive(true);

    	}

    	if (Input.GetKeyDown(KeyCode.E)) {

    		if (TheDistance <= 1) {

    			this.GetComponent<BoxCollider>().enabled = false;

    			ActionDisplay.SetActive(false);
    			ActionText.SetActive(false);
    			FakeRadio.SetActive(false);
    			RealRadio.SetActive(true);
    		}
    	}
    }

    void OnMouseExit() 
    {
    	ActionDisplay.SetActive(false);
    	ActionText.SetActive(false);
    }
}