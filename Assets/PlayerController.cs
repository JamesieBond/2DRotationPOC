using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float rotationSpeed;
	
	void Update () {
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		// Rotate around our z-axis
		transform.Rotate (0, 0, -rotation);
	}
}
