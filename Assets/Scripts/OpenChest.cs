using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public GameObject player;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        Debug.Log(dist);
        if (dist < 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("treasure? i barely know her.\n");
                animator.SetTrigger("open");
            }
        }
    }
}
