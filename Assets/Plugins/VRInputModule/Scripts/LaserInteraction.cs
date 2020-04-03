using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;
using Wacki;

public class LaserInteraction : MonoBehaviour
{
    public ViveUILaserPointer laserPointerLeft;
    public ViveUILaserPointer laserPointerRight;
    //public AnimControl controller;
    void Awake()
    {
        
    }

    private void Update()
    {
        /*if (laserPointerLeft.ButtonDown() && laserPointerLeft.interactable != null)
        {
            Debug.Log(laserPointerLeft.interactable.tag);
        } else if (laserPointerRight.ButtonDown() && laserPointerRight.interactable != null)
        {
            Debug.Log(laserPointerLeft.interactable.tag);
        }*/
    }

    public void PointerClickAndHold(object sender, Valve.VR.Extras.PointerEventArgs e)
    {
        //if (e.target.GetComponent<continuousRotateObject>())
        //{
            Debug.Log("Rotating object");
            
        //} 
    }

    public void PointerClick(object sender, Valve.VR.Extras.PointerEventArgs e)
    {
        Button button = e.target.GetComponent<Button>();
        if (button)
        {
            button.onClick.Invoke();
        }
        else
        {
            Debug.Log(e.target.name);
            //controller.nullSpeed();
        }
    }

    public void PointerInside(object sender, Valve.VR.Extras.PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was entered");
        }
    }

    public void PointerOutside(object sender, Valve.VR.Extras.PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was exited");
        }
    }
}