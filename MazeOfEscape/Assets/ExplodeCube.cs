using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeCube : MonoBehaviour {
   public Rigidbody p;
    public GameObject BOX;
    private bool Generuj;
    private int i;
    GameObject[] Obiekty;
  
    // Use this for initialization
    void Start () {
        Generuj = false;

        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Obiekty = GameObject.FindGameObjectsWithTag("Cuby");
        if (Obiekty.Length > 70)
        {
        


        }

       
        if (Input.GetMouseButtonDown(0))
        {

            if (Obiekty.Length<250)
            {

                
                //Generuj = false;
                Rigidbody clone;
                clone = Instantiate(p, transform.position, transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(Vector3.forward * 10);

                Destroy(clone.gameObject, 25);

                Debug.Log(Obiekty.Length);
            }
         
                
            }

    }


}
