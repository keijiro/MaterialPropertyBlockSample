using UnityEngine;

public sealed class Rainbow2 : MonoBehaviour
{
    float AnimationTime
      => (GetInstanceID() & 0xff) / 256.0f + Time.time / 3;

    Color AnimatedColor
      => Color.HSVToRGB(AnimationTime % 1, 0.9f, 1);

    MaterialPropertyBlock _block;

    void Start()
      => _block = new MaterialPropertyBlock();

    void Update()
    {
        _block.SetColor("_BaseColor", AnimatedColor);
        GetComponent<Renderer>().SetPropertyBlock(_block);
    }
}
