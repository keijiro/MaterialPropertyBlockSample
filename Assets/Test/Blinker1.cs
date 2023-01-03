using UnityEngine;

public class Blinker1 : MonoBehaviour
{
    void Update()
      => GetComponent<Renderer>().material.color
           = Color.Lerp(Color.red, Color.blue, (Mathf.Sin(Time.time) + 1) / 2);
}
