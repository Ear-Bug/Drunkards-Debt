using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class NewDiceCode : MonoBehaviour
{
    [SerializeField] Sprite DiceRollFilledIn_0;
    [SerializeField] Sprite DiceRollFilledIn_1;
    [SerializeField] Sprite DiceRollFilledIn_2;
    [SerializeField] Sprite DiceRollFilledIn_3;
    [SerializeField] Sprite DiceRollFilledIn_4;
    [SerializeField] Sprite DiceRollFilledIn_5;

    public int rollOne;
    public int rollTwo;
    public Button yourButton;
    private void Start()
    {
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_3;
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    private void Update()
    {

        rollOnePlusCode();
        rollTwoPlusCode();


    }

    void TaskOnClick()
    {
        rollOneCode();
        rollTwoCode();
        //Debug.Log("You have clicked the button!");
    }

    public void DiceRoll()
    {
        
        cubeCode();
       


        switch (rollOne)
        {
            case 1:
                {
                    if (this.gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_0;
                        Debug.Log("DiceRollFilledIn_0");
                    }

                }
                break;
            case 2:
                {
                    if (this.gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_1;
                        Debug.Log("DiceRollFilledIn_1");
                    }


                }
                break;
            case 3:
                {
                    if (this.gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_2;
                        Debug.Log("DiceRollFilledIn_2");
                    }

                }
                break;
            case 4:
                {
                    if (this.gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_3;
                        Debug.Log("DiceRollFilledIn_3");
                    }

                }
                break;
            case 5:
                {
                    if (this.gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_4;
                        Debug.Log("DiceRollFilledIn_4");
                    }

                }
                break;
            case 6:
                {
                    if (this.gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_5;
                        Debug.Log("DiceRollFilledIn_5");
                    }

                }
                break;


        }

        //Dice Roll Filled In_0
        //Dice Roll Filled In_1
        //Dice Roll Filled In_2
        //Dice Roll Filled In_3
        //Dice Roll Filled In_4
        //Dice Roll Filled In_5
    }
    public void cubeCode()
    {
        if (gameObject.tag.Equals("Cup"))
        {
            transform.position = new Vector3(552, 250, 44);
            Debug.Log("Cup is called");
        }
    }

    public void rollOneCode()
    {
        rollOne = (int)UnityEngine.Random.Range(1f, 7f);
        Debug.Log("rollOne is: " + rollOne);
    }
    public void rollOnePlusCode()
    {
        if (rollOne == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_0;
        }
        else if (rollOne == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_1;
        }
        else if (rollOne == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_2;
        }
        else if (rollOne == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_3;
        }
        else if (rollOne == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_4;
        }
        else if (rollOne == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_5;
        }
    }



    public void rollTwoCode()
    {
        rollTwo = (int)UnityEngine.Random.Range(1f, 7f);
        Debug.Log("rollTwo is: " + rollTwo);

    }

    public void rollTwoPlusCode()
    {
        if (rollTwo == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_0;
        }
        else if (rollTwo == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_1;
        }
        else if (rollTwo == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_2;
        }
        else if (rollTwo == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_3;
        }
        else if (rollTwo == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_4;
        }
        else if (rollTwo == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_5;
        }
    }
}

    

