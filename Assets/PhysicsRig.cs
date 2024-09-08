using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRig : MonoBehaviour
{
    public Transform playerHead;
    public CapsuleCollider bodyCollider;

    public float maxHeight = 2f;
    public float minHeight = 0.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        bodyCollider.height = Mathf.Clamp(playerHead.localPosition.y, maxHeight, minHeight);
        bodyCollider.center = new Vector3 (playerHead.localPosition.x, playerHead.localPosition.y / 2, playerHead.localPosition.z); 
    }
}
