using UnityEngine;

public sealed class Blinker2 : MonoBehaviour
{
    static Color AnimatedColor
      => Color.Lerp(Color.red, Color.blue, (Mathf.Sin(Time.time) + 1) / 2);

    MaterialPropertyBlock _block;

    void Start()
      => _block = new MaterialPropertyBlock();

    void Update()
    {
        _block.SetColor("_BaseColor", AnimatedColor);
        GetComponent<Renderer>().SetPropertyBlock(_block);
    }
}
