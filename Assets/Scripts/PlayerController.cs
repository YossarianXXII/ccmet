using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public GlobalC gl;
	public GameObject shot;
	public Transform shotSpawn;

	private Rigidbody rb;

	public float fireRate;
	private float nextFire;
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
		if(Input.GetMouseButton(0) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}
