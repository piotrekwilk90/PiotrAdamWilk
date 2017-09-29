using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour {
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
   // public GameObject Four;
   // public GameObject Five;
   // public GameObject Six;
    int[] arrayOffloat;
    Vector3 srodek;
    public GameObject psrodek;
    bool losuj;
   
    int i;
    // Use this for initialization
    void Start () {
        losuj = true;
        arrayOffloat = new int[4];
        arrayOffloat[0] = 90;
        arrayOffloat[1] = 180;
        arrayOffloat[2] = 270;
        arrayOffloat[3] = 360;
        srodek = psrodek.transform.position;



        i = 0;
     
    }
    void OnLevelWasLoaded(int level)
    {


      
        One.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);
        Two.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);
        Three.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

    }

    // Update is called once per frame
    void Update () {
      /*  if (losuj == true)
        {
            One.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);
            Two.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);
            Three.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

            losuj = false;
            

        }*/

        /*
       if (Input.GetMouseButtonDown(0))
           if (i == 0)
           {
               One.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);
           }else if (i == 1)
           {
               Two.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

           }
           else if (i == 2)
           {
               Three.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

           }
          else if (i == 3)
           {
               Four.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

           }
           else if (i == 4)
           {
               Five.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

           }
           else if (i == 5)
           {
               Six.transform.RotateAround(srodek, Vector3.up, arrayOffloat[Random.Range(0, 3)]);

           }
           */

        //  One.transform.Rotate(new Vector3(0,1, 0), 90);
        i += 1;

        if (i > 3)
        {
            i = 0;
        }


    }
}
