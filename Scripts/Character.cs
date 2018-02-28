using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{


    private Rigidbody rb;
    private string moveInputAxis = "Horizontal";
    public float moveSpeed = 2;

    public float fallMultipler = 2.5f;
    public float lowJumpMultipler = 2f;

    private float jumpForce = 4.0f;
    private float jumpTime;
    private int jumpCount;
    bool grounded;

    public Animator animacja;
    private bool isRunning;
    bool isJump;
    bool isJumpRunning;

    public AudioSource dzwiek;
    public AudioClip chodzenie_po_lesie;
    public AudioClip chodzenie_w_budynku;
    public AudioClip skok;

    private float timer;
    public float time;
    bool isBudynek;



    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
 
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
       
        Move();
        Turn(moveAxis);
        Jump();

      

    }
    private void Move()
    {

        animacja.SetBool("RunningStart", isRunning);
       
        if(Input.GetButtonDown(moveInputAxis))
        {
            if(isBudynek==false)
            {
                dzwiek.clip = chodzenie_po_lesie;
                dzwiek.Play();
                dzwiek.volume = 0.1f;
            }
            if (isBudynek == true)
            {
                dzwiek.clip = chodzenie_w_budynku;
                dzwiek.Play();
                dzwiek.volume = 0.5f;
            }


        }
        if (Input.GetButton(moveInputAxis))
        {
            
            transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);
            isRunning = true;
          
           
        }
        else
        {
       
            isRunning = false;
            dzwiek.Pause();
        }
     

      
        
    }
    private void Jump()
    {
        animacja.SetBool("Jump",isJump);
        animacja.SetBool("RunningJump", isJumpRunning);
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultipler - 1) * Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump"))
        {
            dzwiek.Stop();
        
            if (grounded)
            {
                if (isRunning == false)
                {
                    isJump = true;
                    isJumpRunning = false;
                }
                else
                {
                  
                    isJump = false;
                    isJumpRunning = true;

                }
                jumpCount++;
                rb.velocity = Vector3.up * jumpForce;
              
            }
           
           
        }
      if(Input.GetButton("Jump"))
        {
            timer += Time.deltaTime;
            if(timer<=time)
            {
                isRunning = false;
            }
            
            if (grounded)
            {
              
                if (jumpTime < 0.5f)
                {
                                   
                    rb.velocity = Vector3.up * jumpForce;
                    jumpTime += Time.deltaTime;
                }
                else
                {
                    isJumpRunning = false;
                }
            }
          
          
          
        }
    

        if (Input.GetButtonUp("Jump"))
        {
                dzwiek.Play();
                dzwiek.PlayOneShot(skok);
                jumpTime = 0;
                grounded = false;
                isJump = false;
                isJumpRunning= false;
            
                      
        }
          
    }
    private void Turn(float input)
    {
        if (input > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (input < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
    }
   
    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag=="floor")
        {
            grounded = true;
            isBudynek = false;
        }
        if (collision.collider.tag == "cube")
           {
                grounded = true;
                isBudynek = true;
           }
     

    }
   

}
