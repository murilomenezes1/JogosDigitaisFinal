using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Opening : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    void Start()
    {
    	StartCoroutine (ScenePlayer ());
        
    }

    IEnumerator ScenePlayer()
    {
    
    	Camera.GetComponent<Animation>().Play("OpeningAnim");
    	yield return new WaitForSeconds(12f);
    
    	Camera.SetActive(false);
    	Player.SetActive(true);

    }

}
