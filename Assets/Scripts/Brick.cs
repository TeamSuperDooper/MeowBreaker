using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
    
    void Awake()
    {
    }

    //this runs whenever anything collides with the brick
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //check if the ball hit us?
        if (collisionInfo.gameObject.name == "Ball" || collisionInfo.gameObject.name == "Kitty")
        {
            //starts the process to destroy.
            StartCoroutine(DestroyBrick());
        }
    }

    //this waits 1 frame then destroys the brick.
    //if you do not use this ienumerator the ball will sometimes go right through the brick without bouncing off.
    IEnumerator DestroyBrick()
    {
        yield return null;

        //this destroys the brick
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        //print((this.transform.parent.childCount - 1) + " Bricks Left");
        if (GameObject.Find("Brick Holder").transform.childCount > 0)
        {
            print((GameObject.Find("Brick Holder").transform.childCount - 1) + " Bricks left");
        }
    }

    //Super kitty destroy all bricks in path
    IEnumerator DestroyBrickKitty()
    {
        //yield return null;

        //this destroys the brick
        Destroy(gameObject);
        yield return null;
    }
}
