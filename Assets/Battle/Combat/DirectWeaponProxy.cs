﻿using Unity.Entities;
using UnityEngine;

namespace Battle.Combat
{
    [RequiresEntityConversion]
    public class DirectWeaponProxy : MonoBehaviour, IConvertGameObjectToEntity
    {
        public float Range;
        public bool Armed;
        public float AttackCone;

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new DirectWeapon { Armed = Armed, Range = Range, AttackCone = AttackCone });
        }
    }
}