using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * .5f * Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Input.GetAxis("Mouse X")<0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .1f, transform.position.y, transform.position.z),.3f);
            }
            if (Input.GetAxis("Mouse X")>0)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .1f, transform.position.y, transform.position.z), .3f);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.name=="x2"||col.name=="+3")
        {
            gameManager.CharacterManager(col.name, col.transform);
        }
    }
}
