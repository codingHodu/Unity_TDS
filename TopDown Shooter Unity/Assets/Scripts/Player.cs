using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    PlayerController playerController;
    public float moveSpeed = 5;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        Vector3 moveDir = new Vector3(
            Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        playerController.Move(moveDir, moveSpeed);

        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //float distanceTo
        //if(plane.Raycast(ray, )


    }
}
