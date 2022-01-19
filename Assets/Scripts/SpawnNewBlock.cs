﻿// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewBlock : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] Transform spawnPosition;

    public void SpawnBlock()
    {
        GameObject newBlock = Instantiate(blockPrefab, spawnPosition.position, Quaternion.identity);
        int randomColor = Random.Range(0, 2);
        newBlock.GetComponent<ColorChanger>().SpriteColor = (ObjectColor)randomColor;

    }
}
