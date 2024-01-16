using UnityEngine;

[CreateAssetMenu]
public class SeedItem : Item {
    // Sprite au sol quand planté
    [SerializeField] private Sprite floorSprite;
    public Sprite FloorSprite => floorSprite;
    [SerializeField] private Sprite ripeFloorSprite;
    public Sprite RipeFloorSprite => ripeFloorSprite;
    
    // L'Item ramassé quand la plante a fini de pousser
    [SerializeField] private Item correspondingGrownItem;
}