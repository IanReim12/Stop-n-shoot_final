using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    public Rigidbody rb;
    

    private void Update()
    {
        if (rb.position.y < -2f)
        {
            Application.LoadLevel("Scene1");
            
        }
        
    }
}
