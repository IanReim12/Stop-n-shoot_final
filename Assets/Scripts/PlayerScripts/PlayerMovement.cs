using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 

{

    public float movementSpeed;
    public Rigidbody Player;
    public float UpwardForce;
    public float forwardForce = 2000f;
    public float sprintForce = 3000f;
    public float sidewaysForce = 500f;
    public float downwardForce = -200f;
    public float backForce = 50f;
    GameObject prefab;
    public bool canShoot = true;
    public bool ismoving = true;




    // Use this for initialization
    void Start()
    {
        prefab = Resources.Load("Projectile") as GameObject;
        
    }



    private void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            ismoving = true;


        }
        if (Input.GetMouseButtonDown(0) && ismoving == false)
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 50;
            Destroy(projectile, 5);

        }
    }




    //Update is called once per frame
    void FixedUpdate()  
    {

        Player.AddForce(0, downwardForce, 0);





    if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
        {

            //transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
            Player.AddRelativeForce(Vector3.forward * sprintForce); 

        }
        else if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
        {
            Player.AddRelativeForce(Vector3.forward * forwardForce);
            //transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;


        }
        else if (Input.GetKey("s")&& !Input.GetKey("w"))
        {
            Player.AddRelativeForce(Vector3.back * backForce);
            //transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;


        }

        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            Player.AddRelativeForce(Vector3.left * sidewaysForce);

            //transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;


        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            Player.AddRelativeForce(Vector3.right * sidewaysForce);
            //transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;


        }
        else
        {
            ismoving = false;
        }
        

        
    }
}
