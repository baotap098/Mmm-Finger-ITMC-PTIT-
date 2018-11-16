using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigidbody2D;
    // Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, speed));
	}
}
