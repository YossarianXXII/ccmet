using UnityEngine;
using System.Collections;

public class xCollider : MonoBehaviour {
	
	void OnTriggerEnter(Collider other){
		Vector3 curP = other.gameObject.transform.position;
		other.gameObject.transform.position = new Vector3 (-(curP.x) , curP.y, curP.z);
	}
}
