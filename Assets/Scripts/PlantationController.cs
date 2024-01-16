using System.Collections;
using UnityEngine;

public class PlantationController : MonoBehaviour {
    [SerializeField] private SpriteRenderer spriteRenderer;
    private SeedItem plantedSeed;

    private Coroutine growthCoroutine;

    public void PlantSeed(SeedItem plantedSeed) {
        if (this.plantedSeed == null) {
            this.plantedSeed = plantedSeed;
            spriteRenderer.sprite = this.plantedSeed.FloorSprite;

            growthCoroutine = StartCoroutine(ManageGrowth());
        }
    }

    public void UprootPlant() {
        StopCoroutine(growthCoroutine);
    }

    private IEnumerator ManageGrowth() {
        yield return new WaitForSeconds(5f);

        spriteRenderer.sprite = plantedSeed.RipeFloorSprite;
    }
}
