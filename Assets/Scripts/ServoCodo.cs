using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServoCodo : MonoBehaviour
{
	float armspeed = 20f;
	Vector3 movearmVelocity;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Z))
		{
			// movearmVelocity.z = armspeed;
			transform.Rotate(armspeed * Time.deltaTime, 0.0f, 0.0f);
		}
		else if (Input.GetKey(KeyCode.X))
		{
			// movearmVelocity.z = armspeed;
			transform.Rotate(-armspeed * Time.deltaTime, 0.0f, 0.0f);
		}

	}
}