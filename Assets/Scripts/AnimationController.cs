using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Slider slider;
    public Animator idleAnimator, parAnimator;
    private Animator animator;
    private bool animPlaying, settingsToggled;
    public GameObject Play, Pause, SettingsPanel;
    private string animName;
    // Start is called before the first frame update
    void Start()
    {
        parAnimator.speed = 0.0f;
        animator = idleAnimator;
        animator.speed = 0.0f;
        settingsToggled = true;
        ToggleSettings();
    }

    public void pauseAnimation()
    {
        animator.speed = 0;
        animPlaying = false;
        SetPlayButtons(animPlaying);
    }

    void SetPlayButtons(bool animPlaying)
    {
        Pause.SetActive(animPlaying);
        Play.SetActive(!animPlaying);
    }

    public bool isAnimPlaying()
    {
        return animPlaying;
    }

    public void ResetAnimation()
    {
        animator.speed = 0;
        animPlaying = false;
        slider.normalizedValue = 0;
        SetPlayButtons(animPlaying);
    }

    public void ToggleSettings()
    {
        settingsToggled = !settingsToggled;
        SettingsPanel.SetActive(settingsToggled);
    }

    public void sliderChange()
    {
        if (animName != null && !animPlaying)
        {
            Debug.Log("Slider changing");
            animator.Play(animName, 0, slider.normalizedValue);
        }

    }

    public void LoadArmAnimation()
    {
        ResetAnimation();
        animator.SetBool(animName, false);
        animator.gameObject.SetActive(false);
        idleAnimator.gameObject.SetActive(true);
        animator = idleAnimator;
        animator.SetBool("ArmAnimation", true);
        animName = "ArmAnimation";
    }

    public void Load1stToPar()
    {
        ResetAnimation();
        animator.SetBool(animName, false);
        animator.gameObject.SetActive(false);
        parAnimator.gameObject.SetActive(true);
        animator = parAnimator;
        animator.SetBool("1stToPar", true);
        animName = "1stToPar";
    }

    public void LoadBackFoot()
    {
        ResetAnimation();
        animator.SetBool(animName, false);
        animator.gameObject.SetActive(false);
        idleAnimator.gameObject.SetActive(true);
        animator = idleAnimator;
        animator.SetBool("BackFootLift", true);
        animName = "BackFootLift";
    }

    public void LoadEnbase()
    {
        ResetAnimation();
        animator.SetBool(animName, false);
        animator.gameObject.SetActive(false);
        parAnimator.gameObject.SetActive(true);
        animator = parAnimator;
        animator.SetBool("EnbaseAnimation", true);
        animName = "EnbaseAnimation";
    }

    public void PlayAnim()
    {
        if (animName != null)
        {
            animPlaying = true;
            animator.speed = 1.0f;
        }
        SetPlayButtons(animPlaying);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
