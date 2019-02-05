using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float SPEED_MULTIPLIER = 0.4f;
	void Update ()
    {

    //keyboard
    float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        gameObject.transform.position += new Vector3(horizontal, vertical, 0) * SPEED_MULTIPLIER;


        //mouse
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x,
                                        mousePosition.y - transform.position.y);
        transform.up = direction;
    }
}
