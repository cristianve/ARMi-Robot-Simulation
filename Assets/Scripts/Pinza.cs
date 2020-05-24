using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinza : MonoBehaviour
{
    float wristspeed = 10f;
    Vector3 movewristVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movewristVelocity = Vector3.zero;
        MovimientoWrist();
    }

    private void MovimientoWrist()
    {
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            movearmVelocity.z = armspeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movearmVelocity.z = -armspeed;
        }*/

        transform.Translate(movewristVelocity.normalized * Time.deltaTime * wristspeed);

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0.0f, -45.0f * Time.deltaTime, 0.0f);
            //transform.InverseTransformDirection(50.0f*Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0.0f, 45.0f * Time.deltaTime, 0.0f);
        }
    }
}
