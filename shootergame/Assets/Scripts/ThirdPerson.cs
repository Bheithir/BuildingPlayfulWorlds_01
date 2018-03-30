using UnityEngine;

public class ThirdPerson : MonoBehaviour {

    public Camera Fps_Cam;
    public Camera Tps_Cam;
    bool fps_Cam = true;
	// Use this for initialization
	void Start () {
        Fps_Cam.enabled = Fps_Cam;
        Tps_Cam.enabled =! Fps_Cam;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
        {
            fps_Cam =! fps_Cam;
            Fps_Cam.enabled = fps_Cam;
            Tps_Cam.enabled =! fps_Cam;
        }
	}
}
