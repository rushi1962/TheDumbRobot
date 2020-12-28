using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillRobot : MonoBehaviour
{
    public Transform PlayerCheck,player;
    public float killRange=0.5f;
    public bool PlayerReached;
    public LayerMask PlayerMask;
    public RobotMovement movement;
    public Animator RobotAnimator;
    public GameObject Explosion;
   // bool playerDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerReached = Physics.CheckSphere(PlayerCheck.position,killRange,PlayerMask);
        if(PlayerReached)
        {
          //  print("Kill Player");
            movement.speed = 0f;
            RobotAnimator.SetBool("dead",true);
            if(!movement.playerDead)
            {
                movement.playerDead = true;
                Instantiate(Explosion, player.position, player.rotation);
            }
            
        }
    }
}
