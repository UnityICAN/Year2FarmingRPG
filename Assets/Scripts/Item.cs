using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject {
    // Sprite affiché dans l'inventaire
    [SerializeField] private Sprite itemSprite;
    // Nom affiché
    [SerializeField] private string itemName;
}