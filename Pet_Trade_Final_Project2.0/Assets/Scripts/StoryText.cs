using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StoryText : MonoBehaviour
{
    public int money = 2000;
    public int money1 = 1900;
    public int food = 90;
    public int water = 100;
    public int clean = 100;
    public int health = 100;
    public int bored = 100;

    public int foodNeo = 100;
    public int waterNeo = 100;
    public int cleanNeo = 100;
    public int healthNeo = 100;
    public int boredNeo = 100;

    public int foodRico = 100;
    public int waterRico = 100;
    public int cleanRico = 100;
    public int healthRico = 100;
    public int boredRico = 100;

    public int foodNed = 90;
    public int waterNed = 100;
    public int cleanNed = 100;
    public int healthNed = 100;
    public int boredNed = 100;

    public int fooTed = 100;
    public int waterTed = 100;
    public int cleanTed = 100;
    public int healthTed = 100;
    public int boredTed = 100;

    public int foodShred = 100;
    public int waterShred = 100;
    public int cleanShred = 100;
    public int healthShred = 100;
    public int boredShred = 100;

    public int decreaseStat = 0; 

    public int decreaseFood = 0;
    public int decreaseWater = 0;
    public int decreaseClean = 0;
    public int decreaseBored = 0;

    public int decreaseFoodNed = 0;
    public int decreaseWaterNed = 0;
    public int decreaseCleanNed = 0;
    public int decreaseBoredNed = 0;

    public Text textComponent;
    public State StartingState;
    public State Situation1;
    public State Situation2;
    public State Situation3;
    public State Situation4;
    public State Situation5;
    public State Situation6;

    public State StartingStateNed;
    public State SituationNed1;
    public State SituationNed2;
    public State SituationNed3;
    public State SituationNed4;
    public State SituationNed5;
    public State SituationNed6;


    public Text MoneyText;
    public Text MoneyText1;
    public Text FoodText;
    public Text WaterText;
    public Text CleanText;
    public Text BoredText;
    public Text HealthText;

    public Text NedFoodText;
    public Text NedWaterText;
    public Text NedCleanText;
    public Text NedBoredText;
    public Text NedHealthText;

    State state;

   

    void Start()
    {
        //starts the game with the starting state
        state = StartingState;
        //gets the states and the text
        textComponent.text = state.GetStateStory();
       
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = state.GetStateStory();
        ManageState();
     
        if (money <= 0)
        {
            money = 0;
        }
        if (food >= 100)
        {
            food = 100;
        }
        if (food <= 0)
        {
            food = 0;
        }
        if (water >= 100)
        {
            water = 100;
        }
        if (water <= 0)
        {
            water = 0;
        }
        if (clean >= 100)
        {
            clean = 100;
        }
        if (clean <= 0)
        {
            clean = 0;
        }
        if (bored >= 100)
        {
            bored = 100;
        }
        if (bored <= 0)
        {
            bored = 0;
        }
        if (health >= 100)
        {
            health = 100;
        }
        if (health <= 0)
        {
            health = 0;
        }
        if (foodNed >= 100)
        {
            foodNed = 100;
        }
        if (foodNed <= 0)
        {
            foodNed = 0;
        }
        if (waterNed >= 100)
        {
            waterNed = 100;
        }
        if (waterNed <= 0)
        {
            waterNed = 0;
        }
        if (cleanNed >= 100)
        {
            cleanNed = 100;
        }
        if (cleanNed <= 0)
        {
            cleanNed = 0;
        }
        if (boredNed >= 100)
        {
            boredNed = 100;
        }
        if (boredNed <= 0)
        {
            boredNed = 0;
        }
        if (healthNed >= 100)
        {
            healthNed = 100;
        }
        if (healthNed <= 0)
        {
            healthNed = 0;
        }
    }

    public void  DisplayScores()
    {
        MoneyText.text = "Money: " + money.ToString("000");
        MoneyText1.text = "Money: " + money1.ToString("000");
        FoodText.text = "Food: " + food.ToString("000");
        WaterText.text = "Water: " + water.ToString("000");
        CleanText.text = "Cleaniness: " + clean.ToString("000");
        BoredText.text = "Bored: " + bored.ToString("000");
        HealthText.text = "Health: " + health.ToString("000");

        NedFoodText.text = "Food: " + foodNed.ToString("000");
        NedWaterText.text = "Water: " + waterNed.ToString("000");
        NedCleanText.text = "Cleaniness: " + cleanNed.ToString("000");
        NedBoredText.text = "Bored: " + boredNed.ToString("000");
        NedHealthText.text = "Health: " + healthNed.ToString("000");
    }

    public void ManageState()
    {
        var nextStates = state.GetNextStates();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName == "PetLizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                money = money - 100;
                SceneManager.LoadScene("Lizard");
            }
        }
        else if (state == StartingState && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = StartingStateNed;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = StartingStateNed;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = StartingStateNed;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = StartingStateNed;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == StartingStateNed && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation1;

                decreaseFoodNed = UnityEngine.Random.Range(5, 15);
                decreaseWaterNed = UnityEngine.Random.Range(5, 15);
                decreaseCleanNed = UnityEngine.Random.Range(5, 15);
                decreaseBoredNed = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                foodNed = foodNed + 10;

                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFoodNed;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWaterNed;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseCleanNed;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBoredNed;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation1;

                decreaseFoodNed = UnityEngine.Random.Range(5, 15);
                decreaseWaterNed = UnityEngine.Random.Range(5, 15);
                decreaseCleanNed = UnityEngine.Random.Range(5, 15);
                decreaseBoredNed = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                waterNed = waterNed + 10;
                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFoodNed;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWaterNed;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseCleanNed;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBoredNed;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                cleanNed = cleanNed + 10;
                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                boredNed = boredNed + 10;
                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == Situation1 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = SituationNed1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = SituationNed1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = SituationNed1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = SituationNed1;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

           
        }
        else if (state == SituationNed1 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                foodNed = foodNed + 10;

                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation2;

                decreaseFoodNed = UnityEngine.Random.Range(5, 15);
                decreaseWaterNed = UnityEngine.Random.Range(5, 15);
                decreaseCleanNed = UnityEngine.Random.Range(5, 15);
                decreaseBoredNed = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                waterNed = waterNed + 10;
                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = cleanNed - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                boredNed = boredNed + 10;
                if (decreaseStat == 1)
                {
                    foodNed = foodNed - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = waterNed - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed= cleanNed - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = boredNed - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == Situation2 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = SituationNed2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;

                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = SituationNed2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = SituationNed2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = SituationNed2;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == SituationNed2 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                foodNed = food + 10;

                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                waterNed = water + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                cleanNed = clean + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                boredNed = bored + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == Situation3 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = SituationNed3;

                decreaseFood = UnityEngine.Random.Range(0, 0);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;
                health = health - 25;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = SituationNed3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = SituationNed3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = SituationNed3;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == SituationNed3 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                foodNed = food + 10;

                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                waterNed = water + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                cleanNed = clean + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = Situation4;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                boredNed = bored + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == Situation4 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                health = health - 25;
                state = SituationNed4;
                
            }

        }
        else if (state == SituationNed4 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation5;

            }

        }
        else if (state == Situation5 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = SituationNed5;
                health = health + 25;
            }

        }
        else if (state == SituationNed5 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = Situation6;

            }

        }
        else if (state == Situation6 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                state = SituationNed6;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;

                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                state = SituationNed6;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                water = water + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                state = SituationNed6;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                clean = clean + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                state = SituationNed6;

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                bored = bored + 10;
                if (decreaseStat == 1)
                {
                    food = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    water = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    clean = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    bored = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        else if (state == SituationNed6 && sceneName == "Lizard")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                

                decreaseFoodNed = UnityEngine.Random.Range(5, 15);
                decreaseWaterNed = UnityEngine.Random.Range(5, 15);
                decreaseCleanNed = UnityEngine.Random.Range(5, 15);
                decreaseBoredNed = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                food = food + 10;

                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log("Food Amount: " + food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log("Water : " + water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log("Clean :" + clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log("Boredom: " + bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {

                decreaseFoodNed = UnityEngine.Random.Range(5, 15);
                decreaseWaterNed = UnityEngine.Random.Range(5, 15);
                decreaseCleanNed = UnityEngine.Random.Range(5, 15);
                decreaseBoredNed = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                waterNed = water + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
              

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                cleanNed = clean + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
               

                decreaseFood = UnityEngine.Random.Range(5, 15);
                decreaseWater = UnityEngine.Random.Range(5, 15);
                decreaseClean = UnityEngine.Random.Range(5, 15);
                decreaseBored = UnityEngine.Random.Range(5, 15);
                decreaseStat = UnityEngine.Random.Range(1, 4);

                boredNed = bored + 10;
                if (decreaseStat == 1)
                {
                    foodNed = food - decreaseFood;
                    Debug.Log(food);
                }
                else if (decreaseStat == 2)
                {
                    waterNed = water - decreaseWater;
                    Debug.Log(water);
                }
                else if (decreaseStat == 3)
                {
                    cleanNed = clean - decreaseClean;
                    Debug.Log(clean);
                }
                else if (decreaseStat == 4)
                {
                    boredNed = bored - decreaseBored;
                    Debug.Log(bored);
                }
            }

        }
        
        DisplayScores();
    }
}


