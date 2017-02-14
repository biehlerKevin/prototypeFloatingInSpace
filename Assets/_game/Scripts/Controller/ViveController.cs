using UnityEngine;
using System.Collections;

public class ViveController : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;


    //See API for all the different Buttons
    private Valve.VR.EVRButtonId gripButtonId = Valve.VR.EVRButtonId.k_EButton_Grip;
    public bool gripButtonDown = false;
    public bool gripButtonUp = false;
    public bool gripButtonPressed = false;

    private Valve.VR.EVRButtonId triggerButtonId = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    public bool triggerButtonDown = false;
    public bool triggerButtonUp = false;
    public bool triggerButtonPressed = false;

    //Used to acces the right controller via the index 
    private SteamVR_Controller.Device controller {
        get {
            return SteamVR_Controller.Input((int) trackedObj.index);
            }
    }

	// Sets Controller to right Index, can change depending on which one is used for left/right
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if(controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }
        gripButtonDown = controller.GetPressDown(gripButtonId);
        gripButtonUp = controller.GetPressUp(gripButtonId);
        gripButtonPressed = controller.GetPress(gripButtonId);

        triggerButtonDown = controller.GetPressDown(triggerButtonId);
        triggerButtonUp = controller.GetPressUp(triggerButtonId);
        triggerButtonPressed = controller.GetPress(triggerButtonId);

        if (gripButtonDown)
        {
            Debug.Log("gripButtonDown was just pressed");
        }
        if (gripButtonUp)
        {
            Debug.Log("gripButtonDown was just unpressed");
        }
        if (triggerButtonDown)
        {
            Debug.Log("triggerButtonDown was just pressed");
        }
        if (triggerButtonUp)
        {
            Debug.Log("gripButtonDown was just unpressed");
        }


    }
}
