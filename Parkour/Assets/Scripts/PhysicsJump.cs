using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsJump : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 jumpNormal;
    public float jumpPower = 10f;

    public void Jump(float jump)
    {
        
        _rigidbody.MovePosition(_rigidbody.position + jumpNormal);
    }
}
