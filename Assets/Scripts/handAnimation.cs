using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionProperty pinchAction;
    public InputActionProperty grabAction;

    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerfloat = pinchAction.action.ReadValue<float>();
        anim.SetFloat("Trigger", triggerfloat);

        float grabfloat = grabAction.action.ReadValue<float>();
        anim.SetFloat("Grip", grabfloat);
    }
}
