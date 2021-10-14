using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLaser : MonoBehaviour
{
    

    public Transform laser, pontoA, pontoB;
    public float velocityLaser;
    bool lever = false;

    private Vector3 pontoDestino;
    

    void Start()
    {
        laser.position = pontoA.position;
        pontoDestino = pontoB.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lever)
              MovementLaser();
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Player")
        {
           
            if(lever)
              {
                lever = false;
                laser.position = pontoA.position;
              }
              else lever = true;
            

        }
    }

    void MovementLaser()
    {
        laser.position = Vector3.MoveTowards(laser.position, pontoDestino, velocityLaser * Time.deltaTime);

        if(laser.position == pontoDestino)
        {
            if(pontoDestino == pontoA.position)
            {
                pontoDestino = pontoB.position;
            }
            else if(pontoDestino == pontoB.position)
            {
                pontoDestino = pontoA.position;
            }
        }
    }
}
