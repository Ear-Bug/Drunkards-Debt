using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCode : MonoBehaviour
{
    public bool Clicked = false;
    int roll;

    RaycastHit raycastHit;
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(roll = (int)Random.Range(1f, 7f));
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseClickCodeLeft();


    }

    public void MouseClickCodeLeft()
    {
        //Left Click
        if (Input.GetMouseButtonDown(0))
        {
            Clicked = true;
            if (Clicked == true)
            {
                Clicked = false;
                roll = (int)Random.Range(1f, 7f);
                Debug.Log(roll);
            }
            //Debug.Log("Mouse 0 - Left Click");


                if (Physics.Raycast(ray, out raycastHit, 100f))
                {
                    if (raycastHit.transform != null)
                    {
                        //Our custom method. 
                        CurrentClickedGameObject(raycastHit.transform.gameObject);
                    }
                }
        }
    }
    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "Dice")
        {
            Debug.Log("Dice Clicked");
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
