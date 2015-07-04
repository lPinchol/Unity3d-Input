using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestInput : MonoBehaviour {

    public string mdevice = "Mando";
    public Text textinfo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        textinfo.text = mdevice;

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            Debug.Log("Pulsando el 4  :: " + KeyCode.Joystick1Button0);
            mdevice = "Mando";
        }

        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            Debug.Log("Pulsando el 3  :: " + KeyCode.Joystick1Button1);
            mdevice = "Mando";
        }

        if (Input.GetKey(KeyCode.Joystick1Button2))
        {
            Debug.Log("Pulsando el 2  :: " + KeyCode.Joystick1Button2);
            mdevice = "Mando";
        }

        if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            Debug.Log("Pulsando el 1  :: " + KeyCode.Joystick1Button3);
            mdevice = "Mando";
        }

        if (Input.GetKey(KeyCode.KeypadEquals))
        {
            Debug.Log("Pulsando el Keypad1  :: " + KeyCode.Keypad1);
            mdevice = "Mando";
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pulsando el A  :: " + KeyCode.A);
            mdevice = "Teclado";
        }
	}
}
