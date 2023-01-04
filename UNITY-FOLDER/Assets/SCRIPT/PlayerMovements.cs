using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 10;
    public float rotationSPeed = 50;
    public KeyCode moveKeyForward = KeyCode.Z, moveKeyBackWard = KeyCode.S ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(moveKeyForward))
        {
            Debug.Log("AVANCE");
            transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime);
        }

        if (Input.GetKey(moveKeyBackWard))
        {
            Debug.Log("RECULE");
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-Vector3.up * rotationSPeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSPeed * Time.deltaTime);
        }
    }
}
