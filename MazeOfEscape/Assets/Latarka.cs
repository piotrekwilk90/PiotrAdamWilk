using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latarka : MonoBehaviour {
    public Light Lighter;

    float i = 0;
	// Use this for initialization
	void Start () {
        Lighter.intensity = 0.79f;
    

    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Lighter.intensity = 0.0f;
        // Code to execute after the delay
        yield return new WaitForSeconds(time);
        Lighter.intensity = 0.05f;
        yield return new WaitForSeconds(time);
        Lighter.intensity = 0.5f;
        yield return new WaitForSeconds(time);
        Lighter.intensity = 0.2f;
        yield return new WaitForSeconds(time);
        Lighter.intensity = 0.8f;

    }
    
    void ZepsutaLatarka()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Lighter.intensity = 0.0f;
            StartCoroutine(ExecuteAfterTime(0.1f));
        }
    }

	// Update is called once per frame
	void Update () {

        ZepsutaLatarka();

    }



}
