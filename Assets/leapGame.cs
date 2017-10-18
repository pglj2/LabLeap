using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
public class leapGame : MonoBehaviour {

    LeapProvider provider;
    
    void Start () {
        provider = FindObjectOfType<LeapProvider>() as LeapProvider;	
	}
	
	void Update () {
        Frame frame = provider.CurrentFrame;
        List<Hand> maos = frame.Hands;

        for (int i = 0; i < maos.Count; i++) {
            Hand hand = maos[i];

            if (hand.IsRight) {
                transform.rotation = Quaternion.Euler(0, 0, hand.PalmNormal.Roll);
            }
            if (hand.IsLeft) {
                transform.rotation = Quaternion.Euler(hand.PalmNormal.Roll, 0, 0);
            }
        }
	}
}
 