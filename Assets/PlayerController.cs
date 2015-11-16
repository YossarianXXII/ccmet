using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public KeyCode thrust;
	public KeyCode left;
	public KeyCode right;

	public KeyCode shoot;
	public KeyCode special;


	public GameObject player;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		//Set default controls
		thrust = KeyCode.UpArrow;
		left = KeyCode.LeftArrow;
		right = KeyCode.RightArrow;
		shoot = KeyCode.Z;
		special = KeyCode.X;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(thrust)){
			rb.AddRelativeForce(-Vector3.forward *30f);
		}
		if(Input.GetKey(left)){
			rb.AddRelativeTorque(-Vector3.up *10f);
		}
		if(Input.GetKey(right)){
			rb.AddRelativeTorque(Vector3.up * 10f);
		}
	}
}
