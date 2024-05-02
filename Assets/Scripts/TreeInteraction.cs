using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteraction : MonoBehaviour
{
    public GameObject player;
    public Rigidbody coconut;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        audiosource.volume = dist / 26;
        if (dist < 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("touch fuzzy, get dizzy\n");
                coconut.useGravity = true;
            }
        }
    }
}
