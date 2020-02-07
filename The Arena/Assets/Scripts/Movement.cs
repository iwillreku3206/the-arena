using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform playerTransform;
    
    public Camera mainCamera;
    public float mouseSensitivity;

    public Object bullet;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = gameObject.GetComponent<Transform>();
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))*Time.deltaTime);

        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")));


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, playerTransform.position + (playerTransform.forward * 1f) + new Vector3(0, 1.5f), playerTransform.rotation);
        }
    }

          
}
