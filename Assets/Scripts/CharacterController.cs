using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    bool onGround = false;
    public float moveSpeed = 7f;
    public GameObject currentInteractable = null;
    bool move = true;
	// Use this for initialization
	void Start () {
		
	}
	public void SetMoveTrue()
    {
        move = true;
    }
    public void SetMoveFalse()
    {
        Debug.Log("call false");
        move = false;
    }
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp("e") && currentInteractable)
        {
            //Debug.Log("yep submitting and interacting");
            currentInteractable.GetComponentInParent<IInteractable>().Interact();
        }
        if(move)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
            }
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
            }
            else if (Input.GetAxisRaw("Vertical") < 0)
            {
                transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
            }
        }

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("yay");
        //if (Input.GetButtonUp("Submit"))
        //{
        //    //currentInteractable = other.gameObject;
        //    if(other.tag == "Interactable")
        //    Debug.Log("enterbutton");
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("trigger on parent" + collision.tag);
        if (collision.tag == "Interactable")
        {
            currentInteractable = collision.gameObject;
            //Debug.Log("interactable yo");
        }
        //Debug.Log("jkfdls");

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Interactable")
        {
            currentInteractable = null;
        }
    }
}
