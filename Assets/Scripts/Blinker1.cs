using UnityEngine;

public sealed class Blinker1 : MonoBehaviour
{
    float AnimationTime
      => (GetInstanceID() & 0xff) / 256.0f + Time.time / 5;

    Color AnimatedColor
      => Color.HSVToRGB(AnimationTime % 1, 0.9f, 1);

    void Update()
      => GetComponent<Renderer>().material.color = AnimatedColor;
}
