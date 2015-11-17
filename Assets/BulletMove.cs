using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
	private Rigidbody bullet;

	public float speed;

	void Start(){
		bullet = GetComponent<Rigidbody> ();
		bullet.velocity = transform.forward * speed;
	}

}
