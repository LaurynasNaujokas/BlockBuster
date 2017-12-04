using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
	
	paddleToBallVector = this.transfrom.position - paddle.transform.position;
	print (paddleToBallVector);
	
	
	
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
