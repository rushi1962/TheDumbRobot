using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform player;
    public RobotMovement movement;
    public Animator RobotAnimator;
    public GameObject Explosion;
    // Start is called before the first frame update
    void Update()
    {
       // print("Entered"); 
        if(player.position.y<=-10f)
        {
            movement.speed = 0f;
            RobotAnimator.SetBool("dead", true);
            if (!movement.playerDead)
            {
                movement.playerDead = true;
               // movement.gravity = 0f;
                Instantiate(Explosion, player.position, player.rotation);
            }
        }
    }
}
