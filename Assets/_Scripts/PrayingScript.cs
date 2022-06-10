using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PrayingScript : MonoBehaviour
{


	public GameObject Monster;
	public GameObject Player;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
    	Player.GetComponent<FirstPersonController>().enabled = false;
        this.GetComponent<BoxCollider>().enabled = false;
    	StartCoroutine (ScenePlayer ());
        
    }

     IEnumerator ScenePlayer()
    {

    	Monster.GetComponent<Animation>().Play("Take 001");
    	yield return new WaitForSeconds(7.5f);
    
    	Monster.SetActive(false);
    	Player.GetComponent<FirstPersonController>().enabled = true;

    }
}
