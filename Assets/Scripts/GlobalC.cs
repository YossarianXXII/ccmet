using UnityEngine;
using System.Collections;

public class GlobalC : MonoBehaviour {

	public KeyCode P1_thrust;
	public KeyCode P1_left;
	public KeyCode P1_right;
	
	public KeyCode P1_shoot;
	public KeyCode P1_special;

	public float maxX,minX,maxY,minY;

	public static float getAspect(){
		return (float)(Screen.width) / (float)(Screen.height);
	}
	// Use this for initialization
	void Start () {
		//Set default controls
		P1_thrust = KeyCode.W;
		P1_left = KeyCode.A;
		P1_right = KeyCode.D;
		P1_shoot = KeyCode.Space;
		P1_special = KeyCode.LeftControl;

		print (Screen.width + " " + Screen.height);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


public class EdgeBehavior{

}