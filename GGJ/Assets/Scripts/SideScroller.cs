using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller : MonoBehaviour {
    public float xSpeed;
    float posX, posY, posZ;
	// Use this for initialization
	void Start ()
    {
        posX = transform.localPosition.x;
        posY = transform.localPosition.x;
        posZ = transform.localPosition.x;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        posX -= Time.fixedDeltaTime * xSpeed;
        transform.localPosition = new Vector3(posX, posY, posZ);
    }
}
