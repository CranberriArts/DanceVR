using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Button ArmButton;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 1.0f;
    }

    public void PlayArmAnimation()
    {
       animator.SetBool("ArmAnimation", true);
        ArmButton.gameObject.SetActive(false);
    }

    public void EndArmAnimation()
    {
        animator.SetBool("ArmAnimation", false);
        ArmButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
