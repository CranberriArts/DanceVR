using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Slider slider;
    private Animator animator;
    private bool animPlaying, settingsToggled;
    public GameObject Play, Pause, SettingsPanel;
    private string animName;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
        if (animName != null)
        {
            animator.SetBool(animName, false);
        }
        animator.SetBool("ArmAnimation", true);
        animName = "ArmAnimation";
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
