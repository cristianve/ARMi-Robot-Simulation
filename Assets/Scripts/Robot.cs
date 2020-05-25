using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    public Transform obj;

  

  
    public bool proximo = false;
    public bool Detproximo = false;
    public float distance;
    public float forwardtargetDistance;
    public float backtargetDistance;
    [Range(41.0f, 60.0f)]
    public float mindistance = 41.0f;
    [Range(10.0f, 20.0f)]
    public float moveSpeed;
    public GameObject robot;
    public GameObject Objeto1;
    Vector3 moveVelocity;

    [Header("Sensors")]
    public float sensorLength = 3f;
    public float frontSensorPosition = 0.5f;
    public float frontsideSensorPosition = 0.2f;
    public float frontSensorAngle = 30;

   

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 20f;
        backtargetDistance = mindistance+1;
        forwardtargetDistance = mindistance+1;
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento horizontal/vertical
        //transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

      
        moveVelocity = Vector3.zero;

        Movimiento();
        Sensors();
        /*if(obj)
        {
            Vector3 Gap = obj.position - transform.position;
            float distance = Gap.sqrMagnitude;

            if(distance < mindistance * mindistance)
            {
                print(distance);
            }

            
        }*/

        /*distance = Vector3.Distance(this.transform.position, Objeto1.transform.position);

         if (distance != 20)
         {
             Debug.Log(distance);
             distance = 20;
             transform.position = (transform.position - Objeto1.transform.position).normalized * distance + Objeto1.transform.position;
         }*/


        //float dist = Vector3.Distance(obj.position, transform.position);
        //print("Distance to other: " + dist);



        //float dist = Vector3.Distance(other.transform.position, transform.position);

        //print("distance" + dist);

        RaycastHit TheForwardHit;
        RaycastHit TheBackHit;
        Ray forwardRay = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
        Ray backRay = new Ray(transform.position, transform.TransformDirection(Vector3.back));

        if (Physics.Raycast (forwardRay, out TheForwardHit))
        {
            forwardtargetDistance = TheForwardHit.distance;
        }
        if (Physics.Raycast (backRay, out TheBackHit))
        {
            backtargetDistance = TheBackHit.distance;
        }


        if ( forwardtargetDistance < mindistance)
        {
            Debug.Log ("Alerta objeto próximo");
            proximo = true;
        } else proximo = false;

        if ( backtargetDistance < mindistance)
        {
            Debug.Log ("Alerta objeto próximo");
            Detproximo = true;
        } else Detproximo = false;


        //distance = Vector3.Distance(robot.transform.position, Objeto1.transform.position);
        //if (distance < mindistance)
        //{
        //    Debug.Log ("Alerta objeto próximo");
        //    proximo = true;
        //} else proximo = false;
         
    }

    private void Movimiento()
    {
        if ((Input.GetKey(KeyCode.W) && (proximo==false)) )
        {
            moveVelocity.z = moveSpeed;
        }
        else if ((Input.GetKey(KeyCode.S) && (Detproximo==false)))
        {
            moveVelocity.z = -moveSpeed;
        }

        transform.Translate(moveVelocity.normalized * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -45.0f * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 45.0f * Time.deltaTime, 0.0f);
        }
    }

    private void Sensors()
    {
        RaycastHit hit;
        Vector3 sensorStartPos = transform.position;
        sensorStartPos.z += frontSensorPosition;

        //sensor frontal centro
        if(Physics.Raycast(sensorStartPos, transform.forward, out hit, sensorLength))
        {

        }
        Debug.DrawLine(sensorStartPos, hit.point);

        //sensor frontal derecha
        /*sensorStartPos.x += frontsideSensorPosition;
        if (Physics.Raycast(sensorStartPos, transform.forward, out hit, sensorLength))
        {

        }
        Debug.DrawLine(sensorStartPos, hit.point);

        //sensor frontal izquierda
        sensorStartPos.x -= 2* frontsideSensorPosition;
        if (Physics.Raycast(sensorStartPos, transform.forward, out hit, sensorLength))
        {

        }
        Debug.DrawLine(sensorStartPos, hit.point);
        */
    }
}
