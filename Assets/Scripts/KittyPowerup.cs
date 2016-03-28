using UnityEngine;
using System.Collections;

public class KittyPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    //this runs whenever anything collides with the brick
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //check if the ball hit us?
        if (collisionInfo.gameObject.name == "Ball" || collisionInfo.gameObject.name == "Kitty")
        {
            print("test");

            GameObject particle = (GameObject)Instantiate(GameObject.Find("KittyPowerupParticles"), transform.position, Quaternion.identity);
            particle.transform.position = transform.position;
            Destroy(particle, 10);

            //starts the process to destroy.
            StartCoroutine(DestroyKittyPowerup());
        }
    }

    IEnumerator DestroyKittyPowerup()
    {

        yield return null;

        //this destroys the brick
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
