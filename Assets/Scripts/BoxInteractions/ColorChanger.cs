using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer CubeRenderer;
     
    // Radnom color changer on event trigger i.e when a button is tapped
    public void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        CubeRenderer.material.color = randomColor;
    }

}
