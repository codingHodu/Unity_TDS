using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rigidBody;
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 moveDir, float velocity)
    {
        rigidBody.MovePosition(transform.position + moveDir * velocity * Time.fixedDeltaTime);
    }



}
