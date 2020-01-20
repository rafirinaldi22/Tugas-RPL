using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
	public GameObject lampOn, lampOff;
    
    //variabel lampu yang harus hidup dan aktif
    int whichLampIsOn = 1;

    void Start ()
    {
    	//menghidupkan lampu dan mematikannya
    	lampOff.gameObject.SetActive (true);
    	lampOn.gameObject.SetActive (false);
    }

    public void SwitchLamp()
    {
    	switch (whichLampIsOn){
    		case 1:
    			whichLampIsOn = 2;
    			//menyalakan lampu
    			lampOff.gameObject.SetActive (false);
    			lampOn.gameObject.SetActive (true);
    			break;
    		case 2:
    			whichLampIsOn = 1;
    			lampOff.gameObject.SetActive (true);
    			lampOn.gameObject.SetActive (false);
    			break;
    	}
    }
}
