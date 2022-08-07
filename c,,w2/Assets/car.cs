using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string heroName = "3abood";
    float heroHeight = 1.79f;
    int heroAge = 25;
    string heroSuperPower = "defense";
    string villainName = "hmood";
    float villainHeight = 1.70f;
    int villainAge = 22;
    string villainSuperPower = "crawling";
    float heroHeightafter = 1.79f + 5;
    string villainSuperPowerafter = "None";



    // Start is called before the first frame update
    void Start()
    {
        print("hero name is" + heroName + "hero age is" + heroAge + "hero height is" + heroHeight + "hero super power is" + heroSuperPower);
        print("villain name is" + villainName + "villain age is" + villainAge + "villain height is" + villainHeight + "villain super power is" + villainSuperPower);
        print("age difference is" + (heroAge = villainAge));
        print("hero height after is" + heroHeightafter);
        print("villain super power after is" + villainSuperPowerafter);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
