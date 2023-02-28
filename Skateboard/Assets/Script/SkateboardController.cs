using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SkateboardController : MonoBehaviour
{
   
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("SkateboardRoll");
        }
    }
}
