using UnityEngine;

[System.Serializable]
public class Brush
{
    public Texture2D Texture;
    public Texture2D Rotated;
    public bool CanRotate = true;
    public bool IsRotated = false;
    public bool Strong = false;

}