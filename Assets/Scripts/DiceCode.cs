using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiceCode : MonoBehaviour
{

    int rollOne;
    int rollTwo;
    int sum;
    int bet;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(roll = (int)Random.Range(1f, 7f));
        
    }

    // Update is called once per frame
    void Update()
    {
        OnMouseDown();
        //MouseClickCodeLeft();


    }

    public void MouseClickCodeLeft()
    {
        //int sum = rollOne + rollTwo;

        for (int i = 0; i == 1; i++) { }
            {
                rollOne = (int)Random.Range(1f, 7f);
                rollTwo = (int)Random.Range(1f, 7f);
                Debug.Log("The Sum is " + sum);
                gameLogic();
            }
            //Debug.Log("Mouse 0 - Left Click");
    }
    public void gameLogic()
    {
        sum = rollOne + rollTwo;
        if (sum < bet)
        {
            Debug.Log("Bet Lost");
        }
        else if (sum > bet)
        {
            Debug.Log("Bet Won");
        }
    }
   
    void OnMouseDown()
    {
        //Left Click
        if (gameObject.tag == "Dice" && Input.GetMouseButtonDown(0))
        {
            MouseClickCodeLeft();

        }
    }

        public void MouseClickCodeRight()
    {
        //Right Click
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse 1 - Right Click");

        }
    }
    public void MouseClickCodeMiddle()
    {
        //Middle Mouse Click
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Mouse 2 - Middle Mouse Click");

        }
    }

}
