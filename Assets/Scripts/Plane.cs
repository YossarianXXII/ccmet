using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 v = transform.localScale;
		transform.localScale = Vector3.Scale (v, new Vector3 (GlobalC.getAspect()*1f, 1, 1));

		Renderer r = GetComponent<Renderer> ();
		Vector2 ms = r.material.mainTextureScale;
		r.material.mainTextureScale = Vector2.Scale (ms, new Vector2 (GlobalC.getAspect (), 1));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
