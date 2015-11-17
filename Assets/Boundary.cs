using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {


	void onTriggerExit(Collider other){

		Destroy (other.gameObject);
		Vector3 curP = other.gameObject.transform.position;
		other.gameObject.transform.position = new Vector3 (-curP.x , curP.y, curP.z);
	}
}
