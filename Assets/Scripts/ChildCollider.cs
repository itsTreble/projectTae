using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        //this.collider2D.attachedRigidbody.SendMessage("OnCollisionEnter2D", collision);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("triggerd in child");
        //gameObject.GetComponentInParent<Rigidbody2D>().SendMessage("OnTriggerEnter2D", collision);

    }
}
