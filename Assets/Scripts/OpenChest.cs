using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, this.transform.position);
        if (dist < 3)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                audiosource.Play();
                Debug.Log("treasure? i barely know her.\n");
                animator.SetTrigger("open");
            }
        }
    }
}
