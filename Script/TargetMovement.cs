using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ˆÚ“®‘¬“x
    public float moveRange = 5f; // ˆÚ“®”ÍˆÍ

    private bool isMovingRight = true;

    

    // Update is called once per frame
    void Update()
    {
        float movement = moveSpeed * Time.deltaTime;

        if (isMovingRight)
        {
            transform.Translate(Vector3.right * movement);
        }
        else
        {
            transform.Translate(Vector3.left * movement);
        }

        // ˆÚ“®”ÍˆÍ“à‚Å‰•œ‚·‚é
        if (transform.position.x >= moveRange && isMovingRight)
        {
            isMovingRight = false;
        }
        else if (transform.position.x <= -moveRange && !isMovingRight)
        {
            isMovingRight = true;
        }
    }
}

