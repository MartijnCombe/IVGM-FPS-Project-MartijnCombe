using UnityEngine;

public class timecontroller : MonoBehaviour
{
    // Toggles the time scale between 1 and 0.7
    // whenever the user hits the Fire1 button.
    public GameObject Pickup_TimeDevice;
    private float fixedDeltaTime;

    void Awake()
    {
        // Make a copy of the fixedDeltaTime, it defaults to 0.02f, but it can be changed in the editor
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update()
    {
        //!
        var script = Pickup_TimeDevice.GetComponent<TimeDevice_Pickup>();
        if (!(script.pickedUp) && Input.GetKeyDown("f"))
        {
            if (Time.timeScale == 1.0f)
            {
                Time.timeScale = 0.25f;
                print("slowed");
            }
            else
            {
                Time.timeScale = 1.0f;
                print("normal");
            }
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 real-time seconds per frame
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }
    }
}
