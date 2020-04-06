using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuousRotateObject : MonoBehaviour
{

    public Quaternion targetRotation;
    public int direction;
    public float rotateSpeed = 0.1f;
    private bool rotating;
    public GameObject interactableLeg;
    public GameObject healthyLeg;
    public GameObject labelLeg;
    public GameObject diagnosingLeg;

    public void setRotating(bool toRotate) { rotating = toRotate; }
    // Start is called before the first frame update
    void Start()
    {
        targetRotation = interactableLeg.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //get current
        if (rotating)
        {
            /*Quaternion currentRot = interactableLeg.transform.localRotation;

            //calculate lerped delta
            Quaternion objRotation = Quaternion.Slerp(
               currentRot, , interpSpeed
            );*/
            Vector3 objRotation = new Vector3(0, direction * rotateSpeed, 0);
            //apply
            interactableLeg.transform.localEulerAngles += objRotation;
            //healthyLeg.transform.localRotation = objRotation;
            //labelLeg.transform.localRotation = objRotation;
            //diagnosingLeg.transform.localRotation = objRotation;
        }
    }
}
