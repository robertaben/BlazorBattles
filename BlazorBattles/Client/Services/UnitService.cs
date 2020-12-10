﻿using BlazorBattles.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        public IList<Unit> Units { get; } = new List<Unit>
        {
            new Unit { Id = 1, Title = "Knight", Attack = 10, Defence = 10, BananaCost = 100 },
            new Unit { Id = 2, Title = "Archer", Attack = 15, Defence = 5, BananaCost = 150 },
            new Unit { Id = 3, Title = "Mage", Attack = 20, Defence = 1, BananaCost = 200 },
        };

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
        }
    }
}
