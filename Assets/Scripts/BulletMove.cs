using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	private Rigidbody bullet;


	public float speed; 
	public float lifeTime;

	private float bulletTime;
	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody> ();
		bullet.velocity = new Vector3(transform.forward.x * speed, 0.0f, transform.forward.z * speed);
		bulletTime = Time.time + lifeTime;
		print (bulletTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > bulletTime) {
			Destroy(gameObject);
		}

	}
}
