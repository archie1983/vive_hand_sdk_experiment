using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ViveHandTracking;

    public class CustomGrab : MonoBehaviour
{
    private Rigidbody target = null;
    private int state = 0;
    //private bool exit = true;

    public Text txtCoord;
    private static int SCALE = 10;

    void Awake()
    {
        Debug.Log("AWAKE");
    }

    void Update()
    {
        if (GestureProvider.LeftHand != null && GestureProvider.LeftHand.gesture == GestureType.Like)
        {
            txtCoord.text = string.Format("{0:0.##}", GestureProvider.LeftHand.position.x * SCALE) 
                + " # " + string.Format("{0:0.##}", GestureProvider.LeftHand.position.y * SCALE)
                + " # " + string.Format("{0:0.##}", GestureProvider.LeftHand.position.z * SCALE)
                + "\n" + GestureProvider.LeftHand.rotation.ToString();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIG ENTER");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("TRIG EXIT");
        if (other.GetComponent<Rigidbody>() != target) return;
        //if (state == 1) exit = true;
    }

    public void OnStateChanged(int state)
    {
        Debug.Log("OK detected" + (txtCoord == null));
/*        if (GestureProvider.LeftHand != null && GestureProvider.LeftHand.gesture == GestureType.Like)
        {
            txtCoord.text = GestureProvider.LeftHand.position.x + " # " + GestureProvider.LeftHand.position.y + " # " + GestureProvider.LeftHand.position.z;
        }*/

        this.state = state;
    }
}
