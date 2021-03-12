using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    // Start is called before the first frame update
    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        //kill off screen apples
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); // b
            apScript.AppleDestroyed();
        }

    }

    
}
