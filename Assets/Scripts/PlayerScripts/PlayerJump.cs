using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody Player;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;

    // Use this for initialization
    void Start ()
    {
        Player = GetComponent<Rigidbody>();

        jump = new Vector3(0.0f, 1.0f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            Player.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }
    // Update is called once per frame
    
}
