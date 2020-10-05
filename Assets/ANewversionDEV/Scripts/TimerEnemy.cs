using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TimerEnemy : MonoBehaviour {
    public float power = 0.7f;
    public float duration = 1;
    public Transform camera;
    public float slowDownAmount = 1;
    public bool shouldShake = false;

    Vector3 startPosition;
    float initialDuration;
    // Start is called before the first frame update
  public AudioSource audioSource;

    public Text timerMinutes;
    public Text timerSeconds;
    public Text timerSeconds100;
    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;
    public GameObject Boolean;
    //Before assigning a Button, make sure the On click button is added to the button
    //In addition add the On Click Object script to trigger the button force.

	// Use this for initialization
	void Start () {
        startPosition = camera.localPosition;
        initialDuration = duration;
        TimerReset();
         if (!isRunning) {
            print("START");
            isRunning = true;
            startTime = Time.time;       
        }
    }

    public void TimerStart() {
        if (!isRunning) {
            print("START");
            isRunning = true;
            startTime = Time.time;       
        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = timerTime;
        }
    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }


    // Update is called once per frame
    void Update () {
        timerTime = stopTime + (Time.time - startTime);
        int minutesInt = (int)timerTime / 60;
        int secondsInt = (int)timerTime % 60;
        int seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));
  

            if(shouldShake){
            if(duration >= 0){
                camera.localPosition = startPosition+Random.insideUnitSphere*power;
                duration -= Time.deltaTime*slowDownAmount;
            }else{
                shouldShake = false;
                duration = initialDuration;
                camera.localPosition = startPosition;
            }
        }


        if (isRunning)
        {
            timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
        if(secondsInt < 10)
        {
        
        
        }
        if(secondsInt == 10)
        {
            shouldShake = true;
            isRunning = false;
            stopTime = timerTime;
            secondsInt = 10;
            audioSource.Play();
    
        }
    }
}
