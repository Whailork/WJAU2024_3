using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "tileMap/new TileDatas", fileName = "tile0", order = 0)]
public class TileDatas : ScriptableObject
{
    public List<Vector2> listeTile;
}