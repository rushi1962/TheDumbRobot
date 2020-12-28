using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMalfunction : MonoBehaviour
{
    public RobotMovement movement;
    public Transform Robot;
    public Vector3 RobotOld,RobotNew;
    public bool forward;
   // public bool playerDead;
    // Start is called before the first frame update
    void Start()
    {
        movement. _playerBody = Vector3.one;
       // movement._playerBody.z *= movement.bodyScale;
        movement.PlayerBody.localScale = movement._playerBody;
        RobotOld = RobotNew = Robot.position;
        forward = true;
    }

    // Update is called once per frame
    void Update()
    {
        RobotNew = Robot.position;
        if(((RobotOld.z+15f)>=RobotNew.z&& RobotNew.z>=(RobotOld.z+14f))&& forward)
        {
            RobotOld = RobotNew;
            movement._playerBody.z *= movement.bodyScale;
            movement.PlayerBody.localScale = movement._playerBody;
            movement.speed *= -1;
            forward = false;
           // movement.jump();
        }
        if((!forward)&& ((RobotOld.z - 5f) <= RobotNew.z && RobotNew.z <= (RobotOld.z - 4f)))
        {
            RobotOld = RobotNew;
            movement._playerBody.z *= movement.bodyScale;
            movement.PlayerBody.localScale = movement._playerBody;
            movement.speed *= -1;
            forward = true;
            movement.jump();
        }
        if(movement.isGrounded)
       {
            movement.controller.Move(movement.move * movement.speed * Time.deltaTime);
           // movement.speed = 0f;
        }
       

        // 
    }
}
