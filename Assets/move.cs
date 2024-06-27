using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{

    [SerializeField] CharacterController2D characterController;
    //setup animator 
    [SerializeField] Animator animator;
    [SerializeField] float runSpeed = 10f;
    float Horizontal_axis = 0f;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
        Horizontal_axis = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed",Mathf.Abs(Horizontal_axis));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("jump", true);
            jump=true;
        }
        
    }
    private void FixedUpdate()
    {

       characterController.Move(Horizontal_axis*Time.deltaTime,false,jump);
        jump = false;
        animator.SetBool("jump", false);
    }
}
