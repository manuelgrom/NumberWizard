using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int _maxNumber = 1000;
    private int _minNumber = 1;
    private float _rndNumber = 1.0f;
    
    // Use this for initialization
    void Start()
    {
        _rndNumber = Random.Range(_minNumber, _maxNumber);

        print("Think of a number");

        print("The maximum number can be " + _maxNumber);
        print("The minimum number can be " + _minNumber);

        print("is your number " + _rndNumber + " ?");
        print("up key for higher, down key for lower");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
