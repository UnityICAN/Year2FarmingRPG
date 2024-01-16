using UnityEngine;

public class PlantationController : MonoBehaviour {
    [SerializeField] private SpriteRenderer spriteRenderer;
    private SeedItem plantedSeed;

    public void PlantSeed(SeedItem plantedSeed) {
        if (this.plantedSeed != null) {
            this.plantedSeed = plantedSeed;
            spriteRenderer.sprite = this.plantedSeed.FloorSprite;
        }
    }
}
