using Newtonsoft.Json;

namespace MyRecipeStorage.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Reference
    {
        [JsonProperty(PropertyName="author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName="desc")]
        public string Desc { get; set; }

        [JsonProperty(PropertyName="url")]
        public string Url { get; set; }
    }
}