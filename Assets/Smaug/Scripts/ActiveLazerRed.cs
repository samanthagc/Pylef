using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLazerRed : MonoBehaviour
{
  public GameObject[] gameObject;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {

            
           
   
      for(var i = 0 ; i < gameObject.Length ; i ++)
        {
            
            if(gameObject[i].activeSelf) 
             {
                
                gameObject[i].SetActive(false);
             }
            else 
            {
               
               gameObject[i].SetActive(true);
            }

         
        }

            

        }
    }
}
    

