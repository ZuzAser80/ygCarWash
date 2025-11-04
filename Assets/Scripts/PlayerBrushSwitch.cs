using System.Collections.Generic;
using UnityEditor.TerrainTools;
using UnityEngine;

public class PlayerBrushSwitch : MonoBehaviour
{
    [SerializeField] public List<Brush> brushes = new List<Brush>();
    public Brush current;

    public PlayerInputActions inputActions;

    void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Enable();
    }

    void Start()
    {
        
        current = brushes[0];
        inputActions.Player.Brush.performed += delegate
        {
            Debug.Log("switched brush to: " + (inputActions.Player.Brush.ReadValue<float>() - 1));
            current = brushes[(int)inputActions.Player.Brush.ReadValue<float>() - 1];
        };
        
    }



}