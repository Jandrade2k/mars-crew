using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public Animator playerAnimator;
    public float speed = 3.5f;
    float inputX = 0;
    float inputY = 0;
    bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
       isWalking = false; 

    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        isWalking = (inputX != 0 || inputY != 0);

        if(isWalking) {
           var move = new Vector3(inputX, inputY, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("input_x", inputX);
            playerAnimator.SetFloat("input_y", inputY);
        }

        playerAnimator.SetBool("isWalking", isWalking);

        // if(Input.GetKeyDown('e')){
        //     playerAnimator.setTrigger('interact');
        // }
    }
}
