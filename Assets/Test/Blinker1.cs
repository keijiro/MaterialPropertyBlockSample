using UnityEngine;

public sealed class Blinker1 : MonoBehaviour
{
    static Color AnimatedColor
      => Color.Lerp(Color.red, Color.blue, (Mathf.Sin(Time.time) + 1) / 2);

    void Update()
      => GetComponent<Renderer>().material.color = AnimatedColor;
}
