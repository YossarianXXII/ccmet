using UnityEngine;
using System.Collections;

public class Boundary1 : MonoBehaviour {
	private Vector3 v;
	// Use this for initialization
	void Start () {
		v = transform.localScale;
		transform.localScale = Vector3.Scale (v, new Vector3 (GlobalC.getAspect()*1f, 1, 1));

		v = transform.localScale;
	}
	

	void OnTriggerExit(Collider other){
		Vector3 curP = other.gameObject.transform.position;
		if(Mathf.Abs(curP.x)> (v.x/2f))
			other.gameObject.transform.position = new Vector3 (-curP.x , curP.y, curP.z);
		if(Mathf.Abs(curP.z)>(v.z/2f))
			other.gameObject.transform.position = new Vector3 (curP.x , curP.y, -curP.z);
	}

}
