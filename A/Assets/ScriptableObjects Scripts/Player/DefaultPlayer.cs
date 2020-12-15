using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Player/Default")]
public class DefaultPlayer : Player
{

    
    public override void Ability()
    {
        Debug.Log("Ability used");
    }
}
