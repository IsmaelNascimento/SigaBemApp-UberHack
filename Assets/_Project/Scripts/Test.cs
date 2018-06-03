using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text text;
    public float minAcceleration = .1f;

    private void Start()
    {
        text.text = minAcceleration.ToString();
    }

    private void Update()
    {
        if (Input.acceleration.x < -minAcceleration)
            text.text = "Left";
        else if(Input.acceleration.x > minAcceleration)
            text.text = "Right";
    }
}