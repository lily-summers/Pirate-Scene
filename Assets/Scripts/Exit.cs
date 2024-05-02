using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject player;
    public FirstPersonController firstPersonController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        if (dist < 0.8)
        {
            Debug.Log("Until Next Time\n");
            Application.Quit();
        }
    }
}
