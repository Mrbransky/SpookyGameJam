using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float walkSpeed;
    public float maxSpeed;
    private float curSpeed;
    private Vector2 pos;
    private GameObject currentRoom;
    public GameObject interactable;
	void Awake () {

        currentRoom = GameObject.FindGameObjectWithTag("Room");

	}
	void FixedUpdate () {

        curSpeed = walkSpeed;
        maxSpeed = curSpeed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
        pos.x = Mathf.Clamp(transform.position.x, currentRoom.transform.position.x - 11.0f, currentRoom.transform.position.x + 11.0f);
        pos.y = Mathf.Clamp(transform.position.y, currentRoom.transform.position.y - 4.0f, currentRoom.transform.position.y + 4.0f);
        transform.position = pos;

	}
    void Update()
    {
        //interactable
    }
}
