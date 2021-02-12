using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class World : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private int worldX = 16, worldY = 16, worldZ = 16;
    [SerializeField]
    private int chunkSize = 16;
    [SerializeField]
    private GameObject chunk;

    

    private byte[,,] blockData;
    private Chunk[,,] chunks;

    #endregion
    public byte[,,] BlockData
    {
        get
        {
            return blockData;
        }
        set
        {
            blockData = value;
        }
    }

    public Chunk[,,] Chunks
    {
        get
        {
            return chunks;
        }
        set
        {
            chunks = value;
        }
    }

    public int ChunkSize
    {
        get
        {
            return chunkSize;
        }
    }

    // Use this for initialization
    void Start()
    {
        BlockData = new byte[worldX, worldY, worldZ];
        for(int x = 0; x < worldX; x++)
        {
            for(int z = 0; z < worldZ; z++)
            {
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public byte Block(int x, int y, int z)
    {
        if (x >= worldX || x < 0 || y >= worldY || y < 0 || z >= worldZ || z < 0)
        {
            return (byte)textureType.rock.GetHashCode();
        }
        return BlockData[x, y, z];
    }
}
