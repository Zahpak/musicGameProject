using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PressedKey : MonoBehaviour {

    // Use this for initialization
    public Button _leftTom , _RihtTom , _Crash , _HiHat , _FloorTom , _Kick ,_snare;
    private string[] lastFour = new string[4]; 
    void Start () {
        Button leftTom = _leftTom.GetComponent<Button>();
        Button rihtTom = _RihtTom.GetComponent<Button>();
        Button crash = _Crash.GetComponent<Button>();
        Button hiHat = _HiHat.GetComponent<Button>();
        Button floorTom = _FloorTom.GetComponent<Button>();
        Button kick = _Kick.GetComponent<Button>();
        Button snare = _snare.GetComponent<Button>();

        leftTom.onClick.AddListener(() => {TaskOnClick("LeftTom");});
        rihtTom.onClick.AddListener(() => { TaskOnClick("rightTom"); });
        crash.onClick.AddListener(() => { TaskOnClick("Crash"); });
        hiHat.onClick.AddListener(() => { TaskOnClick("HiHat"); });
        floorTom.onClick.AddListener(() => {TaskOnClick("floorTom"); });
        kick.onClick.AddListener(() => { TaskOnClick("kick"); });
        snare.onClick.AddListener(() => { TaskOnClick("snare"); });
    }
    void Update()
    {
      

    }

    void TaskOnClick(string arg)
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the "+arg+" button!");
        lastFour[3] = lastFour[2];
        lastFour[2] = lastFour[1];
        lastFour[0] = arg;
        Debug.Log(lastFour[0] + lastFour[1] + lastFour[2] +lastFour[3]);
        if (lastFour[3] == "Crash" && lastFour[2] == "Crash" && lastFour[1] == "Crash" && lastFour[0] == "snare")
            checkedForBeatTut(lastFour);
    }

    private void checkedForBeatTut(string[] lastFour)
    {
        if (lastFour[3] == "Crash" && lastFour[2] == "Crash" && lastFour[1] == "Crash" && lastFour[0] == "snare")
            Debug.Log("you won");
        Debug.Log(lastFour[0] + lastFour[1] + lastFour[2] + lastFour[3]);
    }
}
