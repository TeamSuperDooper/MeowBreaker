using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    class Init : MonoBehaviour
    {
        void Start()
        {
            print(GameObject.Find("Brick Holder").transform.childCount);
        }
    }
}
