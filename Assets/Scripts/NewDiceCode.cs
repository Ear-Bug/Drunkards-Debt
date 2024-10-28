using System;
using Unity.VisualScripting;
using UnityEngine;

public class NewDiceCode : MonoBehaviour
{
    public Sprite DiceRollFilledIn_0;
    public Sprite DiceRollFilledIn_1;
    public Sprite DiceRollFilledIn_2;
    public Sprite DiceRollFilledIn_3;
    public Sprite DiceRollFilledIn_4;
    public Sprite DiceRollFilledIn_5;

    int rollOne;
    private void Start()
    {
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_3;
        
    }
    void Update()
    {

        

    }
    public void DiceRoll()
    {
        
        rollOne = (int)UnityEngine.Random.Range(1f, 7f);
        Debug.Log("rollOne is: " + rollOne);

        if (gameObject.tag == "Cup")
        {
            transform.position = new Vector3(0, 0, 0);
            Debug.Log("Cup is called");
        }

        switch (rollOne)
        {
            case 1:
            {
                    if (gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_0;
                    }
                Debug.Log("DiceRollFilledIn_0");    
            } break;
            case 2:
                {
                    if (gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_1;
                    }
                    Debug.Log("DiceRollFilledIn_1");
                }
                break;
            case 3:
                {
                    if (gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_2;
                    }
                    Debug.Log("DiceRollFilledIn_2");
                }
                break;
            case 4:
                {
                    if (gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_3;
                    }
                    Debug.Log("DiceRollFilledIn_3");
                }
                break;
            case 5:
                {
                    if (gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_4;
                    }
                    Debug.Log("DiceRollFilledIn_4");
                }
                break;
            case 6:
                {
                    if (gameObject.tag == "Dice")
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = DiceRollFilledIn_5;
                    }
                    Debug.Log("DiceRollFilledIn_5");
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
}
