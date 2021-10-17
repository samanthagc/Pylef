using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlataform : MonoBehaviour
{
    [SerializeField]
    private Sprite[] images;
    [SerializeField]
    private SpriteRenderer sr;

    public Transform plataform, pointA, pointB;
    public float velocityPlataform;

    private Vector3 pointDestiny;
    

    void Start()
    {
        plataform.position = pointA.position;
        pointDestiny = pointB.position;
        sr.sprite = images[1];
    }

    // Update is called once per frame
    void Update()
    {
       

        if(sr.sprite == images[0])
        {
            MovePlataform();
        }
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Player")
        {
           
            sr.sprite = images [0];
            

        }
    }

    void MovePlataform()
    {
        plataform.position = Vector3.MoveTowards(plataform.position, pointDestiny, velocityPlataform * Time.deltaTime);

        if(plataform.position == pointDestiny)
        {
            if(pointDestiny == pointA.position)
            {
                pointDestiny = pointB.position;
            }
            else if(pointDestiny == pointB.position)
            {
                pointDestiny = pointA.position;
            }
        }
    }
}
