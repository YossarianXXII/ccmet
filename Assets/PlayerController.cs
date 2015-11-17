using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public GlobalC gl;



	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(gl.P1_thrust)){
			rb.AddRelativeForce(-Vector3.forward *30f);
		}
		if(Input.GetKey(gl.P1_left)){
			rb.AddRelativeTorque(-Vector3.up *10f);
		}
		if(Input.GetKey(gl.P1_right)){
			rb.AddRelativeTorque(Vector3.up * 10f);
		}
	}
}
