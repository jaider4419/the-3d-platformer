using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public GameObject footsteps_Sfx;
    // Start is called before the first frame update
    void Start()
    {
        footsteps_Sfx.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            FootstepsPlay();
        }
        if (Input.GetKey("a"))
        {
            FootstepsPlay();
        }
        if (Input.GetKey("s"))
        {
            FootstepsPlay();
        }
        if (Input.GetKey("d"))
        {
            FootstepsPlay();
        }

        if (Input.GetKeyUp("w"))
        {
            FootstepsStop();
        }
        if (Input.GetKeyUp("a"))
        {
            FootstepsStop();
        }
        if (Input.GetKeyUp("s"))
        {
            FootstepsStop();
        }
        if (Input.GetKeyUp("d"))
        {
            FootstepsStop();
        }
    }

    public void FootstepsPlay()
    {
        footsteps_Sfx.SetActive(true);
    } public void FootstepsStop()
    {
        footsteps_Sfx.SetActive(false);
    }
}
