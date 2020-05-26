using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackwardUI : MonoBehaviour
{

    public static int aux = 0;
    Text BackTargetDistance;
    Robot robot;



    // Start is called before the first frame update
    void Start()
    {   
        BackTargetDistance= GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
                float distance = GameObject.Find("BaseRobot").GetComponent<Robot>().backtargetDistance;
                BackTargetDistance.text= "Backward Distance: " + distance;
    }
}
