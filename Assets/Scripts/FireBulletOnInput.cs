using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireBulletOnInput : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulSpeed;

    public GameObject bullet;
    //public GameObject gun;

    public Transform bulletTransformPoint;

    public InputActionProperty leftTrigger;
    public InputActionProperty rightTrigger;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (leftTrigger.action.WasPressedThisFrame() || rightTrigger.action.WasPressedThisFrame())
        {
            GameObject SpawnedBullet = Instantiate(bullet);
            SpawnedBullet.transform.position = bulletTransformPoint.position;
            SpawnedBullet.GetComponent<Rigidbody>().AddForce(bulletTransformPoint.forward * bulSpeed * Time.deltaTime, ForceMode.Impulse);
            //SpawnedBullet.GetComponent<Rigidbody>().velocity = bulletTransformPoint.forward * bulSpeed * Time.deltaTime;
            Destroy(SpawnedBullet, 5);
        }
    }
}
