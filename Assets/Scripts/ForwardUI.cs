using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForwardUI : MonoBehaviour
{

    public static int aux = 0;
    Text ForwardDistance;
    Robot robot;


    // Start is called before the first frame update
    void Start()
    {
        ForwardDistance= GetComponent<Text>();



    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = GameObject.Find("BaseRobot").GetComponent<Robot>().forwardtargetDistance;
        ForwardDistance.text= "ForwardDistance: " + distance;
  
    }
}
