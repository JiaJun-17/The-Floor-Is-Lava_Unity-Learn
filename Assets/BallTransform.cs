using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    //This variable is public so that it will appear in the Inspector. The type of variable, Vector3, is a data type for holding three values.
    public Vector3 scaleChange;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //The operator += will add the values in scaleChange to the current scale values of the GameObject, so that the ball grows.
        transform.localScale += scaleChange;
    }
}
