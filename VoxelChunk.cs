// File: VoxelChunk.cs
using UnityEngine;

public class VoxelChunk : MonoBehaviour {
    public int width = 16;
    public int height = 16;
    public int depth = 16;
    public GameObject voxelPrefab;

    void Start() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                for (int z = 0; z < depth; z++) {
                    Vector3 pos = new Vector3(x, y, z);
                    Instantiate(voxelPrefab, pos, Quaternion.identity, transform);
                }
            }
        }
    }
}
