using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutSmasher : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rb;
    public GameObject island;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject == island)
        {
            animator.SetTrigger("crack");
            rb.isKinematic = true;
            this.transform.eulerAngles = Vector3.zero;
        }
    }
}
