using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] GameObject[] points; /// Stores the array of points to move 
    [SerializeField] float speed = 3f; // Value for platform movement speed

    int indexOfPoints=0; //Sets the index of points to move towards, initially set to Zero 

    void Update()
    {
        //Finding the next point to move the platform towards it

        if (Vector3.Distance(transform.position, points[indexOfPoints].transform.position) < .1f)// Finding distance between point and platform, change point when distance is less than .1f
        {
            indexOfPoints++;
            if (indexOfPoints >= points.Length) //if the array index is complete reset it to zero
            {
                indexOfPoints = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, points[indexOfPoints].transform.position, speed * Time.deltaTime); //Making Platform move to the point at the specified speeed using MoveTowards() Method
    }
}
