using UnityEngine;
using System.Collections;

public class LayBricks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		//bricklayer.layer = 1;
		//bricklayer.SetActive(true);
		for (int i = -139; i < 221+16; i=i+16) {
			GameObject bricklayer = (GameObject)Instantiate (GameObject.Find ("PinkBrickTemplate"), new Vector3 (-111,118,0), Quaternion.identity);
			bricklayer.transform.position = new Vector3 (i, 110, 0);
			//transform.position = transform.position;
		}

		for (int i = -139; i < 221+16; i=i+16) {
			GameObject bricklayer = (GameObject)Instantiate (GameObject.Find ("BlueBrickTemplate"), new Vector3 (-111,118,0), Quaternion.identity);
			bricklayer.transform.position = new Vector3 (i, 102, 0);
			//transform.position = transform.position;
		}

		for (int i = -139; i < 221+16; i=i+16) {
			GameObject bricklayer = (GameObject)Instantiate (GameObject.Find ("CyanBrickTemplate"), new Vector3 (-111,118,0), Quaternion.identity);
			bricklayer.transform.position = new Vector3 (i, 94, 0);
			//transform.position = transform.position;
		}

		for (int i = -139; i < 221+16; i=i+16) {
			GameObject bricklayer = (GameObject)Instantiate (GameObject.Find ("DarkBlueBrickTemplate"), new Vector3 (-111,118,0), Quaternion.identity);
			bricklayer.transform.position = new Vector3 (i, 86, 0);
			//transform.position = transform.position;
		}

		for (int i = -139; i < 221+16; i=i+16) {
			GameObject bricklayer = (GameObject)Instantiate (GameObject.Find ("GreenBrickTemplate"), new Vector3 (-111,118,0), Quaternion.identity);
			bricklayer.transform.position = new Vector3 (i, 78, 0);
			//transform.position = transform.position;
		}

		print ("hello???");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
