using Newtonsoft.Json;

namespace MyRecipeStorage.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Ingredient
    {
        [JsonProperty(PropertyName="quantity")]
        public decimal Quantity { get; set; }

        [JsonProperty(PropertyName="unit")]
        public string Unit { get; set; }

        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName="desc")]
        public string Desc { get; set; }

        [JsonProperty(PropertyName="ean")]
        public string Ean { get; set; }
    }
}