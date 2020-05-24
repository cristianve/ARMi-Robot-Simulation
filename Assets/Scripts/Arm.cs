using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    // Start is called before the first frame update
    float armspeed = 20f;
    Vector3 movearmVelocity;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movearmVelocity = Vector3.zero;
        MovimientoArm();
    }

    private void MovimientoArm()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // movearmVelocity.z = armspeed;
            transform.Rotate(armspeed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //  movearmVelocity.z = -armspeed;
            transform.Rotate(-armspeed * Time.deltaTime, 0.0f, 0.0f);
        }

        transform.Translate(movearmVelocity.normalized * Time.deltaTime * armspeed);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, -45.0f * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, 45.0f * Time.deltaTime, 0.0f);
        }
    }
}
