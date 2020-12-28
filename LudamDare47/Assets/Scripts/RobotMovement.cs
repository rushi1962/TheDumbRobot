using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform PlayerBody;
    public Vector3 _playerBody;
    public float speed = 2f;
    public float bodyScale = -1f;
    public float gravity = -10f;
    public float height = 3f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public Vector3 move;
    public bool playerDead;
    public LayerMask groundMask;
    public bool isGrounded;
    public AudioClip shootSFX;
    Vector3 velocity;
   
    // Start is called before the first frame update
    void Start()
    {
        // _playerBody = Vector3.one;
        // _playerBody.z *= bodyScale;
        //  PlayerBody.localScale = _playerBody;
        playerDead = false;
        move = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
       
        if(isGrounded&&velocity.y<0f)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        //print(_playerBody);
        //controller.Move(move*speed*Time.deltaTime);
       // jump();
    }
    public void jump()
    {
        if(isGrounded)
        {
            if (shootSFX)
            {
                if (gameObject.GetComponent<AudioSource>())
                { // the projectile has an AudioSource component
                  // play the sound clip through the AudioSource component on the gameobject.
                  // note: The audio will travel with the gameobject.
                    gameObject.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                }
                else
                {
                    // dynamically create a new gameObject with an AudioSource
                    // this automatically destroys itself once the audio is done
                    AudioSource.PlayClipAtPoint(shootSFX, gameObject.transform.position);
                }
            }
            velocity.y = Mathf.Sqrt(-2f*height*gravity);
        }
    }
}
