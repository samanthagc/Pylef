using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            //Destroy(this.gameObject);
            this.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
            Destroy(this.gameObject, 0.5f);
        }
    }
}
