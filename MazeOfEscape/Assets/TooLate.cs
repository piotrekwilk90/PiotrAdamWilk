using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TooLate : MonoBehaviour
{

    public string Runda;
    // Use this for initialization
    void Start()
    {

        


    }
    



    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
         
                //Ładowanie Nastepnej Rundy
                SceneManager.LoadScene(Runda);

            
        }


    }
}
