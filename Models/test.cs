using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace test.Models
{
    public partial class Welcome
    {
        [JsonPropertyName("init")]
        public Init Init { get; set; }

        [JsonPropertyName("end")]
        public List<End> End { get; set; }

        [JsonPropertyName("turns")]
        public List<Turn> Turns { get; set; }
    }

    public partial class End
    {
        [JsonPropertyName("playerId")]
        public int PlayerId { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }
    }

    public partial class Init
    {
        [JsonPropertyName("maxAP")]
        public int MaxAp { get; set; }

        [JsonPropertyName("graphicMap")]
        public GraphicMap GraphicMap { get; set; }

        [JsonPropertyName("baseUnits")]
        public List<BaseUnit> BaseUnits { get; set; }
    }

    public partial class BaseUnit
    {
        [JsonPropertyName("typeId")]
        public int TypeId { get; set; }

        [JsonPropertyName("maxHP")]
        public int MaxHp { get; set; }

        [JsonPropertyName("ap")]
        public int Ap { get; set; }
    }

    public partial class GraphicMap
    {
        [JsonPropertyName("row")]
        public int Row { get; set; }

        [JsonPropertyName("col")]
        public int Col { get; set; }

        [JsonPropertyName("kings")]
        public List<King> Kings { get; set; }

        [JsonPropertyName("paths")]
        public List<Path> Paths { get; set; }
    }

    public partial class King
    {
        [JsonPropertyName("row")]
        public int Row { get; set; }

        [JsonPropertyName("col")]
        public int Col { get; set; }

        [JsonPropertyName("pId")]
        public int PId { get; set; }

        [JsonPropertyName("hp")]
        public int Hp { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class Path
    {
        [JsonPropertyName("pathId")]
        public int PathId { get; set; }

        [JsonPropertyName("cells")]
        public List<Cell> Cells { get; set; }
    }

    public partial class Cell
    {
        [JsonPropertyName("row")]
        public int Row { get; set; }

        [JsonPropertyName("col")]
        public int Col { get; set; }
    }

    public partial class Turn
    {
        [JsonPropertyName("turnNum")]
        public int TurnNum { get; set; }

        [JsonPropertyName("playerTurnEvents")]
        public List<PlayerTurnEvent> PlayerTurnEvents { get; set; }

        [JsonPropertyName("turnAttacks")]
        public List<object> TurnAttacks { get; set; }
    }

    public partial class PlayerTurnEvent
    {
        [JsonPropertyName("pId")]
        public int PId { get; set; }

        [JsonPropertyName("turnEvent")]
        public TurnEvent TurnEvent { get; set; }
    }

    public partial class TurnEvent
    {
        [JsonPropertyName("isAlive")]
        public bool IsAlive { get; set; }

        [JsonPropertyName("ap")]
        public int Ap { get; set; }

        [JsonPropertyName("hp")]
        public int Hp { get; set; }

        [JsonPropertyName("hand")]
        public List<int> Hand { get; set; }

        [JsonPropertyName("units")]
        public List<Unit> Units { get; set; }

        [JsonPropertyName("mapSpells")]
        public List<object> MapSpells { get; set; }
    }

    public partial class Unit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("typeId")]
        public int TypeId { get; set; }

        [JsonPropertyName("row")]
        public int Row { get; set; }

        [JsonPropertyName("col")]
        public int Col { get; set; }

        [JsonPropertyName("hp")]
        public int Hp { get; set; }

        [JsonPropertyName("damageLevel")]
        public int DamageLevel { get; set; }

        [JsonPropertyName("rangeLevel")]
        public int RangeLevel { get; set; }
    }
}
