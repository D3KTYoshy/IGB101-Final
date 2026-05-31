using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    
    private Animator doorAnimator;

   
    void Start()
    {
        
        doorAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            doorAnimator.SetTrigger("Open");
        }
    }
}