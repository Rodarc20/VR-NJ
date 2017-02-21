using UnityEngine;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class SimpleScript : MonoBehaviour {
    SteamVR_TrackedObject trackedObj;
    SteamVR_LaserPointer laser;

    void Awake(){
            trackedObj = GetComponent<SteamVR_TrackedObject>();
            laser = GetComponent<SteamVR_LaserPointer>();
    }
    void Update(){
		var device = SteamVR_Controller.Input((int)trackedObj.index);
        if(device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)){
            print("Presionado");
        }

        if(device.GetPressDown(SteamVR_Controller.ButtonMask.Axis0)){
            print("Touch");
        }
    }
}
