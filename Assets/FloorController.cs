using UnityEngine;
using System.Collections;

public class FloorController : MonoBehaviour {

	//pass in the PLayer Game Object so we can get its current rotation
	public GameObject player;
	
	private Animator animator;
	
	void Start () {
		animator = this.GetComponent<Animator> ();
	}

	void Update () {
		float rotation = player.transform.rotation.z;
		//set the Rotation parameter
		animator.SetFloat ("Rotation", rotation);
	}
}
