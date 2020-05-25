using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Forward : MonoBehaviour
{

    public static int aux = 0;
    Text ForwardDistance;



    // Start is called before the first frame update
    void Start()
    {
        ForwardDistance= GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        ForwardDistance.text= "ForwardDistance: " + aux;
  
    }
}
