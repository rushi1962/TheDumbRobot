using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
	
	public float motionMagnitude = 0.1f;

	// Update is called once per frame
	void Update()
	{

		// do the appropriate motion based on the motionState
		
				gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				
		
	}
}
