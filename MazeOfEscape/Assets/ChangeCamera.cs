using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {


    public GameObject Camera1;
    public GameObject Camera2;

   
	// Use this for initialization
	void Start () {

        i = 0;
        Camera1.SetActive(true);
        Camera2.SetActive(false);
      
        
    }

    int i;
    void ZmianaKamery()
    {
        if (Input.GetMouseButton(0))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);


        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
    


    }

   
	// Update is called once per frame
	void Update () {

        ZmianaKamery();
      
		
	}
}
