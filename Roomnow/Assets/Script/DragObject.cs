using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 moffset;

    private float mZCoord;
    private bool facingRight = true;
    private bool dragObjectYet = true;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        // Store offset = gameobject world pos - mouse world pos 
        moffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        //pixel coordinates (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    private void OnMouseDrag()
    {
        if (dragObjectYet)
        {
            float moveInput = Input.GetAxisRaw("Horizontal");

            if (moveInput < 0 && facingRight)
            {
                flip();
            }
            if (moveInput > 0 && !facingRight)
            {
                flip();
            }
        }
        transform.position = GetMouseWorldPos() + moffset;

        if (Input.GetKey(KeyCode.Delete))
        {
            Destroy(gameObject);
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0 );

    }
}