using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public float moveSpeed = 4f;
    public VariableJoystick joystick;
    public Animator anim;
    private bool turnLeft;
    private bool turnRight;

    private void FixedUpdate()
    {
        MovePlayer();
    }
    public void TurnRight()
    {
        turnRight = true;
    }
    public void TurnLeft()
    {
        turnLeft = true;
    }
    public void MovePlayer()
    {
        transform.position += new Vector3(joystick.Horizontal, joystick.Vertical, 0) * moveSpeed * Time.deltaTime;
        anim.SetFloat("speed",Mathf.Abs(joystick.Horizontal) + Mathf.Abs(joystick.Vertical));
        if (joystick.Horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (joystick.Horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

}
