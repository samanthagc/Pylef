using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{   
    
    public float speed = 2.5f;
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer sprite;

    public bool isGrounded;

    private int nJump=2;
    private int nJumpAtual=2;
    public float jumpSpeed = 5f;


   
    
    
    
    private Vector3 movement;


    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer> ();
        
    }

  
    void Update()
    {
        Move();



      if(isGrounded)
      {
         

          if(Input.GetButtonDown("Jump"))
          {
              Jump();
             
          }
      }
      else{
          if(Input.GetButtonDown("Jump") && nJump > 0)
          {
              nJump--;
              Jump();
              Debug.Log(nJump);
              Debug.Log(isGrounded);
              
          }
      }
        

      
        
    }
   
    void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

       
        if(Input.GetAxis("Horizontal") > 0.01f)
        {
        
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if(Input.GetAxis("Horizontal") < 0.01f)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if(Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("run", false);
        }
        
    }

    void Jump()
    {
        
        rig.velocity = Vector2.up * jumpSpeed;

        
             
    }

         

  
    
   

   

    


   

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


  
     private void OnTriggerExit2D(Collider2D collision) {
        {
            if(collision.gameObject.layer == 28)//mudar para camada
            {
                isGrounded = false;
            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        {
            if(collision.gameObject.layer == 28)
            {
                isGrounded = true;
                nJump = nJumpAtual;
            }
             if(collision.gameObject.tag == "JumpExtra")
            {
               Destroy(collision.gameObject);
                nJumpAtual *= 2;
            }
        }
    }



    
    

    
}

