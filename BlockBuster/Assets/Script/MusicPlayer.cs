using UnityEngine;
using System.Collections;


public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	
	void Awake () {
	Debug.Log("Music Payer awake " + GetInstanceID());
		if (instance != null){
			Destroy (gameObject);
			print ("Duplicate Music Player was destroyed");
		}else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}


	// Update is called once per frame
	void Update () {
	 
	}
}
