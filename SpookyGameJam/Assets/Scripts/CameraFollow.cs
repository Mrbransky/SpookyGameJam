using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public float soDampSoMoistSoFast;
    private Vector3 yVel = Vector3.zero;
    private Vector2 playerPos;
    private Vector2 cameraPos;

	void FixedUpdate () {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        cameraPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
        transform.position = Vector3.SmoothDamp(cameraPos, playerPos, ref yVel, soDampSoMoistSoFast);
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f);


	}
}
