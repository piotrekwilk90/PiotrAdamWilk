using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NowaRunda : MonoBehaviour {
   // public GameObject box;
    public Material otherSkybox;
    public Text Czas;
    float CzasGraczaFloat; 
    public GameObject partner;
    
    // Use this for initialization
    void Start () {

//        box.SetActive(false);
	}


  

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {


            //zapisywanie czasu gracza
            TimeCounter sc = partner.GetComponent<TimeCounter>();
            CzasGraczaFloat=sc.CzasWartosc;
            PlayerPrefs.SetFloat("CzasGraczaPierwszaRunda",CzasGraczaFloat);
            PlayerPrefs.Save();
            Debug.Log("Hello");
           // box.SetActive(true);
            SceneManager.LoadScene("Congratulation");
            //RenderSettings.skybox = otherSkybox;

           


        }
    }

    // Update is called once per frame
    void Update () {
     
	}
}
