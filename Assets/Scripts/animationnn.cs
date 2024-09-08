using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animationnn : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public InputActionProperty gripAction;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAction.action.ReadValue<float>();
        anim.SetFloat("Trigger", pinchValue);

        float grabValue = gripAction.action.ReadValue<float>();
        anim.SetFloat("Grip", grabValue);
    }
}
